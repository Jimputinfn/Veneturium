using CefSharp;

namespace SharpBrowser
{
    internal class DownloadHandler : IDownloadHandler
    {
        readonly MainForm myForm;

        public DownloadHandler(MainForm form)
        {
            myForm = form;
        }

        public bool CanDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, string url, string requestMethod)
        {
            // Implement your logic for determining if download is allowed
            return true;
        }

        public void OnBeforeDownload(IWebBrowser webBrowser, IBrowser browser, DownloadItem item, IBeforeDownloadCallback callback)
        {
            if (callback.IsDisposed)
                return;

            using (callback)
            {
                myForm.UpdateDownloadItem(item);

                string path = myForm.CalcDownloadPath(item);
                if (path == null)
                    callback.Continue(null, false);
                else
                {
                    myForm.OpenDownloadsTab();
                    callback.Continue(path, true);
                }
            }
        }

        public void OnDownloadUpdated(IWebBrowser webBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            myForm.UpdateDownloadItem(downloadItem);
            if (downloadItem.IsInProgress && myForm.CancelRequests.Contains(downloadItem.Id))
            {
                callback.Cancel();
            }
        }
    }
}
