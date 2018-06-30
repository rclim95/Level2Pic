namespace Level2Pic
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menustripMain = new System.Windows.Forms.MenuStrip();
            this.toolstripmenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripmenuSaveMap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripmenuLevelProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripmenuStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripmenuErrors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuStorageFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuRender = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuStopRender = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripmenuManageGraphics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripmenuPlaySMF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuPlayLevels = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripmenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.splitcontainerMain = new System.Windows.Forms.SplitContainer();
            this.panelPropertyDocker = new System.Windows.Forms.Panel();
            this.propertygridMap = new System.Windows.Forms.PropertyGrid();
            this.comboboxAreas = new System.Windows.Forms.ComboBox();
            this.separatorProperties = new CDBurnerXP.Controls.Separator();
            this.separatorAreas = new CDBurnerXP.Controls.Separator();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.pictureboxMain = new System.Windows.Forms.PictureBox();
            this.toolstripStandard = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripbuttonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolstripbuttonSave = new System.Windows.Forms.ToolStripButton();
            this.toolstripbuttonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripbuttonProperties = new System.Windows.Forms.ToolStripButton();
            this.toolstripbuttonErrors = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripbuttonRender = new System.Windows.Forms.ToolStripButton();
            this.menustripMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.splitcontainerMain.Panel1.SuspendLayout();
            this.splitcontainerMain.Panel2.SuspendLayout();
            this.splitcontainerMain.SuspendLayout();
            this.panelPropertyDocker.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMain)).BeginInit();
            this.toolstripStandard.SuspendLayout();
            this.SuspendLayout();
            // 
            // menustripMain
            // 
            this.menustripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menustripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripmenuFile,
            this.viewToolStripMenuItem,
            this.toolstripmenuTools,
            this.toolstripmenuHelp});
            this.menustripMain.Location = new System.Drawing.Point(0, 0);
            this.menustripMain.Name = "menustripMain";
            this.menustripMain.Size = new System.Drawing.Size(792, 24);
            this.menustripMain.TabIndex = 0;
            this.menustripMain.Text = "menuStrip1";
            // 
            // toolstripmenuFile
            // 
            this.toolstripmenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripmenuLoad,
            this.toolStripSeparator1,
            this.toolstripmenuSaveMap,
            this.toolstripmenuCopy,
            this.toolStripSeparator2,
            this.toolstripmenuLevelProperties,
            this.toolstripmenuExit});
            this.toolstripmenuFile.Name = "toolstripmenuFile";
            this.toolstripmenuFile.Size = new System.Drawing.Size(37, 20);
            this.toolstripmenuFile.Text = "&File";
            // 
            // toolstripmenuLoad
            // 
            this.toolstripmenuLoad.Image = global::Level2Pic.Properties.Resources.Load;
            this.toolstripmenuLoad.Name = "toolstripmenuLoad";
            this.toolstripmenuLoad.Size = new System.Drawing.Size(198, 22);
            this.toolstripmenuLoad.Text = "&Load Level Code";
            this.toolstripmenuLoad.Click += new System.EventHandler(this.toolstripmenuLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // toolstripmenuSaveMap
            // 
            this.toolstripmenuSaveMap.Enabled = false;
            this.toolstripmenuSaveMap.Image = global::Level2Pic.Properties.Resources.Save;
            this.toolstripmenuSaveMap.Name = "toolstripmenuSaveMap";
            this.toolstripmenuSaveMap.Size = new System.Drawing.Size(198, 22);
            this.toolstripmenuSaveMap.Text = "&Save Map As...";
            // 
            // toolstripmenuCopy
            // 
            this.toolstripmenuCopy.Enabled = false;
            this.toolstripmenuCopy.Image = global::Level2Pic.Properties.Resources.Copy;
            this.toolstripmenuCopy.Name = "toolstripmenuCopy";
            this.toolstripmenuCopy.Size = new System.Drawing.Size(198, 22);
            this.toolstripmenuCopy.Text = "&Copy Map to Clipboard";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // toolstripmenuLevelProperties
            // 
            this.toolstripmenuLevelProperties.Enabled = false;
            this.toolstripmenuLevelProperties.Image = ((System.Drawing.Image)(resources.GetObject("toolstripmenuLevelProperties.Image")));
            this.toolstripmenuLevelProperties.Name = "toolstripmenuLevelProperties";
            this.toolstripmenuLevelProperties.Size = new System.Drawing.Size(198, 22);
            this.toolstripmenuLevelProperties.Text = "Level &Properties";
            this.toolstripmenuLevelProperties.Click += new System.EventHandler(this.toolstripmenuLevelProperties_Click);
            // 
            // toolstripmenuExit
            // 
            this.toolstripmenuExit.Name = "toolstripmenuExit";
            this.toolstripmenuExit.Size = new System.Drawing.Size(198, 22);
            this.toolstripmenuExit.Text = "&Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripmenuStandard,
            this.toolstripmenuProperty,
            this.toolStripSeparator4,
            this.toolstripmenuStatusBar,
            this.toolStripSeparator3,
            this.toolstripmenuErrors,
            this.toolstripmenuStorageFolder});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // toolstripmenuStandard
            // 
            this.toolstripmenuStandard.Checked = true;
            this.toolstripmenuStandard.CheckOnClick = true;
            this.toolstripmenuStandard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolstripmenuStandard.Name = "toolstripmenuStandard";
            this.toolstripmenuStandard.Size = new System.Drawing.Size(175, 22);
            this.toolstripmenuStandard.Text = "&Standard Toolbar";
            this.toolstripmenuStandard.Click += new System.EventHandler(this.toolstripmenuStandard_Click);
            // 
            // toolstripmenuProperty
            // 
            this.toolstripmenuProperty.Checked = true;
            this.toolstripmenuProperty.CheckOnClick = true;
            this.toolstripmenuProperty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolstripmenuProperty.Image = global::Level2Pic.Properties.Resources.Property;
            this.toolstripmenuProperty.Name = "toolstripmenuProperty";
            this.toolstripmenuProperty.Size = new System.Drawing.Size(175, 22);
            this.toolstripmenuProperty.Text = "&Property Panel";
            this.toolstripmenuProperty.Click += new System.EventHandler(this.toolstripmenuProperty_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(172, 6);
            // 
            // toolstripmenuStatusBar
            // 
            this.toolstripmenuStatusBar.Checked = true;
            this.toolstripmenuStatusBar.CheckOnClick = true;
            this.toolstripmenuStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolstripmenuStatusBar.Name = "toolstripmenuStatusBar";
            this.toolstripmenuStatusBar.Size = new System.Drawing.Size(175, 22);
            this.toolstripmenuStatusBar.Text = "Status &Bar";
            this.toolstripmenuStatusBar.Click += new System.EventHandler(this.toolstripmenuStatusBar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(172, 6);
            // 
            // toolstripmenuErrors
            // 
            this.toolstripmenuErrors.Enabled = false;
            this.toolstripmenuErrors.Image = ((System.Drawing.Image)(resources.GetObject("toolstripmenuErrors.Image")));
            this.toolstripmenuErrors.Name = "toolstripmenuErrors";
            this.toolstripmenuErrors.Size = new System.Drawing.Size(175, 22);
            this.toolstripmenuErrors.Text = "&Error and Warnings";
            this.toolstripmenuErrors.Click += new System.EventHandler(this.toolstripmenuErrors_Click);
            // 
            // toolstripmenuStorageFolder
            // 
            this.toolstripmenuStorageFolder.Name = "toolstripmenuStorageFolder";
            this.toolstripmenuStorageFolder.Size = new System.Drawing.Size(175, 22);
            this.toolstripmenuStorageFolder.Text = "Storage &Folder";
            // 
            // toolstripmenuTools
            // 
            this.toolstripmenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripmenuRender,
            this.toolstripmenuStopRender,
            this.toolStripSeparator5,
            this.toolstripmenuManageGraphics,
            this.toolstripmenuOptions});
            this.toolstripmenuTools.Name = "toolstripmenuTools";
            this.toolstripmenuTools.Size = new System.Drawing.Size(47, 20);
            this.toolstripmenuTools.Text = "&Tools";
            // 
            // toolstripmenuRender
            // 
            this.toolstripmenuRender.Enabled = false;
            this.toolstripmenuRender.Image = global::Level2Pic.Properties.Resources.Render;
            this.toolstripmenuRender.Name = "toolstripmenuRender";
            this.toolstripmenuRender.Size = new System.Drawing.Size(194, 22);
            this.toolstripmenuRender.Text = "&Render Level";
            this.toolstripmenuRender.Click += new System.EventHandler(this.toolstripmenuRender_Click);
            // 
            // toolstripmenuStopRender
            // 
            this.toolstripmenuStopRender.Enabled = false;
            this.toolstripmenuStopRender.Image = global::Level2Pic.Properties.Resources.Stop;
            this.toolstripmenuStopRender.Name = "toolstripmenuStopRender";
            this.toolstripmenuStopRender.Size = new System.Drawing.Size(194, 22);
            this.toolstripmenuStopRender.Text = "&Stop Rendering Level...";
            this.toolstripmenuStopRender.Click += new System.EventHandler(this.toolstripmenuStopRender_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(191, 6);
            // 
            // toolstripmenuManageGraphics
            // 
            this.toolstripmenuManageGraphics.Image = ((System.Drawing.Image)(resources.GetObject("toolstripmenuManageGraphics.Image")));
            this.toolstripmenuManageGraphics.Name = "toolstripmenuManageGraphics";
            this.toolstripmenuManageGraphics.Size = new System.Drawing.Size(194, 22);
            this.toolstripmenuManageGraphics.Text = "&Manage Graphics";
            this.toolstripmenuManageGraphics.Click += new System.EventHandler(this.toolstripmenuManageGraphics_Click);
            // 
            // toolstripmenuOptions
            // 
            this.toolstripmenuOptions.Name = "toolstripmenuOptions";
            this.toolstripmenuOptions.Size = new System.Drawing.Size(194, 22);
            this.toolstripmenuOptions.Text = "&Options";
            this.toolstripmenuOptions.Click += new System.EventHandler(this.toolstripmenuOptions_Click);
            // 
            // toolstripmenuHelp
            // 
            this.toolstripmenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripmenuUpdates,
            this.toolStripSeparator6,
            this.toolstripmenuPlaySMF,
            this.toolstripmenuPlayLevels,
            this.toolStripSeparator7,
            this.toolstripmenuAbout});
            this.toolstripmenuHelp.Name = "toolstripmenuHelp";
            this.toolstripmenuHelp.Size = new System.Drawing.Size(44, 20);
            this.toolstripmenuHelp.Text = "&Help";
            // 
            // toolstripmenuUpdates
            // 
            this.toolstripmenuUpdates.Image = ((System.Drawing.Image)(resources.GetObject("toolstripmenuUpdates.Image")));
            this.toolstripmenuUpdates.Name = "toolstripmenuUpdates";
            this.toolstripmenuUpdates.Size = new System.Drawing.Size(193, 22);
            this.toolstripmenuUpdates.Text = "&Check for Updates";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(190, 6);
            // 
            // toolstripmenuPlaySMF
            // 
            this.toolstripmenuPlaySMF.Name = "toolstripmenuPlaySMF";
            this.toolstripmenuPlaySMF.Size = new System.Drawing.Size(193, 22);
            this.toolstripmenuPlaySMF.Text = "&Play Super Mario Flash";
            // 
            // toolstripmenuPlayLevels
            // 
            this.toolstripmenuPlayLevels.Name = "toolstripmenuPlayLevels";
            this.toolstripmenuPlayLevels.Size = new System.Drawing.Size(193, 22);
            this.toolstripmenuPlayLevels.Text = "Play User-Made &Levels";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(190, 6);
            // 
            // toolstripmenuAbout
            // 
            this.toolstripmenuAbout.Image = global::Level2Pic.Properties.Resources.Information;
            this.toolstripmenuAbout.Name = "toolstripmenuAbout";
            this.toolstripmenuAbout.Size = new System.Drawing.Size(193, 22);
            this.toolstripmenuAbout.Text = "&About Level2Pic";
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus,
            this.progressbarStatus});
            this.statusMain.Location = new System.Drawing.Point(0, 544);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(792, 22);
            this.statusMain.TabIndex = 1;
            this.statusMain.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(777, 17);
            this.labelStatus.Spring = true;
            this.labelStatus.Text = "Ready";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressbarStatus
            // 
            this.progressbarStatus.Name = "progressbarStatus";
            this.progressbarStatus.Size = new System.Drawing.Size(109, 17);
            this.progressbarStatus.Visible = false;
            // 
            // splitcontainerMain
            // 
            this.splitcontainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitcontainerMain.Location = new System.Drawing.Point(0, 49);
            this.splitcontainerMain.Name = "splitcontainerMain";
            // 
            // splitcontainerMain.Panel1
            // 
            this.splitcontainerMain.Panel1.Controls.Add(this.panelPropertyDocker);
            this.splitcontainerMain.Panel1.Controls.Add(this.comboboxAreas);
            this.splitcontainerMain.Panel1.Controls.Add(this.separatorProperties);
            this.splitcontainerMain.Panel1.Controls.Add(this.separatorAreas);
            this.splitcontainerMain.Panel1.Enabled = false;
            this.splitcontainerMain.Panel1MinSize = 0;
            // 
            // splitcontainerMain.Panel2
            // 
            this.splitcontainerMain.Panel2.Controls.Add(this.panelPicture);
            this.splitcontainerMain.Size = new System.Drawing.Size(792, 495);
            this.splitcontainerMain.SplitterDistance = 263;
            this.splitcontainerMain.TabIndex = 2;
            // 
            // panelPropertyDocker
            // 
            this.panelPropertyDocker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPropertyDocker.Controls.Add(this.propertygridMap);
            this.panelPropertyDocker.Location = new System.Drawing.Point(4, 75);
            this.panelPropertyDocker.Name = "panelPropertyDocker";
            this.panelPropertyDocker.Size = new System.Drawing.Size(256, 417);
            this.panelPropertyDocker.TabIndex = 2;
            // 
            // propertygridMap
            // 
            this.propertygridMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertygridMap.Location = new System.Drawing.Point(0, 0);
            this.propertygridMap.Name = "propertygridMap";
            this.propertygridMap.Size = new System.Drawing.Size(256, 417);
            this.propertygridMap.TabIndex = 3;
            // 
            // comboboxAreas
            // 
            this.comboboxAreas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxAreas.FormattingEnabled = true;
            this.comboboxAreas.Items.AddRange(new object[] {
            "Main Zone and Bonus Room",
            "Main Zone Only",
            "Bonus Room Only"});
            this.comboboxAreas.Location = new System.Drawing.Point(4, 25);
            this.comboboxAreas.Name = "comboboxAreas";
            this.comboboxAreas.Size = new System.Drawing.Size(256, 21);
            this.comboboxAreas.TabIndex = 1;
            this.comboboxAreas.SelectedIndexChanged += new System.EventHandler(this.comboboxAreas_SelectedIndexChanged);
            // 
            // separatorProperties
            // 
            this.separatorProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorProperties.ForeColor = System.Drawing.SystemColors.ControlText;
            this.separatorProperties.Location = new System.Drawing.Point(1, 59);
            this.separatorProperties.Name = "separatorProperties";
            this.separatorProperties.Size = new System.Drawing.Size(259, 12);
            this.separatorProperties.TabIndex = 0;
            this.separatorProperties.Text = "Properties";
            this.separatorProperties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // separatorAreas
            // 
            this.separatorAreas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorAreas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.separatorAreas.Location = new System.Drawing.Point(1, 7);
            this.separatorAreas.Name = "separatorAreas";
            this.separatorAreas.Size = new System.Drawing.Size(259, 15);
            this.separatorAreas.TabIndex = 0;
            this.separatorAreas.Text = "Make Map Using...";
            this.separatorAreas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelPicture
            // 
            this.panelPicture.AutoScroll = true;
            this.panelPicture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPicture.Controls.Add(this.pictureboxMain);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(525, 495);
            this.panelPicture.TabIndex = 0;
            this.panelPicture.SizeChanged += new System.EventHandler(this.panelPicture_SizeChanged);
            // 
            // pictureboxMain
            // 
            this.pictureboxMain.Location = new System.Drawing.Point(-2, 128);
            this.pictureboxMain.Name = "pictureboxMain";
            this.pictureboxMain.Size = new System.Drawing.Size(100, 140);
            this.pictureboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureboxMain.TabIndex = 0;
            this.pictureboxMain.TabStop = false;
            this.pictureboxMain.SizeChanged += new System.EventHandler(this.pictureboxMain_SizeChanged);
            // 
            // toolstripStandard
            // 
            this.toolstripStandard.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripStandard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.toolstripbuttonLoad,
            this.toolstripbuttonSave,
            this.toolstripbuttonCopy,
            this.toolStripSeparator9,
            this.toolstripbuttonProperties,
            this.toolstripbuttonErrors,
            this.toolStripSeparator10,
            this.toolstripbuttonRender});
            this.toolstripStandard.Location = new System.Drawing.Point(0, 24);
            this.toolstripStandard.Name = "toolstripStandard";
            this.toolstripStandard.Size = new System.Drawing.Size(792, 25);
            this.toolstripStandard.TabIndex = 3;
            this.toolstripStandard.Text = "Standard";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolstripbuttonLoad
            // 
            this.toolstripbuttonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripbuttonLoad.Image = global::Level2Pic.Properties.Resources.Load;
            this.toolstripbuttonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripbuttonLoad.Name = "toolstripbuttonLoad";
            this.toolstripbuttonLoad.Size = new System.Drawing.Size(23, 22);
            this.toolstripbuttonLoad.Text = "&Load";
            this.toolstripbuttonLoad.Click += new System.EventHandler(this.toolstripmenuLoad_Click);
            // 
            // toolstripbuttonSave
            // 
            this.toolstripbuttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripbuttonSave.Enabled = false;
            this.toolstripbuttonSave.Image = global::Level2Pic.Properties.Resources.Save;
            this.toolstripbuttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripbuttonSave.Name = "toolstripbuttonSave";
            this.toolstripbuttonSave.Size = new System.Drawing.Size(23, 22);
            this.toolstripbuttonSave.Text = "&Save Map As...";
            // 
            // toolstripbuttonCopy
            // 
            this.toolstripbuttonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripbuttonCopy.Enabled = false;
            this.toolstripbuttonCopy.Image = global::Level2Pic.Properties.Resources.Copy;
            this.toolstripbuttonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripbuttonCopy.Name = "toolstripbuttonCopy";
            this.toolstripbuttonCopy.Size = new System.Drawing.Size(23, 22);
            this.toolstripbuttonCopy.Text = "&Copy to Clipboard";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolstripbuttonProperties
            // 
            this.toolstripbuttonProperties.Enabled = false;
            this.toolstripbuttonProperties.Image = ((System.Drawing.Image)(resources.GetObject("toolstripbuttonProperties.Image")));
            this.toolstripbuttonProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripbuttonProperties.Name = "toolstripbuttonProperties";
            this.toolstripbuttonProperties.Size = new System.Drawing.Size(80, 22);
            this.toolstripbuttonProperties.Text = "&Properties";
            this.toolstripbuttonProperties.Click += new System.EventHandler(this.toolstripmenuLevelProperties_Click);
            // 
            // toolstripbuttonErrors
            // 
            this.toolstripbuttonErrors.Enabled = false;
            this.toolstripbuttonErrors.Image = ((System.Drawing.Image)(resources.GetObject("toolstripbuttonErrors.Image")));
            this.toolstripbuttonErrors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripbuttonErrors.Name = "toolstripbuttonErrors";
            this.toolstripbuttonErrors.Size = new System.Drawing.Size(90, 22);
            this.toolstripbuttonErrors.Text = "&Error List (0)";
            this.toolstripbuttonErrors.Click += new System.EventHandler(this.toolstripmenuErrors_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolstripbuttonRender
            // 
            this.toolstripbuttonRender.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripbuttonRender.Enabled = false;
            this.toolstripbuttonRender.Image = global::Level2Pic.Properties.Resources.Render;
            this.toolstripbuttonRender.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripbuttonRender.Name = "toolstripbuttonRender";
            this.toolstripbuttonRender.Size = new System.Drawing.Size(23, 22);
            this.toolstripbuttonRender.Text = "&Render Level";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.splitcontainerMain);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.toolstripStandard);
            this.Controls.Add(this.menustripMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menustripMain;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Main";
            this.Text = "Level2Pic v{0}";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menustripMain.ResumeLayout(false);
            this.menustripMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.splitcontainerMain.Panel1.ResumeLayout(false);
            this.splitcontainerMain.Panel2.ResumeLayout(false);
            this.splitcontainerMain.ResumeLayout(false);
            this.panelPropertyDocker.ResumeLayout(false);
            this.panelPicture.ResumeLayout(false);
            this.panelPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMain)).EndInit();
            this.toolstripStandard.ResumeLayout(false);
            this.toolstripStandard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menustripMain;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuSaveMap;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuLevelProperties;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuExit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuStandard;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuProperty;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuStatusBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuErrors;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuStorageFolder;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuTools;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuRender;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuStopRender;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuManageGraphics;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuHelp;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuUpdates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuPlaySMF;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuPlayLevels;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuAbout;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ToolStripProgressBar progressbarStatus;
        private System.Windows.Forms.SplitContainer splitcontainerMain;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pictureboxMain;
        private System.Windows.Forms.ToolStrip toolstripStandard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolstripbuttonLoad;
        private System.Windows.Forms.ToolStripButton toolstripbuttonSave;
        private System.Windows.Forms.ToolStripButton toolstripbuttonCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolstripbuttonProperties;
        private System.Windows.Forms.ToolStripButton toolstripbuttonErrors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton toolstripbuttonRender;
        private System.Windows.Forms.ComboBox comboboxAreas;
        private CDBurnerXP.Controls.Separator separatorProperties;
        private CDBurnerXP.Controls.Separator separatorAreas;
        private System.Windows.Forms.Panel panelPropertyDocker;
        private System.Windows.Forms.PropertyGrid propertygridMap;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuOptions;
    }
}