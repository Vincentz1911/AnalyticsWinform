using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;
using Google.Apis.AnalyticsReporting.v4;
using Google.Apis.AnalyticsReporting.v4.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AnalyticsWinform
{
    public class Analytics
    {
        static string secret = "";
        static string email = "";
        static string appName = "";

        public Account_cls Account_cls { get; private set; }
        public Property_cls Property_cls { get; private set; }
        public View_cls View_cls { get; private set; }

        public BindingList<Account_cls> AccountsList = new BindingList<Account_cls>();
        public BindingList<Property_cls> PropertyList = new BindingList<Property_cls>();
        public BindingList<View_cls> ViewList = new BindingList<View_cls>();
        public BindingList<Oath2Files_cls> OathFileList = new BindingList<Oath2Files_cls>();

        public void Add2List()
        {
            for (int i = 0; i < Controller.OAuth2Files.Length; i++)
            {
                var filename = Path.GetFileName(Controller.OAuth2Files[i]).Split('_')[0];
                OathFileList.Add(new Oath2Files_cls { File = Controller.OAuth2Files[i], Account = filename + "@gmail.com", AppName = "Analytics_" + filename });
            }
        }

        async Task<UserCredential> GetCredential(int gmail)
        {
            secret = OathFileList[gmail].File;
            email = OathFileList[gmail].Account;
            appName = OathFileList[gmail].AppName;

            MessageBox.Show(secret + " " + email + " " + appName);

            using (var stream = new FileStream(secret, FileMode.Open, FileAccess.Read))
            {
                return await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets, new[] {
                                AnalyticsService.Scope.Analytics,
                                AnalyticsService.Scope.AnalyticsEdit,
                                AnalyticsService.Scope.AnalyticsManageUsers
                    }, email, CancellationToken.None, new FileDataStore(appName));
            }
        }

        public void GetAnalyticsAccounts(int gmail)
        {
            try
            {
                var credential = GetCredential(gmail).Result;
                using (var service = new AnalyticsService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = appName }))
                {
                    //var request = new BatchRequest(service);
                    AccountsList.Clear(); PropertyList.Clear(); ViewList.Clear();
                    foreach (var account in service.Management.Accounts.List().Execute().Items)
                    {
                        AccountsList.Add(new Account_cls { ID = int.Parse(account.Id), Name = account.Name });
                        foreach (var property in service.Management.Webproperties.List(account.Id).Execute().Items)
                        {
                            PropertyList.Add(new Property_cls { IDint = property.InternalWebPropertyId, UA = property.Id, Name = property.Name, Url = property.WebsiteUrl, AccountID = account.Id });
                            foreach (var view in service.Management.Profiles.List(account.Id, property.Id).Execute().Items)
                            {
                                ViewList.Add(new View_cls { ID = int.Parse(view.Id), Name = view.Name, Url = view.WebsiteUrl, PropertyId = property.Id });
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        //Creates new property and view at the selected account
        public string CreateNewProperty(string name, string url, string account, int gmail)
        {
            try
            {
                var credential = GetCredential(gmail).Result;
                using (var service = new AnalyticsService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = appName }))
                {
                    Webproperty body = new Webproperty
                    {
                        WebsiteUrl = url,
                        Name = url
                    };
                    Webproperty response = service.Management.Webproperties.Insert(body, account).Execute();

                    Profile profile = new Profile
                    {
                        Name = name,
                        WebsiteUrl = url
                    };
                    Profile prof_response = service.Management.Profiles.Insert(profile, response.AccountId, response.Id).Execute();

                    Clipboard.SetText(response.Id);
                    GetAnalyticsAccounts(gmail);

                    MessageBox.Show($"A new Property {response.Name} ({response.Id}) and View {prof_response.Name} ({prof_response.Id}) have been created on Account {response.AccountId}, and the UA-key have been copied to clipboard. When the UA-key have been added to the website, press Webmaster to create a Search Console property");

                    return response.Id.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return null; }
        }

        //Gets data from the view
        public DataTable GetAnalyticsStream(string VID, string fromDate, string toDate, int gmail)
        {
            try
            {
                var credential = GetCredential(gmail).Result;

                using (var service = new AnalyticsReportingService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = appName }))
                {
                    var dateRange = new DateRange { StartDate = fromDate, EndDate = toDate };
                    var date = new Dimension { Name = "ga:date" };

                    var sessions = new Metric { Expression = "ga:sessions", Alias = "Sessions" };
                    var goalCompletionsAll = new Metric { Expression = "ga:goalCompletionsAll", Alias = "Goal Completions" };
                    var users = new Metric { Expression = "ga:users", Alias = "Users" };
                    var avgTimeOnPage = new Metric { Expression = "ga:avgTimeOnPage", Alias = "Time on Page" };
                    var bounceRate = new Metric { Expression = "ga:bounceRate", Alias = "Bounce Rate" };

                    var reportRequest = new ReportRequest
                    {
                        DateRanges = new List<DateRange> { dateRange },
                        Dimensions = new List<Dimension> { date },
                        Metrics = new List<Metric> { sessions, goalCompletionsAll, users, avgTimeOnPage, bounceRate },
                        ViewId = VID
                    };
                    var getReportsRequest = new GetReportsRequest
                    {
                        ReportRequests = new List<ReportRequest> { reportRequest }
                    };
                    var batchRequest = service.Reports.BatchGet(getReportsRequest);
                    var response = batchRequest.Execute();

                    DataTable table = new DataTable();

                    table.Columns.Add("Date", typeof(DateTime));
                    table.Columns.Add(sessions.Alias, typeof(int));
                    table.Columns.Add(goalCompletionsAll.Alias, typeof(int));
                    table.Columns.Add(users.Alias, typeof(int));
                    table.Columns.Add(avgTimeOnPage.Alias, typeof(TimeSpan));
                    table.Columns.Add(bounceRate.Alias, typeof(float));

                    foreach (var x in response.Reports.First().Data.Rows)
                    {
                        //Date
                        DateTime theTime = DateTime.ParseExact(x.Dimensions[0].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                        //TimeOnPage
                        string str = x.Metrics.First().Values[3];
                        TimeSpan timeOnPage = TimeSpan.FromSeconds(double.Parse(str.Substring(0, str.LastIndexOf("."))));
                        //Bounce

                        str = x.Metrics.First().Values[4];
                        float theBounce = float.Parse(str.Substring(0, str.LastIndexOf(".") + 2)) / 10;

                        table.Rows.Add(theTime,
                            x.Metrics.First().Values[0],
                            x.Metrics.First().Values[1],
                            x.Metrics.First().Values[2],
                            timeOnPage,
                            theBounce
                            );
                    }

                    return table;
                }
            }
            catch (Exception ex) { MessageBox.Show("No data found! " + ex); return null; }
        }

        public string GoToAnalyticsSite(string UA)
        {
            string p = "", a = "", v = "";
            for (int i = 0; i < PropertyList.Count; i++) { if (UA == PropertyList[i].UA) { p = PropertyList[i].IDint; a = PropertyList[i].AccountID.ToString(); break; } }
            for (int i = 0; i < ViewList.Count; i++) { if (UA == ViewList[i].PropertyId) { v = ViewList[i].ID.ToString(); break; } }
            string site = @"https://analytics.google.com/analytics/web/#/a" + a + "w" + p + "p" + v + "/admin";
            System.Diagnostics.Process.Start(site);
            return site;
        }

    }
}
