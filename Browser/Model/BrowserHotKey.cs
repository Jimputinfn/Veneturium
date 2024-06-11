using System;
using System.Windows.Forms;

namespace SharpBrowser.Browser.Model
{
    /// <summary>
    /// POCO for holding hotkey data
    /// </summary>
    internal class BrowserHotKey
    {

        public Keys Key { get; }
        public int KeyCode { get; }
        public bool Ctrl { get; }
        public bool Shift { get; }
        public bool Alt { get; }
        public Action? Callback { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserHotKey"/> class.
        /// </summary>
        /// <param name="callback">The callback action to execute when the hotkey is triggered.</param>
        /// <param name="key">The main key of the hotkey.</param>
        /// <param name="ctrl">Whether Ctrl modifier is required.</param>
        /// <param name="shift">Whether Shift modifier is required.</param>
        /// <param name="alt">Whether Alt modifier is required.</param>
        public BrowserHotKey(Action? callback, Keys key, bool ctrl = false, bool shift = false, bool alt = false)
        {
            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback), "Callback action must not be null.");
            }

            if (key == Keys.None)
            {
                throw new ArgumentException("Key must be a valid key.", nameof(key));
            }

            Callback = callback;
            Key = key;
            KeyCode = (int)key;
            Ctrl = ctrl;
            Shift = shift;
            Alt = alt;
        }
    }
}
