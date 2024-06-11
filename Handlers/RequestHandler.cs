using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CefSharp;
using CefSharp.Handler;

namespace SharpBrowser
{
    internal class RequestHandler : IRequestHandler
    {
        MainForm myForm;

        public RequestHandler(MainForm form)
        {
            myForm = form;
        }

        public static class AdBlocker
        {
            public static List<string> AdUrlPatterns = new List<string> {
                "*.doubleclick.net",
                "*.ads.yahoo.com",
                "*.googlesyndication.com",
                "*.adserver",
                "*.ads-api.twitter.com/",
                "*.ads.facebook.com/",
                "*.ads.youtube.com/",
                "*.google.com/adsense/start/images/favicon.ico/",
                "*.gstatic.com/adx/doubleclick.ico/",
                "*.bannertrack.net/",
                "*.adtrackers.net/",
                "*.adnetasia.com/",
                                "adclixx.net/",
                "2mdn-cn.net",
                 "2mdn.net",
                  "admob-cn.com",
                                  "doubleclick.net",

                "admob.com",
                "doubleclick-cn.net",
                "adwordsexpress.com",
                "google-analytics-cn.com",
                "google-analytics.com",
                "googleadapis.com",
                "googleads-cn.com",
                "googleads.com",
                "googleadservices-cn.com",
                "googleadservices.com",
                "googleadsserving.cn",

                "marketingplatform.google.com",
                "googleadapis.com",
                "googleadsserving.cn",
                "000lex4.wcomhost.com",
                "007.free-counters.co.uk",
                "000lkub.rcomhost.com",
                "01-prf-test-nym.ad.corp.appnexus.com",
                "061-bgc-590.mktoresp.com",
                "08.185.87.02.liveadvert.com",
                "08.185.87.117.liveadvert.com",
                "08.185.87.140.liveadvert.com",
                // Add more ad patterns as needed
            };
        }

        public bool GetAuthCredentials(IWebBrowser chromiumWebBrowser, IBrowser browser, string originUrl, bool isProxy, string host, int port, string realm, string scheme, IAuthCallback callback)
        {
            // Return false to cancel the request.
            return false;
        }

        public bool OnBeforeBrowse(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool userGesture, bool isRedirect)
        {
            return false;
        }

        public bool OnCertificateError(IWebBrowser browserControl, IBrowser browser, CefErrorCode errorCode, string requestUrl, ISslInfo sslInfo, IRequestCallback callback)
        {
            return true;
        }

        public bool OnOpenUrlFromTab(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, WindowOpenDisposition targetDisposition, bool userGesture)
        {
            return false;
        }

        public void OnPluginCrashed(IWebBrowser browserControl, IBrowser browser, string pluginPath)
        {
        }

        public bool OnQuotaRequest(IWebBrowser browserControl, IBrowser browser, string originUrl, long newSize, IRequestCallback callback)
        {
            callback.Continue(true);
            return true;
        }

        public void OnRenderProcessTerminated(IWebBrowser browserControl, IBrowser browser, CefTerminationStatus status)
        {
        }

        public void OnRenderViewReady(IWebBrowser browserControl, IBrowser browser)
        {
        }

        public IResourceRequestHandler GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            // Check if the URL matches any ad patterns
            var url = request.Url;
            if (AdBlocker.AdUrlPatterns.Any(pattern => url.Contains(pattern)))
            {
                // Block the request by returning null
                return null;
            }

            return new ResourceRequestHandler(myForm);
        }

        public bool OnSelectClientCertificate(IWebBrowser chromiumWebBrowser, IBrowser browser, bool isProxy, string host, int port, X509Certificate2Collection certificates, ISelectClientCertificateCallback callback)
        {
            return false;
        }

        public void OnDocumentAvailableInMainFrame(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
        }
    }
}
