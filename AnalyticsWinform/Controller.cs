using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;

using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Webmasters.v3;
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;
using Google.Apis.AnalyticsReporting.v4;
using Google.Apis.AnalyticsReporting.v4.Data;
using Google.Apis.SiteVerification.v1;
using Google.Apis.SiteVerification.v1.Data;
using Google.Apis.Requests;

namespace AnalyticsWinform
{
    public class Controller
    {
        public Account_cls Account_cls { get; private set; }
        public Property_cls Property_cls { get; private set; }
        public View_cls View_cls { get; private set; }

        public BindingList<Account_cls> AccountsList = new BindingList<Account_cls>();
        public BindingList<Property_cls> PropertyList = new BindingList<Property_cls>();
        public BindingList<View_cls> ViewList = new BindingList<View_cls>();

        public static string secret = "client_secret.json";
        public static string email = "hpoulsen76@gmail.com";
        public static string appName = "AnalyticsWinform";

        //Get Google Oath 2.0 Credential and Tokens
        async Task<UserCredential> GetCredential()
        {
            using (var stream = new FileStream(secret, FileMode.Open, FileAccess.Read))
            {
                return await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets, new[] {
                                AnalyticsService.Scope.Analytics,
                                //AnalyticsService.Scope.AnalyticsReadonly,
                                AnalyticsService.Scope.AnalyticsEdit,
                                AnalyticsService.Scope.AnalyticsManageUsers,
                                //AnalyticsService.Scope.AnalyticsManageUsersReadonly,
                                WebmastersService.Scope.Webmasters,
                                SiteVerificationService.Scope.Siteverification

                    }, email, CancellationToken.None, new FileDataStore(appName));
            }
        }

        //Gets analytics accounts connected to the Gmail account and adds them to lists
        public void GetAnalyticsAccounts()
        {
            try
            {
                var credential = GetCredential().Result;
                using (var service = new AnalyticsService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = appName }))
                {
                    //var request = new BatchRequest(service);
                    AccountsList.Clear(); PropertyList.Clear(); ViewList.Clear();
                    foreach (var account in service.Management.Accounts.List().Execute().Items)
                    {
                        AccountsList.Add(new Account_cls { ID = int.Parse(account.Id), Name = account.Name });
                        foreach (var property in service.Management.Webproperties.List(account.Id).Execute().Items)
                        {
                            PropertyList.Add(new Property_cls { ID = property.Id, Name = property.Name, Url = property.WebsiteUrl });
                            foreach (var view in service.Management.Profiles.List(account.Id, property.Id).Execute().Items)
                            {
                                ViewList.Add(new View_cls { ID = int.Parse(view.Id), Name = view.Name, Url = view.WebsiteUrl });
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //Creates new property and view at the selected account
        public string CreateNewProperty(string name, string url, string account)
        {
            try
            {
                var credential = GetCredential().Result;
                using (var service = new AnalyticsService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = appName }))
                {
                    Webproperty body = new Webproperty();
                    body.WebsiteUrl = url;
                    body.Name = url;
                    Webproperty response = service.Management.Webproperties.Insert(body, account).Execute();

                    Profile profile = new Profile();
                    profile.Name = name;
                    profile.WebsiteUrl = url;
                    Profile prof_response = service.Management.Profiles.Insert(profile, response.AccountId, response.Id).Execute();

                    Clipboard.SetText(response.Id);
                    GetAnalyticsAccounts();

                    MessageBox.Show($"A new Property {response.Name} ({response.Id}) and View {prof_response.Name} ({prof_response.Id}) have been created on Account {response.AccountId}, and the UA-key have been copied to clipboard. When the UA-key have been added to the website, press Webmaster to create a Search Console property");

                    return response.Id.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return null; }
        }
        //Gets data from the view
        public DataTable GetAnalyticsStream(string VID, string fromDate, string toDate)
        {
            try
            {
                var credential = GetCredential().Result;

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
            catch (Exception ex) { MessageBox.Show("No data found!"); return null; }
            //            catch (Exception ex) { MessageBox.Show(ex.ToString()); return null; }
        }
        //Get sum of rows from Datatable
        public Decimal SumOfRows(DataTable DT, int collumn)
        {
            decimal o = 0;
            if (DT.Rows.Count > 0)
            {
                for (int i = 0; i < DT.Rows.Count; i++) { o += decimal.Parse(DT.Rows[i][collumn].ToString()); }
            }
            return o;
        }
        //Get last row with value from Datatable
        public string GetLast(DataTable table, string collumn)
        {
            int value = 0;
            for (int i = 1; i < table.Rows.Count; i++)
            {
                value = int.Parse(table.Rows[table.Rows.Count - i][collumn].ToString());
                if (value > 0) { return table.Rows[table.Rows.Count - i]["Date"].ToString(); }
            }
            return null;
        }


        public void AddWebmasterSite(string siteUrl)
        {
            var credential = GetCredential().Result;
            using (var service = new WebmastersService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = appName }))
                try
                {
                    // Initial validation.
                    if (service == null)
                        throw new ArgumentNullException("service");
                    if (siteUrl == null)
                        throw new ArgumentNullException(siteUrl);

                    // Make the request.
                    service.Sites.Add(siteUrl).Execute();
                }
                catch (Exception ex)
                {
                    throw new Exception("Request Sites.Add failed.", ex);
                }
        }

        //[STAThread]
        public void RunVerification(string site)
        {
            UserCredential credential;
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { SiteVerificationService.Scope.Siteverification },
                    Controller.email, CancellationToken.None, new FileDataStore("SiteVerification.VerifySite")).Result;
            }

            // Create the service.
            var service = new SiteVerificationService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = appName });



            // Example of a GetToken call.
            //Console.WriteLine("Retrieving a meta token ...");
            //var request = service.WebResource.GetToken(new SiteVerificationWebResourceGettokenRequest()
            //{
            //    VerificationMethod = "meta",
            //    Site = new SiteVerificationWebResourceGettokenRequest.SiteData()
            //    {
            //        Identifier = site,
            //        Type = "site"
            //    }
            //});
            //var response = request.Execute();
            //Console.WriteLine("Token: " + response.Token);
            //Console.WriteLine();

            //Console.WriteLine("Please place this token on your webpage now.");
            //Console.WriteLine("Press ENTER to continue");
            //Console.ReadLine();
            //Console.WriteLine();

            //// Example of an Insert call.
            //Console.WriteLine("Verifying...");

            var body = new SiteVerificationWebResourceResource();
            body.Site = new SiteVerificationWebResourceResource.SiteData();
            body.Site.Identifier = site;
            body.Site.Type = "site";

            var verificationResponse = service.WebResource.Insert(body, "analytics").Execute();

            MessageBox.Show("Verification:" + verificationResponse.Id);
        }

        public void SubmitSitemap(string siteUrl)
        {
            string feedpath = "/sitemap.xml";
            var credential = GetCredential().Result;
            using (var service = new WebmastersService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = appName }))
                try
                {
                    // Initial validation.
                    if (service == null)
                        throw new ArgumentNullException("service");
                    if (siteUrl == null)
                        throw new ArgumentNullException(siteUrl);
                    if (feedpath == null)
                        throw new ArgumentNullException(feedpath);

                    // Make the request.
                    service.Sitemaps.Submit(siteUrl, siteUrl + feedpath).Execute();
                }
                catch (Exception ex)
                {
                    throw new Exception("Request Sitemaps.Submit failed.", ex);
                }
        }
    }

}
