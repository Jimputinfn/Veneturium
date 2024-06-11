using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using CefSharp;
using System.Windows.Forms;
using System.Drawing;
using CefSharp.Callback;

namespace SharpBrowser
{
    internal class SchemeHandler : IResourceHandler, IDisposable
    {
        private static readonly string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\";
        private string mimeType;
        private Stream stream;
        private readonly MainForm myForm;
        private Uri uri;
        private string fileName;

        public SchemeHandler(MainForm form)
        {
            myForm = form;
        }

        public void Dispose()
        {
            stream?.Dispose();
        }

        public bool Open(IRequest request, out bool handleRequest, ICallback callback)
        {
            uri = new Uri(request.Url);
            fileName = uri.AbsolutePath;

            // If url is blocked, cancel the request
            if (IsUrlBlocked(request.Url))
            {
                handleRequest = true;
                return false;
            }

            // Handle storage requests
            if (uri.Host == "storage")
            {
                fileName = appPath + uri.Host + fileName;
                if (File.Exists(fileName))
                {
                    Task.Run(() => ProcessStorageRequest(fileName, callback));
                    handleRequest = false;
                    return true;
                }
            }

            // Handle file icon requests
            if (uri.Host == "fileicon")
            {
                Task.Run(() => ProcessFileIconRequest(fileName, callback));
                handleRequest = false;
                return true;
            }

            // Default: reject request
            callback.Dispose();
            handleRequest = true;
            return false;
        }

        private bool IsUrlBlocked(string url)
        {
            // Add logic to block URLs if necessary
            return false;
        }

        private void ProcessStorageRequest(string fileName, ICallback callback)
        {
            try
            {
                using (callback)
                {
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    mimeType = ResourceHandler.GetMimeType(Path.GetExtension(fileName));
                    callback.Continue();
                }
            }
            catch
            {
                // Ignore exceptions
            }
        }

        private void ProcessFileIconRequest(string fileName, ICallback callback)
        {
            try
            {
                using (callback)
                {
                    stream = FileIconUtils.GetFileIcon(fileName, FileIconSize.Large);
                    mimeType = ResourceHandler.GetMimeType(".png");
                    callback.Continue();
                }
            }
            catch
            {
                // Ignore exceptions
            }
        }

        public void GetResponseHeaders(IResponse response, out long responseLength, out string redirectUrl)
        {
            responseLength = stream?.Length ?? 0;
            redirectUrl = null;

            response.StatusCode = (int)HttpStatusCode.OK;
            response.StatusText = "OK";
            response.MimeType = mimeType;
        }

        public bool ReadResponse(Stream dataOut, out int bytesRead, ICallback callback)
        {
            callback.Dispose();

            if (stream == null)
            {
                bytesRead = 0;
                return false;
            }

            var buffer = new byte[dataOut.Length];
            bytesRead = stream.Read(buffer, 0, buffer.Length);

            dataOut.Write(buffer, 0, buffer.Length);

            return bytesRead > 0;
        }

        public bool Read(Stream dataOut, out int bytesRead, IResourceReadCallback callback)
        {
            bytesRead = -1;
            return false;
        }

        public bool Skip(long bytesToSkip, out long bytesSkipped, IResourceSkipCallback callback)
        {
            bytesSkipped = -2;
            return false;
        }

        public void Cancel()
        {
            // Implement if needed
        }

        public bool CanGetCookie(CefSharp.Cookie cookie)
        {
            return true;
        }

        public bool CanSetCookie(CefSharp.Cookie cookie)
        {
            return true;
        }

        public bool ProcessRequest(IRequest request, ICallback callback)
        {
            return false;
        }
    }
}
