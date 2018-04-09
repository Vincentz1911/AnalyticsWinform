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
                OathFileList.Add(new Oath2Files_cls { File = Controller.OAuth2Files[i], Account = filename + "@gmail.com", AppName = filename });
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

        public void WebmasterQuery(string siteUrl, string fromDate, string toDate, int gmail)
        {

            var credential = GetWebCredential(gmail).Result;
            var service = new WebmastersService(new BaseClientService.Initializer { HttpClientInitializer = credential, ApplicationName = WebAppName });

            List<string> Dim = new List<string>() {"query", "date", "device"};
            //Dim.Add("query");

            var body = new SearchAnalyticsQueryRequest
            {
                StartDate = fromDate,
                EndDate = toDate,
                Dimensions = Dim          
            };

            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (siteUrl == null)
                    throw new ArgumentNullException(siteUrl);

                // Make the request.
                var response = service.Searchanalytics.Query(body, siteUrl).Execute();
                //return service.Searchanalytics.Query(body, siteUrl).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Searchanalytics.Query failed.", ex);
            }
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

        public void RunVerification(string site, int gmail)
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
            catch (Exception ex)
            {
                throw new Exception("Verification failed", ex);
            }
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
                catch (Exception ex)
                {
                    throw new Exception("Request Sitemaps.Submit failed.", ex);
                }
        }

        public string VisitSearchConsoleWeb(string site)
        { return @"https://www.google.com/webmasters/tools/dashboard?hl=da&siteUrl=" + site.Replace("//", "%3A%2F%2F").Replace("/", "%2F"); }
    }
}
