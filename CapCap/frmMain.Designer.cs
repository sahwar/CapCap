﻿namespace CapCap
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.NOTI = new System.Windows.Forms.NotifyIcon(this.components);
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsmiOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.panelInnerAbout = new System.Windows.Forms.Panel();
            this.label_Version = new System.Windows.Forms.Label();
            this.lnkRUC80 = new System.Windows.Forms.Label();
            this.lnkWeibo = new System.Windows.Forms.LinkLabel();
            this.btnCloseAboutPanel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.LV = new System.Windows.Forms.ListView();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tsddbSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_ShowAds = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Lang_EN_US = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Lang_ZH_CN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Cursor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Notification = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Sound = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_ReName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_OverWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_BMP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_GIF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_JPEG = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_PNG = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_TIFF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnNewHotKey = new System.Windows.Forms.ToolStripButton();
            this.tsSeparatorBeforeStatus = new System.Windows.Forms.ToolStripSeparator();
            this.tslab_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsbtnFolder = new System.Windows.Forms.ToolStripButton();
            this.tstbNamePattern = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnInsertVariable = new System.Windows.Forms.ToolStripDropDownButton();
            this.tslImageFormat = new System.Windows.Forms.ToolStripLabel();
            this.tsddbMainMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparatorOfNumber = new System.Windows.Forms.ToolStripSeparator();
            this.tslNumber = new System.Windows.Forms.ToolStripLabel();
            this.tstbNumber = new System.Windows.Forms.ToolStripTextBox();
            this.panelRUC80 = new System.Windows.Forms.Panel();
            this.picRUC80 = new System.Windows.Forms.PictureBox();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.tsHelp = new System.Windows.Forms.ToolStrip();
            this.tsReturnToMainPanel = new System.Windows.Forms.ToolStripButton();
            this.panelHotKey = new System.Windows.Forms.Panel();
            this.lab_NewHotKey = new System.Windows.Forms.Label();
            this.webHelp = new System.Windows.Forms.WebBrowser();
            this.tsmi_ClearHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.CMS.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.panelInnerAbout.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.ss.SuspendLayout();
            this.ts.SuspendLayout();
            this.panelRUC80.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRUC80)).BeginInit();
            this.panelHelp.SuspendLayout();
            this.tsHelp.SuspendLayout();
            this.panelHotKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // NOTI
            // 
            this.NOTI.Icon = ((System.Drawing.Icon)(resources.GetObject("NOTI.Icon")));
            this.NOTI.Text = "CapCap";
            this.NOTI.Visible = true;
            this.NOTI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NOTI_MouseClick);
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsmiOpenFolder,
            this.toolStripSeparator4,
            this.cmsmiExit});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(148, 54);
            // 
            // cmsmiOpenFolder
            // 
            this.cmsmiOpenFolder.Name = "cmsmiOpenFolder";
            this.cmsmiOpenFolder.Size = new System.Drawing.Size(147, 22);
            this.cmsmiOpenFolder.Text = "Open folder";
            this.cmsmiOpenFolder.Click += new System.EventHandler(this.cmsmiOpenFolder_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(144, 6);
            // 
            // cmsmiExit
            // 
            this.cmsmiExit.Name = "cmsmiExit";
            this.cmsmiExit.Size = new System.Drawing.Size(147, 22);
            this.cmsmiExit.Text = "Exit";
            this.cmsmiExit.Click += new System.EventHandler(this.cmsmiExit_Click);
            // 
            // panelAbout
            // 
            this.panelAbout.Controls.Add(this.panelInnerAbout);
            this.panelAbout.Location = new System.Drawing.Point(343, 153);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(354, 205);
            this.panelAbout.TabIndex = 11;
            // 
            // panelInnerAbout
            // 
            this.panelInnerAbout.Controls.Add(this.label_Version);
            this.panelInnerAbout.Controls.Add(this.lnkRUC80);
            this.panelInnerAbout.Controls.Add(this.lnkWeibo);
            this.panelInnerAbout.Controls.Add(this.btnCloseAboutPanel);
            this.panelInnerAbout.Controls.Add(this.label2);
            this.panelInnerAbout.Controls.Add(this.label1);
            this.panelInnerAbout.Controls.Add(this.label3);
            this.panelInnerAbout.Location = new System.Drawing.Point(12, 12);
            this.panelInnerAbout.Name = "panelInnerAbout";
            this.panelInnerAbout.Size = new System.Drawing.Size(377, 239);
            this.panelInnerAbout.TabIndex = 4;
            // 
            // label_Version
            // 
            this.label_Version.AutoSize = true;
            this.label_Version.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Version.Location = new System.Drawing.Point(255, 40);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(39, 20);
            this.label_Version.TabIndex = 10;
            this.label_Version.Text = "Beta";
            // 
            // lnkRUC80
            // 
            this.lnkRUC80.AutoSize = true;
            this.lnkRUC80.BackColor = System.Drawing.Color.Crimson;
            this.lnkRUC80.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkRUC80.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkRUC80.ForeColor = System.Drawing.Color.White;
            this.lnkRUC80.Location = new System.Drawing.Point(280, 133);
            this.lnkRUC80.Name = "lnkRUC80";
            this.lnkRUC80.Size = new System.Drawing.Size(55, 17);
            this.lnkRUC80.TabIndex = 9;
            this.lnkRUC80.Text = "#RUC80";
            this.lnkRUC80.Click += new System.EventHandler(this.lnkRUC80_Click);
            // 
            // lnkWeibo
            // 
            this.lnkWeibo.Location = new System.Drawing.Point(3, 150);
            this.lnkWeibo.Name = "lnkWeibo";
            this.lnkWeibo.Size = new System.Drawing.Size(371, 22);
            this.lnkWeibo.TabIndex = 8;
            this.lnkWeibo.TabStop = true;
            this.lnkWeibo.Text = "@BO-SoftwareService";
            this.lnkWeibo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkWeibo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWeibo_LinkClicked);
            // 
            // btnCloseAboutPanel
            // 
            this.btnCloseAboutPanel.AutoSize = true;
            this.btnCloseAboutPanel.Location = new System.Drawing.Point(152, 187);
            this.btnCloseAboutPanel.Name = "btnCloseAboutPanel";
            this.btnCloseAboutPanel.Size = new System.Drawing.Size(75, 23);
            this.btnCloseAboutPanel.TabIndex = 7;
            this.btnCloseAboutPanel.Text = "okay";
            this.btnCloseAboutPanel.UseVisualStyleBackColor = true;
            this.btnCloseAboutPanel.Click += new System.EventHandler(this.btnCloseAboutPanel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(91, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Boss Ox / 2017.10.08 / Beijing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(130, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "CapCap";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(52, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Screen capturing with auto saving.\r\nIncredibly easier than ever beffore.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.LV);
            this.panelMain.Controls.Add(this.ss);
            this.panelMain.Controls.Add(this.ts);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(441, 123);
            this.panelMain.TabIndex = 12;
            // 
            // LV
            // 
            this.LV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LV.Location = new System.Drawing.Point(14, 43);
            this.LV.MultiSelect = false;
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(109, 37);
            this.LV.TabIndex = 12;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.View = System.Windows.Forms.View.Details;
            this.LV.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
            this.LV.DoubleClick += new System.EventHandler(this.LV_DoubleClick);
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbSettings,
            this.toolStripSeparator8,
            this.tsbtnNewHotKey,
            this.tsSeparatorBeforeStatus,
            this.tslab_Status});
            this.ss.Location = new System.Drawing.Point(0, 100);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(441, 23);
            this.ss.TabIndex = 13;
            this.ss.Text = "statusStrip1";
            // 
            // tsddbSettings
            // 
            this.tsddbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ShowAds,
            this.tsmi_Language,
            this.toolStripSeparator7,
            this.tsmi_Cursor,
            this.toolStripSeparator5,
            this.tsmi_Notification,
            this.tsmi_Sound,
            this.toolStripSeparator6,
            this.tsmi_ReName,
            this.tsmi_OverWrite,
            this.toolStripSeparator1,
            this.tsmi_BMP,
            this.tsmi_GIF,
            this.tsmi_JPEG,
            this.tsmi_PNG,
            this.tsmi_TIFF});
            this.tsddbSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsddbSettings.Image")));
            this.tsddbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbSettings.Name = "tsddbSettings";
            this.tsddbSettings.Size = new System.Drawing.Size(67, 21);
            this.tsddbSettings.Text = "Settings";
            // 
            // tsmi_ShowAds
            // 
            this.tsmi_ShowAds.CheckOnClick = true;
            this.tsmi_ShowAds.Name = "tsmi_ShowAds";
            this.tsmi_ShowAds.Size = new System.Drawing.Size(170, 22);
            this.tsmi_ShowAds.Text = "RUC80 welcome";
            // 
            // tsmi_Language
            // 
            this.tsmi_Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Lang_EN_US,
            this.tsmi_Lang_ZH_CN});
            this.tsmi_Language.Name = "tsmi_Language";
            this.tsmi_Language.Size = new System.Drawing.Size(170, 22);
            this.tsmi_Language.Text = "Language";
            // 
            // tsmi_Lang_EN_US
            // 
            this.tsmi_Lang_EN_US.CheckOnClick = true;
            this.tsmi_Lang_EN_US.Name = "tsmi_Lang_EN_US";
            this.tsmi_Lang_EN_US.Size = new System.Drawing.Size(152, 22);
            this.tsmi_Lang_EN_US.Text = "English";
            this.tsmi_Lang_EN_US.Click += new System.EventHandler(this.tsmiLanguagePack_Click);
            // 
            // tsmi_Lang_ZH_CN
            // 
            this.tsmi_Lang_ZH_CN.CheckOnClick = true;
            this.tsmi_Lang_ZH_CN.Name = "tsmi_Lang_ZH_CN";
            this.tsmi_Lang_ZH_CN.Size = new System.Drawing.Size(152, 22);
            this.tsmi_Lang_ZH_CN.Text = "简体中文";
            this.tsmi_Lang_ZH_CN.Click += new System.EventHandler(this.tsmiLanguagePack_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmi_Cursor
            // 
            this.tsmi_Cursor.CheckOnClick = true;
            this.tsmi_Cursor.Name = "tsmi_Cursor";
            this.tsmi_Cursor.Size = new System.Drawing.Size(170, 22);
            this.tsmi_Cursor.Text = "Cursor";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmi_Notification
            // 
            this.tsmi_Notification.CheckOnClick = true;
            this.tsmi_Notification.Name = "tsmi_Notification";
            this.tsmi_Notification.Size = new System.Drawing.Size(170, 22);
            this.tsmi_Notification.Text = "Notification";
            // 
            // tsmi_Sound
            // 
            this.tsmi_Sound.CheckOnClick = true;
            this.tsmi_Sound.Name = "tsmi_Sound";
            this.tsmi_Sound.Size = new System.Drawing.Size(170, 22);
            this.tsmi_Sound.Text = "Sound";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmi_ReName
            // 
            this.tsmi_ReName.CheckOnClick = true;
            this.tsmi_ReName.Name = "tsmi_ReName";
            this.tsmi_ReName.Size = new System.Drawing.Size(170, 22);
            this.tsmi_ReName.Text = "Rename";
            this.tsmi_ReName.Click += new System.EventHandler(this.tsmiReName_Click);
            // 
            // tsmi_OverWrite
            // 
            this.tsmi_OverWrite.CheckOnClick = true;
            this.tsmi_OverWrite.Name = "tsmi_OverWrite";
            this.tsmi_OverWrite.Size = new System.Drawing.Size(170, 22);
            this.tsmi_OverWrite.Text = "Overwrite";
            this.tsmi_OverWrite.Click += new System.EventHandler(this.tsmiOverWrite_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmi_BMP
            // 
            this.tsmi_BMP.CheckOnClick = true;
            this.tsmi_BMP.Name = "tsmi_BMP";
            this.tsmi_BMP.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.tsmi_BMP.Size = new System.Drawing.Size(170, 22);
            this.tsmi_BMP.Text = "BMP";
            this.tsmi_BMP.Click += new System.EventHandler(this.settingsImageFormat_Clicked);
            // 
            // tsmi_GIF
            // 
            this.tsmi_GIF.CheckOnClick = true;
            this.tsmi_GIF.Name = "tsmi_GIF";
            this.tsmi_GIF.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.tsmi_GIF.Size = new System.Drawing.Size(170, 22);
            this.tsmi_GIF.Text = "GIF";
            this.tsmi_GIF.Click += new System.EventHandler(this.settingsImageFormat_Clicked);
            // 
            // tsmi_JPEG
            // 
            this.tsmi_JPEG.CheckOnClick = true;
            this.tsmi_JPEG.Name = "tsmi_JPEG";
            this.tsmi_JPEG.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.tsmi_JPEG.Size = new System.Drawing.Size(170, 22);
            this.tsmi_JPEG.Text = "JPEG";
            this.tsmi_JPEG.Click += new System.EventHandler(this.settingsImageFormat_Clicked);
            // 
            // tsmi_PNG
            // 
            this.tsmi_PNG.CheckOnClick = true;
            this.tsmi_PNG.Name = "tsmi_PNG";
            this.tsmi_PNG.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.tsmi_PNG.Size = new System.Drawing.Size(170, 22);
            this.tsmi_PNG.Text = "PNG";
            this.tsmi_PNG.Click += new System.EventHandler(this.settingsImageFormat_Clicked);
            // 
            // tsmi_TIFF
            // 
            this.tsmi_TIFF.CheckOnClick = true;
            this.tsmi_TIFF.Name = "tsmi_TIFF";
            this.tsmi_TIFF.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.tsmi_TIFF.Size = new System.Drawing.Size(170, 22);
            this.tsmi_TIFF.Text = "TIFF";
            this.tsmi_TIFF.Click += new System.EventHandler(this.settingsImageFormat_Clicked);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbtnNewHotKey
            // 
            this.tsbtnNewHotKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnNewHotKey.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNewHotKey.Image")));
            this.tsbtnNewHotKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNewHotKey.Name = "tsbtnNewHotKey";
            this.tsbtnNewHotKey.Size = new System.Drawing.Size(54, 21);
            this.tsbtnNewHotKey.Text = "HotKey";
            this.tsbtnNewHotKey.ToolTipText = "Click here to customize Hotkey";
            this.tsbtnNewHotKey.Click += new System.EventHandler(this.tsbtnNewHotKey_Click);
            // 
            // tsSeparatorBeforeStatus
            // 
            this.tsSeparatorBeforeStatus.Name = "tsSeparatorBeforeStatus";
            this.tsSeparatorBeforeStatus.Size = new System.Drawing.Size(6, 23);
            // 
            // tslab_Status
            // 
            this.tslab_Status.Name = "tslab_Status";
            this.tslab_Status.Size = new System.Drawing.Size(47, 18);
            this.tslab_Status.Text = "Ready.";
            // 
            // ts
            // 
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFolder,
            this.tstbNamePattern,
            this.tsbtnInsertVariable,
            this.tslImageFormat,
            this.tsddbMainMenu,
            this.tsSeparatorOfNumber,
            this.tslNumber,
            this.tstbNumber});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(441, 25);
            this.ts.TabIndex = 11;
            this.ts.Text = "toolStrip1";
            // 
            // tsbtnFolder
            // 
            this.tsbtnFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFolder.Image")));
            this.tsbtnFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFolder.Name = "tsbtnFolder";
            this.tsbtnFolder.Size = new System.Drawing.Size(49, 22);
            this.tsbtnFolder.Text = "Folder";
            this.tsbtnFolder.ToolTipText = "Save images to this folder";
            this.tsbtnFolder.Click += new System.EventHandler(this.tsbtnFolder_Click);
            // 
            // tstbNamePattern
            // 
            this.tstbNamePattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstbNamePattern.Name = "tstbNamePattern";
            this.tstbNamePattern.Size = new System.Drawing.Size(200, 25);
            this.tstbNamePattern.ToolTipText = "File name prefix";
            this.tstbNamePattern.TextChanged += new System.EventHandler(this.tstbPrefix_TextChanged);
            // 
            // tsbtnInsertVariable
            // 
            this.tsbtnInsertVariable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnInsertVariable.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInsertVariable.Image")));
            this.tsbtnInsertVariable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInsertVariable.Name = "tsbtnInsertVariable";
            this.tsbtnInsertVariable.Size = new System.Drawing.Size(13, 22);
            // 
            // tslImageFormat
            // 
            this.tslImageFormat.Name = "tslImageFormat";
            this.tslImageFormat.Size = new System.Drawing.Size(32, 22);
            this.tslImageFormat.Text = ".JPG";
            // 
            // tsddbMainMenu
            // 
            this.tsddbMainMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsddbMainMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenFolder,
            this.toolStripSeparator9,
            this.tsmi_ClearHistory,
            this.toolStripSeparator3,
            this.tsmiHelp,
            this.tsmiAbout,
            this.toolStripSeparator2,
            this.tsmiExit,
            this.MenuItemTest});
            this.tsddbMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsddbMainMenu.Image")));
            this.tsddbMainMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbMainMenu.Name = "tsddbMainMenu";
            this.tsddbMainMenu.Size = new System.Drawing.Size(54, 22);
            this.tsddbMainMenu.Text = "Menu";
            // 
            // tsmiOpenFolder
            // 
            this.tsmiOpenFolder.Name = "tsmiOpenFolder";
            this.tsmiOpenFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpenFolder.Size = new System.Drawing.Size(211, 22);
            this.tsmiOpenFolder.Text = "Open folder(&D)";
            this.tsmiOpenFolder.Click += new System.EventHandler(this.tsmiOpenFolder_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(208, 6);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(211, 22);
            this.tsmiHelp.Text = "Help(&H)";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(211, 22);
            this.tsmiAbout.Text = "About(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeyDisplayString = "";
            this.tsmiExit.Size = new System.Drawing.Size(211, 22);
            this.tsmiExit.Text = "Exit(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // MenuItemTest
            // 
            this.MenuItemTest.Name = "MenuItemTest";
            this.MenuItemTest.Size = new System.Drawing.Size(211, 22);
            this.MenuItemTest.Text = "(Debug: test)";
            this.MenuItemTest.Visible = false;
            this.MenuItemTest.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // tsSeparatorOfNumber
            // 
            this.tsSeparatorOfNumber.Name = "tsSeparatorOfNumber";
            this.tsSeparatorOfNumber.Size = new System.Drawing.Size(6, 25);
            // 
            // tslNumber
            // 
            this.tslNumber.Name = "tslNumber";
            this.tslNumber.Size = new System.Drawing.Size(16, 22);
            this.tslNumber.Text = "#";
            // 
            // tstbNumber
            // 
            this.tstbNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstbNumber.Name = "tstbNumber";
            this.tstbNumber.Size = new System.Drawing.Size(40, 25);
            this.tstbNumber.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstbNumber.ToolTipText = "File name next number";
            this.tstbNumber.TextChanged += new System.EventHandler(this.tstbNumber_TextChanged);
            // 
            // panelRUC80
            // 
            this.panelRUC80.BackColor = System.Drawing.Color.White;
            this.panelRUC80.Controls.Add(this.picRUC80);
            this.panelRUC80.Location = new System.Drawing.Point(12, 141);
            this.panelRUC80.Name = "panelRUC80";
            this.panelRUC80.Size = new System.Drawing.Size(159, 94);
            this.panelRUC80.TabIndex = 13;
            this.panelRUC80.Click += new System.EventHandler(this.RUC80_Click);
            // 
            // picRUC80
            // 
            this.picRUC80.Image = ((System.Drawing.Image)(resources.GetObject("picRUC80.Image")));
            this.picRUC80.Location = new System.Drawing.Point(14, 3);
            this.picRUC80.Name = "picRUC80";
            this.picRUC80.Size = new System.Drawing.Size(174, 271);
            this.picRUC80.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRUC80.TabIndex = 0;
            this.picRUC80.TabStop = false;
            this.picRUC80.Click += new System.EventHandler(this.RUC80_Click);
            // 
            // panelHelp
            // 
            this.panelHelp.Controls.Add(this.webHelp);
            this.panelHelp.Controls.Add(this.tsHelp);
            this.panelHelp.Location = new System.Drawing.Point(12, 249);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(200, 100);
            this.panelHelp.TabIndex = 14;
            // 
            // tsHelp
            // 
            this.tsHelp.BackColor = System.Drawing.Color.White;
            this.tsHelp.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsHelp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsReturnToMainPanel});
            this.tsHelp.Location = new System.Drawing.Point(0, 0);
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsHelp.Size = new System.Drawing.Size(25, 100);
            this.tsHelp.TabIndex = 1;
            this.tsHelp.Text = "toolStrip1";
            // 
            // tsReturnToMainPanel
            // 
            this.tsReturnToMainPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsReturnToMainPanel.Image = ((System.Drawing.Image)(resources.GetObject("tsReturnToMainPanel.Image")));
            this.tsReturnToMainPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReturnToMainPanel.Name = "tsReturnToMainPanel";
            this.tsReturnToMainPanel.Size = new System.Drawing.Size(22, 21);
            this.tsReturnToMainPanel.Text = "←";
            this.tsReturnToMainPanel.ToolTipText = "Return";
            this.tsReturnToMainPanel.Click += new System.EventHandler(this.tsReturnToMainPanel_Click);
            // 
            // panelHotKey
            // 
            this.panelHotKey.BackColor = System.Drawing.SystemColors.Control;
            this.panelHotKey.Controls.Add(this.lab_NewHotKey);
            this.panelHotKey.Location = new System.Drawing.Point(218, 153);
            this.panelHotKey.Name = "panelHotKey";
            this.panelHotKey.Size = new System.Drawing.Size(119, 193);
            this.panelHotKey.TabIndex = 15;
            this.panelHotKey.Click += new System.EventHandler(this.panelHotKey_Click);
            // 
            // lab_NewHotKey
            // 
            this.lab_NewHotKey.AutoSize = true;
            this.lab_NewHotKey.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_NewHotKey.Location = new System.Drawing.Point(50, 82);
            this.lab_NewHotKey.Name = "lab_NewHotKey";
            this.lab_NewHotKey.Size = new System.Drawing.Size(223, 38);
            this.lab_NewHotKey.TabIndex = 0;
            this.lab_NewHotKey.Text = "labNewHotKey";
            this.lab_NewHotKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_NewHotKey.Click += new System.EventHandler(this.panelHotKey_Click);
            // 
            // webHelp
            // 
            this.webHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webHelp.IsWebBrowserContextMenuEnabled = false;
            this.webHelp.Location = new System.Drawing.Point(25, 0);
            this.webHelp.MinimumSize = new System.Drawing.Size(20, 20);
            this.webHelp.Name = "webHelp";
            this.webHelp.ScriptErrorsSuppressed = true;
            this.webHelp.Size = new System.Drawing.Size(175, 100);
            this.webHelp.TabIndex = 0;
            this.webHelp.WebBrowserShortcutsEnabled = false;
            // 
            // tsmi_ClearHistory
            // 
            this.tsmi_ClearHistory.Name = "tsmi_ClearHistory";
            this.tsmi_ClearHistory.Size = new System.Drawing.Size(211, 22);
            this.tsmi_ClearHistory.Text = "Clear history(&C)";
            this.tsmi_ClearHistory.Click += new System.EventHandler(this.tsmi_ClearHistory_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(208, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHotKey);
            this.Controls.Add(this.panelHelp);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.panelRUC80);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapCap";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.CMS.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.panelInnerAbout.ResumeLayout(false);
            this.panelInnerAbout.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.panelRUC80.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRUC80)).EndInit();
            this.panelHelp.ResumeLayout(false);
            this.panelHelp.PerformLayout();
            this.tsHelp.ResumeLayout(false);
            this.tsHelp.PerformLayout();
            this.panelHotKey.ResumeLayout(false);
            this.panelHotKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.NotifyIcon NOTI;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem cmsmiOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem cmsmiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Panel panelInnerAbout;
        private System.Windows.Forms.Button btnCloseAboutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripTextBox tstbNamePattern;
        private System.Windows.Forms.ToolStripTextBox tstbNumber;
        private System.Windows.Forms.ToolStripLabel tslImageFormat;
        private System.Windows.Forms.ToolStripButton tsbtnFolder;
        private System.Windows.Forms.ToolStripDropDownButton tsddbMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel tslab_Status;
        private System.Windows.Forms.LinkLabel lnkWeibo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTest;
        private System.Windows.Forms.ToolStripDropDownButton tsddbSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Cursor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Sound;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Notification;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorBeforeStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_BMP;
        private System.Windows.Forms.ToolStripMenuItem tsmi_GIF;
        private System.Windows.Forms.ToolStripMenuItem tsmi_JPEG;
        private System.Windows.Forms.ToolStripMenuItem tsmi_PNG;
        private System.Windows.Forms.ToolStripMenuItem tsmi_TIFF;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorOfNumber;
        private System.Windows.Forms.ToolStripLabel tslNumber;
        private System.Windows.Forms.Panel panelRUC80;
        private System.Windows.Forms.PictureBox picRUC80;
        private System.Windows.Forms.Label lnkRUC80;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.WebBrowser webHelp;
        private System.Windows.Forms.ToolStrip tsHelp;
        private System.Windows.Forms.ToolStripButton tsReturnToMainPanel;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Panel panelHotKey;
        private System.Windows.Forms.Label lab_NewHotKey;
        private System.Windows.Forms.ToolStripButton tsbtnNewHotKey;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ShowAds;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnInsertVariable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ReName;
        private System.Windows.Forms.ToolStripMenuItem tsmi_OverWrite;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Language;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Lang_EN_US;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Lang_ZH_CN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ClearHistory;
    }
}

