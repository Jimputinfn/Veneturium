using System;


namespace SharpBrowser
{
    internal class HostHandler
    {
        private readonly MainForm myForm;

        public HostHandler(MainForm form)
        {
            myForm = form;
        }

        /// <summary>
        /// Adds a new browser tab with the specified URL.
        /// </summary>
        /// <param name="url">The URL to navigate to.</param>
        /// <param name="focusNewTab">Whether to focus the new tab.</param>
        public void AddNewBrowserTab(string url, bool focusNewTab = true)
        {
            myForm.AddNewBrowserTab(url, focusNewTab);
        }

        /// <summary>
        /// Gets the downloads list as JSON string.
        /// </summary>
        /// <returns>The downloads list as JSON string.</returns>
        public string GetDownloads()
        {
            string json;
            lock (myForm.downloads)
            {
                json = JSON.Instance.ToJSON(myForm.downloads);
            }
            return json;
        }

        /// <summary>
        /// Cancels the download with the specified ID.
        /// </summary>
        /// <param name="downloadId">The ID of the download to cancel.</param>
        /// <returns>True if the download was successfully canceled; otherwise, false.</returns>
        public bool CancelDownload(int downloadId)
        {
            lock (myForm.downloadCancelRequests)
            {
                if (!myForm.downloadCancelRequests.Contains(downloadId))
                {
                    myForm.downloadCancelRequests.Add(downloadId);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Refreshes the active browser tab.
        /// </summary>
        public void RefreshActiveTab()
        {
            myForm.RefreshActiveTab();
        }
    }
}
