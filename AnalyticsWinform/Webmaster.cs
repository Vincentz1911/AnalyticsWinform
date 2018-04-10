using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.SiteVerification.v1;
using Google.Apis.SiteVerification.v1.Data;
using Google.Apis.Util.Store;
using Google.Apis.Webmasters.v3;
using Google.Apis.Webmasters.v3.Data;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace AnalyticsWinform
{
    public class Webmaster
    {
        static string WebSecret = "", WebEmail = "", WebAppName = "";
        public BindingList<Oath2Files_cls> OathFileList = new BindingList<Oath2Files_cls>();
        public void Add2List()
        {
            for (int i = 0; i < Controller.OAuth2Files.Length; i++)
            {
                var filename = Path.GetFileName(Controller.OAuth2Files[i]).Split('_')[0];
                OathFileList.Add(new Oath2Files_cls { File = Controller.OAuth2Files[i], Account = filename + "@gmail.com", AppName = "Webmaster_" + filename });
            }
        }

        async Task<UserCredential> GetWebCredential(int gmail)
        {
            WebSecret = OathFileList[gmail].File;
            WebEmail = OathFileList[gmail].Account;
            WebAppName = OathFileList[gmail].AppName;

            using (var stream = new FileStream(WebSecret, FileMode.Open, FileAccess.Read))
            {
                return await GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                    new[] { WebmastersService.Scope.Webmasters, SiteVerificationService.Scope.Siteverification },
                    WebEmail, CancellationToken.None, new FileDataStore(WebAppName));
            }
        }

        public DataTable WebmasterQuery(string siteUrl, string fromDate, string toDate, int gmail, string Dimension)
        {
            var credential = GetWebCredential(gmail).Result;
            var service = new WebmastersService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = WebAppName });

            List<string> DimList = new List<string>() { Dimension };
            var body = new SearchAnalyticsQueryRequest {StartDate = fromDate,EndDate = toDate, Dimensions = DimList };

            try
            {
                // Initial validation.
                if (service == null) throw new ArgumentNullException("service");
                if (body == null) throw new ArgumentNullException("body");
                if (siteUrl == null) throw new ArgumentNullException(siteUrl);

                var response = service.Searchanalytics.Query(body, siteUrl).Execute();

                if (response != null)
                {
                    DataTable DT = new DataTable();

                    DT.Columns.Add("Query");
                    DT.Columns.Add("Clicks");
                    DT.Columns.Add("Impressions");
                    DT.Columns.Add("CTR");
                    DT.Columns.Add("Position");
                    //DT.Columns.Add("Date");
                    //DT.Columns.Add("Device");
                    //DT.Columns.Add("Clicks");
                    for (int i = 0; i < response.Rows.Count; i++)
                    {
                        DT.Rows.Add(response.Rows[i].Keys[0], response.Rows[i].Clicks, response.Rows[i].Impressions, response.Rows[i].Ctr, response.Rows[i].Position);
                    }
                    return DT;
                }
                else return null;


            }
            catch (Exception ex) { MessageBox.Show("No data found! " + ex); return null; }
            //{
            //    throw new Exception("Request Searchanalytics.Query failed.", ex);
            //    //return null;
            //}
        }

        public void AddWebmasterSite(string siteUrl, int gmail)
        {
            var credential = GetWebCredential(gmail).Result;
            using (var service = new WebmastersService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = WebAppName }))
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

        public string GetToken(string site, int gmail)
        {
            var credential = GetWebCredential(gmail).Result;
            var service = new SiteVerificationService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = WebAppName });

            var request = service.WebResource.GetToken(new SiteVerificationWebResourceGettokenRequest()
            {
                VerificationMethod = "meta",
                Site = new SiteVerificationWebResourceGettokenRequest.SiteData()
                {
                    Identifier = site,
                    Type = "site"
                }
            });
            var response = request.Execute();
            return response.Token;
        }

        public void RunVerification(string site, int gmail, string verification)
        {
            var credential = GetWebCredential(gmail).Result;
            var service = new SiteVerificationService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = WebAppName });

            try
            {
                var body = new SiteVerificationWebResourceResource
                {
                    Site = new SiteVerificationWebResourceResource.SiteData()
                };
                body.Site.Identifier = site;
                body.Site.Type = "site";

                var verificationResponse = service.WebResource.Insert(body, "meta").Execute();
                MessageBox.Show("Verification:" + verificationResponse.Id);

            }
            catch (Exception ex) { MessageBox.Show("Verification failed! \n\n " + ex); }
            //{
            //    throw new Exception("Verification failed", ex);
            //}
        }

        public void SubmitSitemap(string siteUrl, int gmail)
        {
            string feedpath = "/sitemap.xml";
            var credential = GetWebCredential(gmail).Result;
            using (var service = new WebmastersService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = WebAppName }))
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
                catch (Exception ex) { MessageBox.Show("Sitemap not added! \n\n " + ex); }
            //{
            //        throw new Exception("Request Sitemaps.Submit failed.", ex);
            //    }
        }

        public string VisitSearchConsoleWeb(string site)
        { return @"https://www.google.com/webmasters/tools/dashboard?hl=da&siteUrl=" + site.Replace("//", "%3A%2F%2F").Replace("/", "%2F"); }
    }
}
