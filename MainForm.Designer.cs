﻿namespace SharpBrowser
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStripTab = new System.Windows.Forms.ContextMenuStrip(components);
            menuCloseTab = new System.Windows.Forms.ToolStripMenuItem();
            menuCloseOtherTabs = new System.Windows.Forms.ToolStripMenuItem();
            BtnRefresh = new System.Windows.Forms.Button();
            BtnStop = new System.Windows.Forms.Button();
            BtnForward = new System.Windows.Forms.Button();
            BtnBack = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            BtnDownloads = new System.Windows.Forms.Button();
            TxtURL = new System.Windows.Forms.TextBox();
            PanelToolbar = new System.Windows.Forms.Panel();
            BtnHome = new System.Windows.Forms.Button();
            TabPages = new Controls.BrowserTabStrip.BrowserTabStrip();
            tabStrip1 = new Controls.BrowserTabStrip.BrowserTabStripItem();
            tabStripAdd = new Controls.BrowserTabStrip.BrowserTabStripItem();
            PanelStatus = new System.Windows.Forms.Panel();
            PanelSearch = new System.Windows.Forms.Panel();
            BtnNextSearch = new System.Windows.Forms.Button();
            BtnPrevSearch = new System.Windows.Forms.Button();
            BtnCloseSearch = new System.Windows.Forms.Button();
            TxtSearch = new System.Windows.Forms.TextBox();
            menuStripTab.SuspendLayout();
            PanelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabPages).BeginInit();
            TabPages.SuspendLayout();
            PanelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTab
            // 
            menuStripTab.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuCloseTab, menuCloseOtherTabs });
            menuStripTab.Name = "menuStripTab";
            menuStripTab.Size = new System.Drawing.Size(170, 48);
            // 
            // menuCloseTab
            // 
            menuCloseTab.Name = "menuCloseTab";
            menuCloseTab.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4;
            menuCloseTab.Size = new System.Drawing.Size(169, 22);
            menuCloseTab.Text = "Close tab";
            menuCloseTab.Click += menuCloseTab_Click;
            // 
            // menuCloseOtherTabs
            // 
            menuCloseOtherTabs.Name = "menuCloseOtherTabs";
            menuCloseOtherTabs.Size = new System.Drawing.Size(169, 22);
            menuCloseOtherTabs.Text = "Close other tabs";
            menuCloseOtherTabs.Click += menuCloseOtherTabs_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnRefresh.ForeColor = System.Drawing.Color.Black;
            BtnRefresh.Image = (System.Drawing.Image)resources.GetObject("BtnRefresh.Image");
            BtnRefresh.Location = new System.Drawing.Point(878, 0);
            BtnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new System.Drawing.Size(25, 30);
            BtnRefresh.TabIndex = 3;
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += bRefresh_Click;
            // 
            // BtnStop
            // 
            BtnStop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnStop.ForeColor = System.Drawing.Color.White;
            BtnStop.Image = (System.Drawing.Image)resources.GetObject("BtnStop.Image");
            BtnStop.Location = new System.Drawing.Point(878, -2);
            BtnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new System.Drawing.Size(25, 30);
            BtnStop.TabIndex = 2;
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += bStop_Click;
            // 
            // BtnForward
            // 
            BtnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnForward.ForeColor = System.Drawing.Color.Black;
            BtnForward.Image = (System.Drawing.Image)resources.GetObject("BtnForward.Image");
            BtnForward.Location = new System.Drawing.Point(29, 0);
            BtnForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnForward.Name = "BtnForward";
            BtnForward.Size = new System.Drawing.Size(25, 30);
            BtnForward.TabIndex = 1;
            BtnForward.UseVisualStyleBackColor = true;
            BtnForward.Click += bForward_Click;
            // 
            // BtnBack
            // 
            BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnBack.ForeColor = System.Drawing.Color.Black;
            BtnBack.Image = (System.Drawing.Image)resources.GetObject("BtnBack.Image");
            BtnBack.Location = new System.Drawing.Point(2, 0);
            BtnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new System.Drawing.Size(25, 30);
            BtnBack.TabIndex = 0;
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += bBack_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // BtnDownloads
            // 
            BtnDownloads.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnDownloads.ForeColor = System.Drawing.Color.Black;
            BtnDownloads.Image = (System.Drawing.Image)resources.GetObject("BtnDownloads.Image");
            BtnDownloads.Location = new System.Drawing.Point(906, 0);
            BtnDownloads.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnDownloads.Name = "BtnDownloads";
            BtnDownloads.Size = new System.Drawing.Size(25, 30);
            BtnDownloads.TabIndex = 4;
            BtnDownloads.Tag = "Downloads";
            BtnDownloads.UseVisualStyleBackColor = true;
            BtnDownloads.Click += bDownloads_Click;
            // 
            // TxtURL
            // 
            TxtURL.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TxtURL.BackColor = System.Drawing.Color.Black;
            TxtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtURL.ForeColor = System.Drawing.SystemColors.Info;
            TxtURL.Location = new System.Drawing.Point(60, 4);
            TxtURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TxtURL.Name = "TxtURL";
            TxtURL.Size = new System.Drawing.Size(781, 22);
            TxtURL.TabIndex = 5;
            TxtURL.Click += txtUrl_Click;
            TxtURL.TextChanged += txtUrl_TextChanged;
            TxtURL.KeyDown += TxtURL_KeyDown;
            // 
            // PanelToolbar
            // 
            PanelToolbar.BackColor = System.Drawing.Color.Black;
            PanelToolbar.Controls.Add(BtnHome);
            PanelToolbar.Controls.Add(TxtURL);
            PanelToolbar.Controls.Add(BtnDownloads);
            PanelToolbar.Controls.Add(BtnForward);
            PanelToolbar.Controls.Add(BtnBack);
            PanelToolbar.Controls.Add(BtnRefresh);
            PanelToolbar.Controls.Add(BtnStop);
            PanelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            PanelToolbar.Location = new System.Drawing.Point(0, 0);
            PanelToolbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PanelToolbar.Name = "PanelToolbar";
            PanelToolbar.Size = new System.Drawing.Size(934, 30);
            PanelToolbar.TabIndex = 6;
            // 
            // BtnHome
            // 
            BtnHome.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnHome.ForeColor = System.Drawing.Color.Black;
            BtnHome.Location = new System.Drawing.Point(847, 0);
            BtnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new System.Drawing.Size(25, 30);
            BtnHome.TabIndex = 6;
            BtnHome.Tag = "Home";
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // TabPages
            // 
            TabPages.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            TabPages.ContextMenuStrip = menuStripTab;
            TabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            TabPages.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TabPages.Items.AddRange(new Controls.BrowserTabStrip.BrowserTabStripItem[] { tabStrip1, tabStripAdd });
            TabPages.Location = new System.Drawing.Point(0, 30);
            TabPages.Name = "TabPages";
            TabPages.Padding = new System.Windows.Forms.Padding(1, 29, 1, 1);
            TabPages.SelectedItem = tabStrip1;
            TabPages.Size = new System.Drawing.Size(934, 641);
            TabPages.TabIndex = 4;
            TabPages.Text = "faTabStrip1";
            TabPages.TabStripItemSelectionChanged += OnTabsChanged;
            TabPages.TabStripItemClosed += OnTabClosed;
            TabPages.MouseClick += tabPages_MouseClick;
            // 
            // tabStrip1
            // 
            tabStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabStrip1.IsDrawn = true;
            tabStrip1.Location = new System.Drawing.Point(1, 29);
            tabStrip1.Name = "tabStrip1";
            tabStrip1.Selected = true;
            tabStrip1.Size = new System.Drawing.Size(932, 611);
            tabStrip1.TabIndex = 0;
            tabStrip1.Title = "Loading...";
            tabStrip1.Changed += tabStrip1_Changed;
            // 
            // tabStripAdd
            // 
            tabStripAdd.CanClose = false;
            tabStripAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            tabStripAdd.IsDrawn = true;
            tabStripAdd.Location = new System.Drawing.Point(0, 0);
            tabStripAdd.Name = "tabStripAdd";
            tabStripAdd.Size = new System.Drawing.Size(931, 601);
            tabStripAdd.TabIndex = 1;
            tabStripAdd.Title = "+";
            // 
            // PanelStatus
            // 
            PanelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            PanelStatus.Location = new System.Drawing.Point(0, 671);
            PanelStatus.Name = "PanelStatus";
            PanelStatus.Size = new System.Drawing.Size(934, 0);
            PanelStatus.TabIndex = 8;
            // 
            // PanelSearch
            // 
            PanelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            PanelSearch.BackColor = System.Drawing.Color.Black;
            PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelSearch.Controls.Add(BtnNextSearch);
            PanelSearch.Controls.Add(BtnPrevSearch);
            PanelSearch.Controls.Add(BtnCloseSearch);
            PanelSearch.Controls.Add(TxtSearch);
            PanelSearch.Location = new System.Drawing.Point(625, 41);
            PanelSearch.Name = "PanelSearch";
            PanelSearch.Size = new System.Drawing.Size(307, 40);
            PanelSearch.TabIndex = 9;
            PanelSearch.Visible = false;
            // 
            // BtnNextSearch
            // 
            BtnNextSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnNextSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnNextSearch.ForeColor = System.Drawing.Color.Black;
            BtnNextSearch.Image = (System.Drawing.Image)resources.GetObject("BtnNextSearch.Image");
            BtnNextSearch.Location = new System.Drawing.Point(239, 4);
            BtnNextSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnNextSearch.Name = "BtnNextSearch";
            BtnNextSearch.Size = new System.Drawing.Size(25, 30);
            BtnNextSearch.TabIndex = 9;
            BtnNextSearch.Tag = "Find next (Enter)";
            BtnNextSearch.UseVisualStyleBackColor = true;
            BtnNextSearch.Click += BtnNextSearch_Click;
            // 
            // BtnPrevSearch
            // 
            BtnPrevSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnPrevSearch.BackColor = System.Drawing.Color.Black;
            BtnPrevSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnPrevSearch.ForeColor = System.Drawing.Color.Black;
            BtnPrevSearch.Image = (System.Drawing.Image)resources.GetObject("BtnPrevSearch.Image");
            BtnPrevSearch.Location = new System.Drawing.Point(206, 4);
            BtnPrevSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnPrevSearch.Name = "BtnPrevSearch";
            BtnPrevSearch.Size = new System.Drawing.Size(25, 30);
            BtnPrevSearch.TabIndex = 8;
            BtnPrevSearch.Tag = "Find previous (Shift+Enter)";
            BtnPrevSearch.UseVisualStyleBackColor = false;
            BtnPrevSearch.Click += BtnPrevSearch_Click;
            // 
            // BtnCloseSearch
            // 
            BtnCloseSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnCloseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnCloseSearch.ForeColor = System.Drawing.Color.Black;
            BtnCloseSearch.Image = (System.Drawing.Image)resources.GetObject("BtnCloseSearch.Image");
            BtnCloseSearch.Location = new System.Drawing.Point(272, 4);
            BtnCloseSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnCloseSearch.Name = "BtnCloseSearch";
            BtnCloseSearch.Size = new System.Drawing.Size(25, 30);
            BtnCloseSearch.TabIndex = 7;
            BtnCloseSearch.Tag = "Close (Esc)";
            BtnCloseSearch.UseVisualStyleBackColor = true;
            BtnCloseSearch.Click += BtnClearSearch_Click;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtSearch.Location = new System.Drawing.Point(10, 6);
            TxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new System.Drawing.Size(174, 25);
            TxtSearch.TabIndex = 6;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            TxtSearch.KeyDown += TxtSearch_KeyDown;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(934, 671);
            Controls.Add(PanelSearch);
            Controls.Add(TabPages);
            Controls.Add(PanelToolbar);
            Controls.Add(PanelStatus);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Title";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStripTab.ResumeLayout(false);
            PanelToolbar.ResumeLayout(false);
            PanelToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TabPages).EndInit();
            TabPages.ResumeLayout(false);
            PanelSearch.ResumeLayout(false);
            PanelSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SharpBrowser.Controls.BrowserTabStrip.BrowserTabStrip TabPages;
        private SharpBrowser.Controls.BrowserTabStrip.BrowserTabStripItem tabStrip1;
        private SharpBrowser.Controls.BrowserTabStrip.BrowserTabStripItem tabStripAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip menuStripTab;
        private System.Windows.Forms.ToolStripMenuItem menuCloseTab;
        private System.Windows.Forms.ToolStripMenuItem menuCloseOtherTabs;
        private System.Windows.Forms.Button BtnForward;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnDownloads;
        private System.Windows.Forms.TextBox TxtURL;
        private System.Windows.Forms.Panel PanelToolbar;
        private System.Windows.Forms.Panel PanelStatus;
        private System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnCloseSearch;
        private System.Windows.Forms.Button BtnPrevSearch;
        private System.Windows.Forms.Button BtnNextSearch;
        private System.Windows.Forms.Button BtnHome;
    }
}

