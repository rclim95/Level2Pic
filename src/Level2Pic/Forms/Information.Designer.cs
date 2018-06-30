namespace Level2Pic.Forms
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.tabcontrolMain = new System.Windows.Forms.TabControl();
            this.tabpageLevel = new System.Windows.Forms.TabPage();
            this.groupboxBonus = new System.Windows.Forms.GroupBox();
            this.labelBonusLength = new System.Windows.Forms.Label();
            this.labelBonusPixel = new System.Windows.Forms.Label();
            this.numericBonusLength = new System.Windows.Forms.NumericUpDown();
            this.comboboxBonusMusic = new System.Windows.Forms.ComboBox();
            this.comboboxBonusBackground = new System.Windows.Forms.ComboBox();
            this.labelBonusMusic = new System.Windows.Forms.Label();
            this.labelBonusBackground = new System.Windows.Forms.Label();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.labelMainLength = new System.Windows.Forms.Label();
            this.labelMainPixel = new System.Windows.Forms.Label();
            this.numericMainLength = new System.Windows.Forms.NumericUpDown();
            this.comboboxMainMusic = new System.Windows.Forms.ComboBox();
            this.comboboxMainBackground = new System.Windows.Forms.ComboBox();
            this.labelMainMusic = new System.Windows.Forms.Label();
            this.labelMainBackground = new System.Windows.Forms.Label();
            this.groupboxGeneral = new System.Windows.Forms.GroupBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMessageLevel = new System.Windows.Forms.Label();
            this.labelHeaderLevel = new System.Windows.Forms.Label();
            this.tabpageInternet = new System.Windows.Forms.TabPage();
            this.groupboxDescription = new System.Windows.Forms.GroupBox();
            this.textboxDescription = new System.Windows.Forms.TextBox();
            this.groupboxCommunity = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelViewsValue = new System.Windows.Forms.Label();
            this.labelVotesValue = new System.Windows.Forms.Label();
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.labelAverageRatingValue = new System.Windows.Forms.Label();
            this.labelAverageRating = new System.Windows.Forms.Label();
            this.labelVotes = new System.Windows.Forms.Label();
            this.labelViews = new System.Windows.Forms.Label();
            this.groupboxOnlineGeneral = new System.Windows.Forms.GroupBox();
            this.labelDatePublishedValue = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.linkOnlineNameValue = new System.Windows.Forms.LinkLabel();
            this.linkAuthorValue = new System.Windows.Forms.LinkLabel();
            this.labelOnlineName = new System.Windows.Forms.Label();
            this.labelHeaderInternet = new System.Windows.Forms.Label();
            this.tabpageCode = new System.Windows.Forms.TabPage();
            this.groupboxLevel = new System.Windows.Forms.GroupBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.textboxLevelCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.groupboxStatistics = new System.Windows.Forms.GroupBox();
            this.listviewCount = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPercentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelStats = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.backgroundworkerCode = new System.ComponentModel.BackgroundWorker();
            this.tabcontrolMain.SuspendLayout();
            this.tabpageLevel.SuspendLayout();
            this.groupboxBonus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBonusLength)).BeginInit();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMainLength)).BeginInit();
            this.groupboxGeneral.SuspendLayout();
            this.tabpageInternet.SuspendLayout();
            this.groupboxDescription.SuspendLayout();
            this.groupboxCommunity.SuspendLayout();
            this.groupboxOnlineGeneral.SuspendLayout();
            this.tabpageCode.SuspendLayout();
            this.groupboxLevel.SuspendLayout();
            this.groupboxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrolMain
            // 
            this.tabcontrolMain.Controls.Add(this.tabpageLevel);
            this.tabcontrolMain.Controls.Add(this.tabpageInternet);
            this.tabcontrolMain.Controls.Add(this.tabpageCode);
            this.tabcontrolMain.Location = new System.Drawing.Point(13, 13);
            this.tabcontrolMain.Name = "tabcontrolMain";
            this.tabcontrolMain.SelectedIndex = 0;
            this.tabcontrolMain.Size = new System.Drawing.Size(455, 425);
            this.tabcontrolMain.TabIndex = 0;
            this.tabcontrolMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabcontrolMain_Selected);
            // 
            // tabpageLevel
            // 
            this.tabpageLevel.Controls.Add(this.groupboxBonus);
            this.tabpageLevel.Controls.Add(this.groupBoxMain);
            this.tabpageLevel.Controls.Add(this.groupboxGeneral);
            this.tabpageLevel.Controls.Add(this.labelMessageLevel);
            this.tabpageLevel.Controls.Add(this.labelHeaderLevel);
            this.tabpageLevel.Location = new System.Drawing.Point(4, 22);
            this.tabpageLevel.Name = "tabpageLevel";
            this.tabpageLevel.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageLevel.Size = new System.Drawing.Size(447, 399);
            this.tabpageLevel.TabIndex = 0;
            this.tabpageLevel.Text = "Level";
            this.tabpageLevel.UseVisualStyleBackColor = true;
            // 
            // groupboxBonus
            // 
            this.groupboxBonus.Controls.Add(this.labelBonusLength);
            this.groupboxBonus.Controls.Add(this.labelBonusPixel);
            this.groupboxBonus.Controls.Add(this.numericBonusLength);
            this.groupboxBonus.Controls.Add(this.comboboxBonusMusic);
            this.groupboxBonus.Controls.Add(this.comboboxBonusBackground);
            this.groupboxBonus.Controls.Add(this.labelBonusMusic);
            this.groupboxBonus.Controls.Add(this.labelBonusBackground);
            this.groupboxBonus.Location = new System.Drawing.Point(10, 283);
            this.groupboxBonus.Name = "groupboxBonus";
            this.groupboxBonus.Size = new System.Drawing.Size(431, 107);
            this.groupboxBonus.TabIndex = 4;
            this.groupboxBonus.TabStop = false;
            this.groupboxBonus.Text = "Bonus Room";
            // 
            // labelBonusLength
            // 
            this.labelBonusLength.AutoSize = true;
            this.labelBonusLength.Location = new System.Drawing.Point(6, 77);
            this.labelBonusLength.Name = "labelBonusLength";
            this.labelBonusLength.Size = new System.Drawing.Size(78, 13);
            this.labelBonusLength.TabIndex = 4;
            this.labelBonusLength.Text = "Zone\'s Length:";
            // 
            // labelBonusPixel
            // 
            this.labelBonusPixel.AutoSize = true;
            this.labelBonusPixel.Location = new System.Drawing.Point(195, 77);
            this.labelBonusPixel.Name = "labelBonusPixel";
            this.labelBonusPixel.Size = new System.Drawing.Size(153, 13);
            this.labelBonusPixel.TabIndex = 6;
            this.labelBonusPixel.Text = "screen(s) wide ({0:N} pixel(s))";
            this.labelBonusPixel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericBonusLength
            // 
            this.numericBonusLength.Location = new System.Drawing.Point(100, 74);
            this.numericBonusLength.Maximum = new decimal(new int[] {
            4180,
            0,
            0,
            0});
            this.numericBonusLength.Name = "numericBonusLength";
            this.numericBonusLength.Size = new System.Drawing.Size(89, 21);
            this.numericBonusLength.TabIndex = 5;
            this.numericBonusLength.ThousandsSeparator = true;
            this.numericBonusLength.ValueChanged += new System.EventHandler(this.numericBonusLength_ValueChanged);
            // 
            // comboboxBonusMusic
            // 
            this.comboboxBonusMusic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxBonusMusic.FormattingEnabled = true;
            this.comboboxBonusMusic.Items.AddRange(new object[] {
            "None",
            "Super Mario Bros. - Overworld",
            "Super Mario World - Here We Go!",
            "Super Mario Bros. 3 - Athletics",
            "Super Mario Bros. 3 - World 1 Map",
            "Super Mario Bros. - Underground",
            "Super Mario World - Castle",
            "Super Mario Bros. - Bowser Battle",
            "Super Mario World - Map",
            "Super Mario Bros. - Starman Theme",
            "Super Mario Bros. - Course Cleared",
            "Super Mario Bros. - Castle Cleared"});
            this.comboboxBonusMusic.Location = new System.Drawing.Point(100, 47);
            this.comboboxBonusMusic.Name = "comboboxBonusMusic";
            this.comboboxBonusMusic.Size = new System.Drawing.Size(324, 21);
            this.comboboxBonusMusic.TabIndex = 3;
            this.comboboxBonusMusic.SelectedValueChanged += new System.EventHandler(this.comboboxBonusMusic_SelectedIndexChanged);
            // 
            // comboboxBonusBackground
            // 
            this.comboboxBonusBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxBonusBackground.FormattingEnabled = true;
            this.comboboxBonusBackground.Items.AddRange(new object[] {
            "Clouds",
            "Cave",
            "Forest",
            "Castle",
            "Twilight",
            "Ghost House"});
            this.comboboxBonusBackground.Location = new System.Drawing.Point(100, 20);
            this.comboboxBonusBackground.Name = "comboboxBonusBackground";
            this.comboboxBonusBackground.Size = new System.Drawing.Size(324, 21);
            this.comboboxBonusBackground.TabIndex = 1;
            this.comboboxBonusBackground.SelectedIndexChanged += new System.EventHandler(this.comboboxBonusBackground_SelectedIndexChanged);
            // 
            // labelBonusMusic
            // 
            this.labelBonusMusic.AutoSize = true;
            this.labelBonusMusic.Location = new System.Drawing.Point(6, 50);
            this.labelBonusMusic.Name = "labelBonusMusic";
            this.labelBonusMusic.Size = new System.Drawing.Size(96, 13);
            this.labelBonusMusic.TabIndex = 2;
            this.labelBonusMusic.Text = "Background Music:";
            // 
            // labelBonusBackground
            // 
            this.labelBonusBackground.AutoSize = true;
            this.labelBonusBackground.Location = new System.Drawing.Point(6, 23);
            this.labelBonusBackground.Name = "labelBonusBackground";
            this.labelBonusBackground.Size = new System.Drawing.Size(67, 13);
            this.labelBonusBackground.TabIndex = 0;
            this.labelBonusBackground.Text = "Background:";
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.labelMainLength);
            this.groupBoxMain.Controls.Add(this.labelMainPixel);
            this.groupBoxMain.Controls.Add(this.numericMainLength);
            this.groupBoxMain.Controls.Add(this.comboboxMainMusic);
            this.groupBoxMain.Controls.Add(this.comboboxMainBackground);
            this.groupBoxMain.Controls.Add(this.labelMainMusic);
            this.groupBoxMain.Controls.Add(this.labelMainBackground);
            this.groupBoxMain.Location = new System.Drawing.Point(10, 170);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(431, 107);
            this.groupBoxMain.TabIndex = 3;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Main Zone";
            // 
            // labelMainLength
            // 
            this.labelMainLength.AutoSize = true;
            this.labelMainLength.Location = new System.Drawing.Point(5, 77);
            this.labelMainLength.Name = "labelMainLength";
            this.labelMainLength.Size = new System.Drawing.Size(78, 13);
            this.labelMainLength.TabIndex = 4;
            this.labelMainLength.Text = "Zone\'s Length:";
            // 
            // labelMainPixel
            // 
            this.labelMainPixel.AutoSize = true;
            this.labelMainPixel.Location = new System.Drawing.Point(195, 77);
            this.labelMainPixel.Name = "labelMainPixel";
            this.labelMainPixel.Size = new System.Drawing.Size(153, 13);
            this.labelMainPixel.TabIndex = 6;
            this.labelMainPixel.Text = "screen(s) wide ({0:N} pixel(s))";
            this.labelMainPixel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericMainLength
            // 
            this.numericMainLength.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericMainLength.Location = new System.Drawing.Point(101, 75);
            this.numericMainLength.Maximum = new decimal(new int[] {
            4180,
            0,
            0,
            0});
            this.numericMainLength.Name = "numericMainLength";
            this.numericMainLength.Size = new System.Drawing.Size(89, 21);
            this.numericMainLength.TabIndex = 5;
            this.numericMainLength.ThousandsSeparator = true;
            this.numericMainLength.ValueChanged += new System.EventHandler(this.numericMainLength_ValueChanged);
            // 
            // comboboxMainMusic
            // 
            this.comboboxMainMusic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxMainMusic.FormattingEnabled = true;
            this.comboboxMainMusic.Items.AddRange(new object[] {
            "None",
            "Super Mario Bros. - Overworld",
            "Super Mario World - Here We Go!",
            "Super Mario Bros. 3 - Athletics",
            "Super Mario Bros. 3 - World 1 Map",
            "Super Mario Bros. - Underground",
            "Super Mario World - Castle",
            "Super Mario Bros. - Bowser Battle",
            "Super Mario World - Map",
            "Super Mario Bros. - Starman Theme",
            "Super Mario Bros. - Course Cleared",
            "Super Mario Bros. - Castle Cleared"});
            this.comboboxMainMusic.Location = new System.Drawing.Point(101, 47);
            this.comboboxMainMusic.Name = "comboboxMainMusic";
            this.comboboxMainMusic.Size = new System.Drawing.Size(322, 21);
            this.comboboxMainMusic.TabIndex = 3;
            this.comboboxMainMusic.SelectedIndexChanged += new System.EventHandler(this.comboboxMainMusic_SelectedIndexChanged);
            // 
            // comboboxMainBackground
            // 
            this.comboboxMainBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxMainBackground.FormattingEnabled = true;
            this.comboboxMainBackground.Items.AddRange(new object[] {
            "Clouds",
            "Cave",
            "Forest",
            "Castle",
            "Twilight",
            "Ghost House"});
            this.comboboxMainBackground.Location = new System.Drawing.Point(101, 20);
            this.comboboxMainBackground.Name = "comboboxMainBackground";
            this.comboboxMainBackground.Size = new System.Drawing.Size(322, 21);
            this.comboboxMainBackground.TabIndex = 1;
            this.comboboxMainBackground.SelectedIndexChanged += new System.EventHandler(this.comboboxMainBackground_SelectedIndexChanged);
            // 
            // labelMainMusic
            // 
            this.labelMainMusic.AutoSize = true;
            this.labelMainMusic.Location = new System.Drawing.Point(5, 50);
            this.labelMainMusic.Name = "labelMainMusic";
            this.labelMainMusic.Size = new System.Drawing.Size(96, 13);
            this.labelMainMusic.TabIndex = 2;
            this.labelMainMusic.Text = "Background Music:";
            // 
            // labelMainBackground
            // 
            this.labelMainBackground.AutoSize = true;
            this.labelMainBackground.Location = new System.Drawing.Point(5, 23);
            this.labelMainBackground.Name = "labelMainBackground";
            this.labelMainBackground.Size = new System.Drawing.Size(67, 13);
            this.labelMainBackground.TabIndex = 0;
            this.labelMainBackground.Text = "Background:";
            // 
            // groupboxGeneral
            // 
            this.groupboxGeneral.Controls.Add(this.textboxName);
            this.groupboxGeneral.Controls.Add(this.labelName);
            this.groupboxGeneral.Location = new System.Drawing.Point(10, 61);
            this.groupboxGeneral.Name = "groupboxGeneral";
            this.groupboxGeneral.Size = new System.Drawing.Size(430, 103);
            this.groupboxGeneral.TabIndex = 2;
            this.groupboxGeneral.TabStop = false;
            this.groupboxGeneral.Text = "General";
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(100, 20);
            this.textboxName.MaxLength = 100;
            this.textboxName.Multiline = true;
            this.textboxName.Name = "textboxName";
            this.textboxName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxName.Size = new System.Drawing.Size(324, 77);
            this.textboxName.TabIndex = 1;
            this.textboxName.TextChanged += new System.EventHandler(this.textboxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelMessageLevel
            // 
            this.labelMessageLevel.Location = new System.Drawing.Point(7, 29);
            this.labelMessageLevel.Name = "labelMessageLevel";
            this.labelMessageLevel.Size = new System.Drawing.Size(434, 29);
            this.labelMessageLevel.TabIndex = 1;
            this.labelMessageLevel.Text = "Changes you made to the level will affect the level code. Any changes you made wi" +
                "ll affect how Level2Pic will render your level.";
            // 
            // labelHeaderLevel
            // 
            this.labelHeaderLevel.AutoSize = true;
            this.labelHeaderLevel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderLevel.Location = new System.Drawing.Point(7, 7);
            this.labelHeaderLevel.Name = "labelHeaderLevel";
            this.labelHeaderLevel.Size = new System.Drawing.Size(273, 13);
            this.labelHeaderLevel.TabIndex = 0;
            this.labelHeaderLevel.Text = "View and edit properties about the level loaded";
            // 
            // tabpageInternet
            // 
            this.tabpageInternet.Controls.Add(this.groupboxDescription);
            this.tabpageInternet.Controls.Add(this.groupboxCommunity);
            this.tabpageInternet.Controls.Add(this.groupboxOnlineGeneral);
            this.tabpageInternet.Controls.Add(this.labelHeaderInternet);
            this.tabpageInternet.Location = new System.Drawing.Point(4, 22);
            this.tabpageInternet.Name = "tabpageInternet";
            this.tabpageInternet.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageInternet.Size = new System.Drawing.Size(447, 399);
            this.tabpageInternet.TabIndex = 1;
            this.tabpageInternet.Text = "Pouetpu-Games";
            this.tabpageInternet.UseVisualStyleBackColor = true;
            // 
            // groupboxDescription
            // 
            this.groupboxDescription.Controls.Add(this.textboxDescription);
            this.groupboxDescription.Location = new System.Drawing.Point(10, 257);
            this.groupboxDescription.Name = "groupboxDescription";
            this.groupboxDescription.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupboxDescription.Size = new System.Drawing.Size(430, 136);
            this.groupboxDescription.TabIndex = 0;
            this.groupboxDescription.TabStop = false;
            this.groupboxDescription.Text = "Description";
            // 
            // textboxDescription
            // 
            this.textboxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textboxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDescription.Location = new System.Drawing.Point(5, 13);
            this.textboxDescription.Multiline = true;
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.ReadOnly = true;
            this.textboxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxDescription.Size = new System.Drawing.Size(420, 118);
            this.textboxDescription.TabIndex = 0;
            // 
            // groupboxCommunity
            // 
            this.groupboxCommunity.Controls.Add(this.labelStatus);
            this.groupboxCommunity.Controls.Add(this.labelViewsValue);
            this.groupboxCommunity.Controls.Add(this.labelVotesValue);
            this.groupboxCommunity.Controls.Add(this.labelStatusValue);
            this.groupboxCommunity.Controls.Add(this.labelAverageRatingValue);
            this.groupboxCommunity.Controls.Add(this.labelAverageRating);
            this.groupboxCommunity.Controls.Add(this.labelVotes);
            this.groupboxCommunity.Controls.Add(this.labelViews);
            this.groupboxCommunity.Location = new System.Drawing.Point(10, 133);
            this.groupboxCommunity.Name = "groupboxCommunity";
            this.groupboxCommunity.Size = new System.Drawing.Size(430, 118);
            this.groupboxCommunity.TabIndex = 3;
            this.groupboxCommunity.TabStop = false;
            this.groupboxCommunity.Text = "Community";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(6, 89);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(42, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status:";
            // 
            // labelViewsValue
            // 
            this.labelViewsValue.Location = new System.Drawing.Point(100, 23);
            this.labelViewsValue.Name = "labelViewsValue";
            this.labelViewsValue.Size = new System.Drawing.Size(324, 13);
            this.labelViewsValue.TabIndex = 1;
            this.labelViewsValue.Text = "Unknown";
            // 
            // labelVotesValue
            // 
            this.labelVotesValue.Location = new System.Drawing.Point(100, 45);
            this.labelVotesValue.Name = "labelVotesValue";
            this.labelVotesValue.Size = new System.Drawing.Size(324, 13);
            this.labelVotesValue.TabIndex = 3;
            this.labelVotesValue.Text = "Unknown";
            // 
            // labelStatusValue
            // 
            this.labelStatusValue.Location = new System.Drawing.Point(100, 89);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(324, 13);
            this.labelStatusValue.TabIndex = 7;
            this.labelStatusValue.Text = "Unknown";
            // 
            // labelAverageRatingValue
            // 
            this.labelAverageRatingValue.Location = new System.Drawing.Point(100, 67);
            this.labelAverageRatingValue.Name = "labelAverageRatingValue";
            this.labelAverageRatingValue.Size = new System.Drawing.Size(324, 13);
            this.labelAverageRatingValue.TabIndex = 5;
            this.labelAverageRatingValue.Text = "Unknown";
            // 
            // labelAverageRating
            // 
            this.labelAverageRating.AutoSize = true;
            this.labelAverageRating.Location = new System.Drawing.Point(6, 67);
            this.labelAverageRating.Name = "labelAverageRating";
            this.labelAverageRating.Size = new System.Drawing.Size(86, 13);
            this.labelAverageRating.TabIndex = 4;
            this.labelAverageRating.Text = "Average Rating:";
            // 
            // labelVotes
            // 
            this.labelVotes.AutoSize = true;
            this.labelVotes.Location = new System.Drawing.Point(6, 45);
            this.labelVotes.Name = "labelVotes";
            this.labelVotes.Size = new System.Drawing.Size(73, 13);
            this.labelVotes.TabIndex = 2;
            this.labelVotes.Text = "Total Vote(s):";
            // 
            // labelViews
            // 
            this.labelViews.AutoSize = true;
            this.labelViews.Location = new System.Drawing.Point(6, 23);
            this.labelViews.Name = "labelViews";
            this.labelViews.Size = new System.Drawing.Size(73, 13);
            this.labelViews.TabIndex = 0;
            this.labelViews.Text = "Total View(s):";
            // 
            // groupboxOnlineGeneral
            // 
            this.groupboxOnlineGeneral.Controls.Add(this.labelDatePublishedValue);
            this.groupboxOnlineGeneral.Controls.Add(this.labelDate);
            this.groupboxOnlineGeneral.Controls.Add(this.labelAuthor);
            this.groupboxOnlineGeneral.Controls.Add(this.linkOnlineNameValue);
            this.groupboxOnlineGeneral.Controls.Add(this.linkAuthorValue);
            this.groupboxOnlineGeneral.Controls.Add(this.labelOnlineName);
            this.groupboxOnlineGeneral.Location = new System.Drawing.Point(10, 29);
            this.groupboxOnlineGeneral.Name = "groupboxOnlineGeneral";
            this.groupboxOnlineGeneral.Size = new System.Drawing.Size(427, 98);
            this.groupboxOnlineGeneral.TabIndex = 2;
            this.groupboxOnlineGeneral.TabStop = false;
            this.groupboxOnlineGeneral.Text = "General";
            // 
            // labelDatePublishedValue
            // 
            this.labelDatePublishedValue.Location = new System.Drawing.Point(100, 68);
            this.labelDatePublishedValue.Name = "labelDatePublishedValue";
            this.labelDatePublishedValue.Size = new System.Drawing.Size(324, 13);
            this.labelDatePublishedValue.TabIndex = 5;
            this.labelDatePublishedValue.Text = "Unknown";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(6, 67);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(82, 13);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date Published:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(6, 45);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(91, 13);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Publisher/Author:";
            // 
            // linkOnlineNameValue
            // 
            this.linkOnlineNameValue.AutoSize = true;
            this.linkOnlineNameValue.Location = new System.Drawing.Point(101, 23);
            this.linkOnlineNameValue.Name = "linkOnlineNameValue";
            this.linkOnlineNameValue.Size = new System.Drawing.Size(51, 13);
            this.linkOnlineNameValue.TabIndex = 1;
            this.linkOnlineNameValue.TabStop = true;
            this.linkOnlineNameValue.Text = "Unknown";
            this.linkOnlineNameValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLinks_LinkClicked);
            // 
            // linkAuthorValue
            // 
            this.linkAuthorValue.AutoSize = true;
            this.linkAuthorValue.Location = new System.Drawing.Point(100, 45);
            this.linkAuthorValue.Name = "linkAuthorValue";
            this.linkAuthorValue.Size = new System.Drawing.Size(51, 13);
            this.linkAuthorValue.TabIndex = 3;
            this.linkAuthorValue.TabStop = true;
            this.linkAuthorValue.Text = "Unknown";
            this.linkAuthorValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLinks_LinkClicked);
            // 
            // labelOnlineName
            // 
            this.labelOnlineName.AutoSize = true;
            this.labelOnlineName.Location = new System.Drawing.Point(6, 23);
            this.labelOnlineName.Name = "labelOnlineName";
            this.labelOnlineName.Size = new System.Drawing.Size(71, 13);
            this.labelOnlineName.TabIndex = 0;
            this.labelOnlineName.Text = "Online Name:";
            // 
            // labelHeaderInternet
            // 
            this.labelHeaderInternet.AutoSize = true;
            this.labelHeaderInternet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderInternet.Location = new System.Drawing.Point(7, 7);
            this.labelHeaderInternet.Name = "labelHeaderInternet";
            this.labelHeaderInternet.Size = new System.Drawing.Size(282, 13);
            this.labelHeaderInternet.TabIndex = 0;
            this.labelHeaderInternet.Text = "View information retrieved from Pouetpu-Games";
            // 
            // tabpageCode
            // 
            this.tabpageCode.Controls.Add(this.groupboxLevel);
            this.tabpageCode.Controls.Add(this.groupboxStatistics);
            this.tabpageCode.Location = new System.Drawing.Point(4, 22);
            this.tabpageCode.Name = "tabpageCode";
            this.tabpageCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageCode.Size = new System.Drawing.Size(447, 399);
            this.tabpageCode.TabIndex = 2;
            this.tabpageCode.Text = "Code";
            this.tabpageCode.UseVisualStyleBackColor = true;
            // 
            // groupboxLevel
            // 
            this.groupboxLevel.Controls.Add(this.buttonCopy);
            this.groupboxLevel.Controls.Add(this.textboxLevelCode);
            this.groupboxLevel.Controls.Add(this.labelCode);
            this.groupboxLevel.Location = new System.Drawing.Point(7, 220);
            this.groupboxLevel.Name = "groupboxLevel";
            this.groupboxLevel.Size = new System.Drawing.Size(434, 173);
            this.groupboxLevel.TabIndex = 2;
            this.groupboxLevel.TabStop = false;
            this.groupboxLevel.Text = "Level Code";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(353, 144);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "&Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textboxLevelCode
            // 
            this.textboxLevelCode.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLevelCode.Location = new System.Drawing.Point(6, 47);
            this.textboxLevelCode.Multiline = true;
            this.textboxLevelCode.Name = "textboxLevelCode";
            this.textboxLevelCode.ReadOnly = true;
            this.textboxLevelCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxLevelCode.Size = new System.Drawing.Size(422, 91);
            this.textboxLevelCode.TabIndex = 1;
            this.textboxLevelCode.Text = "Please wait while Level2Pic loads the level code...";
            // 
            // labelCode
            // 
            this.labelCode.Location = new System.Drawing.Point(3, 17);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(422, 27);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "The text box below contains the level\'s Super Mario Flash code. If you want to ed" +
                "it the properties of the level code (such as the background), go to the \"Level\" " +
                "tab.";
            // 
            // groupboxStatistics
            // 
            this.groupboxStatistics.Controls.Add(this.listviewCount);
            this.groupboxStatistics.Controls.Add(this.labelStats);
            this.groupboxStatistics.Location = new System.Drawing.Point(7, 7);
            this.groupboxStatistics.Name = "groupboxStatistics";
            this.groupboxStatistics.Size = new System.Drawing.Size(434, 206);
            this.groupboxStatistics.TabIndex = 1;
            this.groupboxStatistics.TabStop = false;
            this.groupboxStatistics.Text = "Statistics";
            // 
            // listviewCount
            // 
            this.listviewCount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnNumber,
            this.columnPercentage});
            this.listviewCount.Location = new System.Drawing.Point(6, 50);
            this.listviewCount.Name = "listviewCount";
            this.listviewCount.Size = new System.Drawing.Size(422, 150);
            this.listviewCount.TabIndex = 1;
            this.listviewCount.UseCompatibleStateImageBehavior = false;
            this.listviewCount.View = System.Windows.Forms.View.Details;
            this.listviewCount.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listviewCount_ColumnClick);
            // 
            // columnName
            // 
            this.columnName.Tag = "string";
            this.columnName.Text = "Name";
            this.columnName.Width = 220;
            // 
            // columnNumber
            // 
            this.columnNumber.Tag = "int";
            this.columnNumber.Text = "Usage Count";
            this.columnNumber.Width = 107;
            // 
            // columnPercentage
            // 
            this.columnPercentage.Tag = "int";
            this.columnPercentage.Text = "Percentage";
            this.columnPercentage.Width = 68;
            // 
            // labelStats
            // 
            this.labelStats.Location = new System.Drawing.Point(3, 17);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(425, 29);
            this.labelStats.TabIndex = 0;
            this.labelStats.Text = "The list below shows the list of sprites you have used, the number of times the s" +
                "prite have been used, and how much it makes up of your level.";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(393, 444);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // backgroundworkerCode
            // 
            this.backgroundworkerCode.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundworkerCode_DoWork);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 476);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabcontrolMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Information";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Properties";
            this.tabcontrolMain.ResumeLayout(false);
            this.tabpageLevel.ResumeLayout(false);
            this.tabpageLevel.PerformLayout();
            this.groupboxBonus.ResumeLayout(false);
            this.groupboxBonus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBonusLength)).EndInit();
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMainLength)).EndInit();
            this.groupboxGeneral.ResumeLayout(false);
            this.groupboxGeneral.PerformLayout();
            this.tabpageInternet.ResumeLayout(false);
            this.tabpageInternet.PerformLayout();
            this.groupboxDescription.ResumeLayout(false);
            this.groupboxDescription.PerformLayout();
            this.groupboxCommunity.ResumeLayout(false);
            this.groupboxCommunity.PerformLayout();
            this.groupboxOnlineGeneral.ResumeLayout(false);
            this.groupboxOnlineGeneral.PerformLayout();
            this.tabpageCode.ResumeLayout(false);
            this.groupboxLevel.ResumeLayout(false);
            this.groupboxLevel.PerformLayout();
            this.groupboxStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrolMain;
        private System.Windows.Forms.TabPage tabpageLevel;
        private System.Windows.Forms.TabPage tabpageInternet;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelHeaderLevel;
        private System.Windows.Forms.Label labelMessageLevel;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupboxBonus;
        private System.Windows.Forms.Label labelBonusLength;
        private System.Windows.Forms.Label labelBonusPixel;
        private System.Windows.Forms.NumericUpDown numericBonusLength;
        private System.Windows.Forms.ComboBox comboboxBonusMusic;
        private System.Windows.Forms.ComboBox comboboxBonusBackground;
        private System.Windows.Forms.Label labelBonusMusic;
        private System.Windows.Forms.Label labelBonusBackground;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label labelMainLength;
        private System.Windows.Forms.Label labelMainPixel;
        private System.Windows.Forms.NumericUpDown numericMainLength;
        private System.Windows.Forms.ComboBox comboboxMainMusic;
        private System.Windows.Forms.ComboBox comboboxMainBackground;
        private System.Windows.Forms.Label labelMainMusic;
        private System.Windows.Forms.Label labelMainBackground;
        private System.Windows.Forms.GroupBox groupboxGeneral;
        private System.Windows.Forms.Label labelHeaderInternet;
        private System.Windows.Forms.GroupBox groupboxOnlineGeneral;
        private System.Windows.Forms.Label labelOnlineName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelDatePublishedValue;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.LinkLabel linkAuthorValue;
        private System.Windows.Forms.GroupBox groupboxCommunity;
        private System.Windows.Forms.Label labelViewsValue;
        private System.Windows.Forms.Label labelVotesValue;
        private System.Windows.Forms.Label labelAverageRatingValue;
        private System.Windows.Forms.Label labelAverageRating;
        private System.Windows.Forms.Label labelVotes;
        private System.Windows.Forms.Label labelViews;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusValue;
        private System.Windows.Forms.GroupBox groupboxDescription;
        private System.Windows.Forms.TextBox textboxDescription;
        private System.Windows.Forms.LinkLabel linkOnlineNameValue;
        private System.Windows.Forms.TabPage tabpageCode;
        private System.Windows.Forms.GroupBox groupboxLevel;
        private System.Windows.Forms.TextBox textboxLevelCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.GroupBox groupboxStatistics;
        private System.Windows.Forms.ListView listviewCount;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnPercentage;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Button buttonCopy;
        private System.ComponentModel.BackgroundWorker backgroundworkerCode;
    }
}