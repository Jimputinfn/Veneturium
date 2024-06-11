using CefSharp;
using System;

namespace SharpBrowser
{
    internal class SchemeHandlerFactory : ISchemeHandlerFactory
    {
        // Create method to instantiate a new SchemeHandler.
        public IResourceHandler Create(IBrowser browser, IFrame frame, string schemeName, IRequest request)
        {
            // Ensure MainForm.Instance is not null to avoid potential null reference exceptions.
            if (MainForm.Instance == null)
            {
                throw new InvalidOperationException("MainForm instance is not initialized.");
            }

            // Return a new instance of SchemeHandler, passing the MainForm instance.
            return new SchemeHandler(MainForm.Instance);
        }
    }
}
