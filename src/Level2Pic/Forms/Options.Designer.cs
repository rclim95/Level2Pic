namespace Level2Pic.Forms
{
    partial class Options
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
            this.tabcontrolOptions = new System.Windows.Forms.TabControl();
            this.tabpageGeneral = new System.Windows.Forms.TabPage();
            this.groupboxGraphics = new System.Windows.Forms.GroupBox();
            this.buttonGraphics = new System.Windows.Forms.Button();
            this.labelGraphics = new System.Windows.Forms.Label();
            this.groupboxStorage = new System.Windows.Forms.GroupBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonClearNow = new System.Windows.Forms.Button();
            this.labelStorage = new System.Windows.Forms.Label();
            this.checkboxDeleteOnExit = new System.Windows.Forms.CheckBox();
            this.groupboxLoad = new System.Windows.Forms.GroupBox();
            this.checkboxRenderOnSave = new System.Windows.Forms.CheckBox();
            this.comboboxDefaultSelection = new System.Windows.Forms.ComboBox();
            this.labelDefaultSelection = new System.Windows.Forms.Label();
            this.labelAutoPreview = new System.Windows.Forms.Label();
            this.checkboxAutoPreview = new System.Windows.Forms.CheckBox();
            this.checkboxAutoConvert = new System.Windows.Forms.CheckBox();
            this.tabpageProperties = new System.Windows.Forms.TabPage();
            this.propertygridArguments = new System.Windows.Forms.PropertyGrid();
            this.comboboxZone = new System.Windows.Forms.ComboBox();
            this.separatorProperties = new CDBurnerXP.Controls.Separator();
            this.separatorZone = new CDBurnerXP.Controls.Separator();
            this.labelDefaultProperties = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabcontrolOptions.SuspendLayout();
            this.tabpageGeneral.SuspendLayout();
            this.groupboxGraphics.SuspendLayout();
            this.groupboxStorage.SuspendLayout();
            this.groupboxLoad.SuspendLayout();
            this.tabpageProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrolOptions
            // 
            this.tabcontrolOptions.Controls.Add(this.tabpageGeneral);
            this.tabcontrolOptions.Controls.Add(this.tabpageProperties);
            this.tabcontrolOptions.Location = new System.Drawing.Point(13, 12);
            this.tabcontrolOptions.Name = "tabcontrolOptions";
            this.tabcontrolOptions.SelectedIndex = 0;
            this.tabcontrolOptions.Size = new System.Drawing.Size(431, 420);
            this.tabcontrolOptions.TabIndex = 0;
            // 
            // tabpageGeneral
            // 
            this.tabpageGeneral.Controls.Add(this.groupboxGraphics);
            this.tabpageGeneral.Controls.Add(this.groupboxStorage);
            this.tabpageGeneral.Controls.Add(this.groupboxLoad);
            this.tabpageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabpageGeneral.Name = "tabpageGeneral";
            this.tabpageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageGeneral.Size = new System.Drawing.Size(423, 394);
            this.tabpageGeneral.TabIndex = 0;
            this.tabpageGeneral.Text = "General";
            this.tabpageGeneral.UseVisualStyleBackColor = true;
            // 
            // groupboxGraphics
            // 
            this.groupboxGraphics.Controls.Add(this.buttonGraphics);
            this.groupboxGraphics.Controls.Add(this.labelGraphics);
            this.groupboxGraphics.Location = new System.Drawing.Point(6, 294);
            this.groupboxGraphics.Name = "groupboxGraphics";
            this.groupboxGraphics.Size = new System.Drawing.Size(410, 94);
            this.groupboxGraphics.TabIndex = 2;
            this.groupboxGraphics.TabStop = false;
            this.groupboxGraphics.Text = "Graphics Manager";
            // 
            // buttonGraphics
            // 
            this.buttonGraphics.Location = new System.Drawing.Point(265, 65);
            this.buttonGraphics.Name = "buttonGraphics";
            this.buttonGraphics.Size = new System.Drawing.Size(139, 23);
            this.buttonGraphics.TabIndex = 1;
            this.buttonGraphics.Text = "View &Graphics Manager";
            this.buttonGraphics.UseVisualStyleBackColor = true;
            // 
            // labelGraphics
            // 
            this.labelGraphics.Location = new System.Drawing.Point(6, 17);
            this.labelGraphics.Name = "labelGraphics";
            this.labelGraphics.Size = new System.Drawing.Size(398, 29);
            this.labelGraphics.TabIndex = 0;
            this.labelGraphics.Text = "To manage the properties of sprites and graphics that Level2Pic uses when renderi" +
                "ng your level, visit the Graphics Manager.";
            // 
            // groupboxStorage
            // 
            this.groupboxStorage.Controls.Add(this.buttonView);
            this.groupboxStorage.Controls.Add(this.buttonClearNow);
            this.groupboxStorage.Controls.Add(this.labelStorage);
            this.groupboxStorage.Controls.Add(this.checkboxDeleteOnExit);
            this.groupboxStorage.Location = new System.Drawing.Point(6, 177);
            this.groupboxStorage.Name = "groupboxStorage";
            this.groupboxStorage.Size = new System.Drawing.Size(410, 111);
            this.groupboxStorage.TabIndex = 1;
            this.groupboxStorage.TabStop = false;
            this.groupboxStorage.Text = "Storage Folder";
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(329, 79);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 23);
            this.buttonView.TabIndex = 3;
            this.buttonView.Text = "&View Folder";
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // buttonClearNow
            // 
            this.buttonClearNow.Location = new System.Drawing.Point(218, 79);
            this.buttonClearNow.Name = "buttonClearNow";
            this.buttonClearNow.Size = new System.Drawing.Size(105, 23);
            this.buttonClearNow.TabIndex = 2;
            this.buttonClearNow.Text = "&Clear Unused Files";
            this.buttonClearNow.UseVisualStyleBackColor = true;
            // 
            // labelStorage
            // 
            this.labelStorage.Location = new System.Drawing.Point(6, 17);
            this.labelStorage.Name = "labelStorage";
            this.labelStorage.Size = new System.Drawing.Size(398, 27);
            this.labelStorage.TabIndex = 0;
            this.labelStorage.Text = "Manage how Level2Pic handles the storage folder, which stores images to speed up " +
                "the rendering process.";
            // 
            // checkboxDeleteOnExit
            // 
            this.checkboxDeleteOnExit.AutoSize = true;
            this.checkboxDeleteOnExit.Checked = global::Level2Pic.Properties.Settings.Default.ClearOnExit;
            this.checkboxDeleteOnExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxDeleteOnExit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Level2Pic.Properties.Settings.Default, "ClearOnExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkboxDeleteOnExit.Location = new System.Drawing.Point(9, 56);
            this.checkboxDeleteOnExit.Name = "checkboxDeleteOnExit";
            this.checkboxDeleteOnExit.Size = new System.Drawing.Size(169, 17);
            this.checkboxDeleteOnExit.TabIndex = 1;
            this.checkboxDeleteOnExit.Text = "Clear the storage folder on exit";
            this.checkboxDeleteOnExit.UseVisualStyleBackColor = true;
            // 
            // groupboxLoad
            // 
            this.groupboxLoad.Controls.Add(this.checkboxRenderOnSave);
            this.groupboxLoad.Controls.Add(this.comboboxDefaultSelection);
            this.groupboxLoad.Controls.Add(this.labelDefaultSelection);
            this.groupboxLoad.Controls.Add(this.labelAutoPreview);
            this.groupboxLoad.Controls.Add(this.checkboxAutoPreview);
            this.groupboxLoad.Controls.Add(this.checkboxAutoConvert);
            this.groupboxLoad.Location = new System.Drawing.Point(6, 3);
            this.groupboxLoad.Name = "groupboxLoad";
            this.groupboxLoad.Size = new System.Drawing.Size(410, 168);
            this.groupboxLoad.TabIndex = 0;
            this.groupboxLoad.TabStop = false;
            this.groupboxLoad.Text = "Rendering";
            // 
            // checkboxRenderOnSave
            // 
            this.checkboxRenderOnSave.AutoSize = true;
            this.checkboxRenderOnSave.Location = new System.Drawing.Point(9, 117);
            this.checkboxRenderOnSave.Name = "checkboxRenderOnSave";
            this.checkboxRenderOnSave.Size = new System.Drawing.Size(386, 17);
            this.checkboxRenderOnSave.TabIndex = 5;
            this.checkboxRenderOnSave.Text = "Automatically renderthe level map again when I save or copy the level map";
            this.checkboxRenderOnSave.UseVisualStyleBackColor = true;
            // 
            // comboboxDefaultSelection
            // 
            this.comboboxDefaultSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxDefaultSelection.FormattingEnabled = true;
            this.comboboxDefaultSelection.Items.AddRange(new object[] {
            "Main Zone and Bonus Room",
            "Main Zone Only",
            "Bonus Room Only"});
            this.comboboxDefaultSelection.Location = new System.Drawing.Point(104, 140);
            this.comboboxDefaultSelection.Name = "comboboxDefaultSelection";
            this.comboboxDefaultSelection.Size = new System.Drawing.Size(297, 21);
            this.comboboxDefaultSelection.TabIndex = 4;
            // 
            // labelDefaultSelection
            // 
            this.labelDefaultSelection.AutoSize = true;
            this.labelDefaultSelection.Location = new System.Drawing.Point(6, 143);
            this.labelDefaultSelection.Name = "labelDefaultSelection";
            this.labelDefaultSelection.Size = new System.Drawing.Size(92, 13);
            this.labelDefaultSelection.TabIndex = 3;
            this.labelDefaultSelection.Text = "Default Selection:";
            // 
            // labelAutoPreview
            // 
            this.labelAutoPreview.Enabled = false;
            this.labelAutoPreview.Location = new System.Drawing.Point(28, 64);
            this.labelAutoPreview.Name = "labelAutoPreview";
            this.labelAutoPreview.Size = new System.Drawing.Size(373, 41);
            this.labelAutoPreview.TabIndex = 2;
            this.labelAutoPreview.Text = "AutoPreview allows you to see the changes you made in the \"Properties\" panel auto" +
                "matically in the \"Preview\" panel without having to render your level map again.";
            // 
            // checkboxAutoPreview
            // 
            this.checkboxAutoPreview.AutoSize = true;
            this.checkboxAutoPreview.Checked = global::Level2Pic.Properties.Settings.Default.AutoPreview;
            this.checkboxAutoPreview.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Level2Pic.Properties.Settings.Default, "AutoPreview", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkboxAutoPreview.Enabled = false;
            this.checkboxAutoPreview.Location = new System.Drawing.Point(31, 44);
            this.checkboxAutoPreview.Name = "checkboxAutoPreview";
            this.checkboxAutoPreview.Size = new System.Drawing.Size(122, 17);
            this.checkboxAutoPreview.TabIndex = 1;
            this.checkboxAutoPreview.Text = "Enable AutoPreview";
            this.checkboxAutoPreview.UseVisualStyleBackColor = true;
            // 
            // checkboxAutoConvert
            // 
            this.checkboxAutoConvert.AutoSize = true;
            this.checkboxAutoConvert.Checked = global::Level2Pic.Properties.Settings.Default.AutoRender;
            this.checkboxAutoConvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Level2Pic.Properties.Settings.Default, "AutoRender", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkboxAutoConvert.Location = new System.Drawing.Point(9, 20);
            this.checkboxAutoConvert.Name = "checkboxAutoConvert";
            this.checkboxAutoConvert.Size = new System.Drawing.Size(330, 17);
            this.checkboxAutoConvert.TabIndex = 0;
            this.checkboxAutoConvert.Text = "Start rendering the level once I load it or change zones to draw";
            this.checkboxAutoConvert.UseVisualStyleBackColor = true;
            // 
            // tabpageProperties
            // 
            this.tabpageProperties.Controls.Add(this.propertygridArguments);
            this.tabpageProperties.Controls.Add(this.comboboxZone);
            this.tabpageProperties.Controls.Add(this.separatorProperties);
            this.tabpageProperties.Controls.Add(this.separatorZone);
            this.tabpageProperties.Controls.Add(this.labelDefaultProperties);
            this.tabpageProperties.Location = new System.Drawing.Point(4, 22);
            this.tabpageProperties.Name = "tabpageProperties";
            this.tabpageProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageProperties.Size = new System.Drawing.Size(423, 394);
            this.tabpageProperties.TabIndex = 1;
            this.tabpageProperties.Text = "Default Properties";
            this.tabpageProperties.UseVisualStyleBackColor = true;
            // 
            // propertygridArguments
            // 
            this.propertygridArguments.Location = new System.Drawing.Point(6, 102);
            this.propertygridArguments.Name = "propertygridArguments";
            this.propertygridArguments.Size = new System.Drawing.Size(410, 286);
            this.propertygridArguments.TabIndex = 4;
            this.propertygridArguments.ToolbarVisible = false;
            this.propertygridArguments.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertygridArguments_PropertyValueChanged);
            // 
            // comboboxZone
            // 
            this.comboboxZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxZone.FormattingEnabled = true;
            this.comboboxZone.Items.AddRange(new object[] {
            "Two Zone Conversion (Main Zone and Bonus Room)",
            "One Zone Conversion (Main Zone or Bonus Room Only)"});
            this.comboboxZone.Location = new System.Drawing.Point(6, 52);
            this.comboboxZone.Name = "comboboxZone";
            this.comboboxZone.Size = new System.Drawing.Size(410, 21);
            this.comboboxZone.TabIndex = 2;
            this.comboboxZone.SelectedIndexChanged += new System.EventHandler(this.comboboxZone_SelectedIndexChanged);
            // 
            // separatorProperties
            // 
            this.separatorProperties.ForeColor = System.Drawing.SystemColors.ControlText;
            this.separatorProperties.Location = new System.Drawing.Point(3, 85);
            this.separatorProperties.Name = "separatorProperties";
            this.separatorProperties.Size = new System.Drawing.Size(413, 13);
            this.separatorProperties.TabIndex = 3;
            this.separatorProperties.Text = "Properties";
            this.separatorProperties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // separatorZone
            // 
            this.separatorZone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.separatorZone.Location = new System.Drawing.Point(3, 35);
            this.separatorZone.Name = "separatorZone";
            this.separatorZone.Size = new System.Drawing.Size(413, 14);
            this.separatorZone.TabIndex = 1;
            this.separatorZone.Text = "Edit Properties For...";
            this.separatorZone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDefaultProperties
            // 
            this.labelDefaultProperties.Location = new System.Drawing.Point(3, 7);
            this.labelDefaultProperties.Name = "labelDefaultProperties";
            this.labelDefaultProperties.Size = new System.Drawing.Size(413, 27);
            this.labelDefaultProperties.TabIndex = 0;
            this.labelDefaultProperties.Text = "Change the default properties to use everytime you load a Super Mario Flash level" +
                ".";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(288, 438);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(369, 438);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(456, 473);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tabcontrolOptions);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.Text = "Level2Pic Options";
            this.tabcontrolOptions.ResumeLayout(false);
            this.tabpageGeneral.ResumeLayout(false);
            this.groupboxGraphics.ResumeLayout(false);
            this.groupboxStorage.ResumeLayout(false);
            this.groupboxStorage.PerformLayout();
            this.groupboxLoad.ResumeLayout(false);
            this.groupboxLoad.PerformLayout();
            this.tabpageProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrolOptions;
        private System.Windows.Forms.TabPage tabpageGeneral;
        private System.Windows.Forms.TabPage tabpageProperties;
        private System.Windows.Forms.GroupBox groupboxStorage;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonClearNow;
        private System.Windows.Forms.Label labelStorage;
        private System.Windows.Forms.CheckBox checkboxDeleteOnExit;
        private System.Windows.Forms.GroupBox groupboxLoad;
        private System.Windows.Forms.Label labelAutoPreview;
        private System.Windows.Forms.CheckBox checkboxAutoPreview;
        private System.Windows.Forms.CheckBox checkboxAutoConvert;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDefaultProperties;
        private System.Windows.Forms.PropertyGrid propertygridArguments;
        private System.Windows.Forms.ComboBox comboboxZone;
        private CDBurnerXP.Controls.Separator separatorProperties;
        private CDBurnerXP.Controls.Separator separatorZone;
        private System.Windows.Forms.GroupBox groupboxGraphics;
        private System.Windows.Forms.Button buttonGraphics;
        private System.Windows.Forms.Label labelGraphics;
        private System.Windows.Forms.ComboBox comboboxDefaultSelection;
        private System.Windows.Forms.Label labelDefaultSelection;
        private System.Windows.Forms.CheckBox checkboxRenderOnSave;
    }
}