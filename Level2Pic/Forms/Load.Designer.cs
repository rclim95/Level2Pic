namespace Level2Pic.Forms
{
    partial class Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.labelHeader = new System.Windows.Forms.Label();
            this.radiobuttonInternet = new System.Windows.Forms.RadioButton();
            this.labelInternetMessage = new System.Windows.Forms.Label();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.textboxWebsite = new System.Windows.Forms.TextBox();
            this.radiobuttonCode = new System.Windows.Forms.RadioButton();
            this.labelCodeMessage = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.textboxCode = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelGetCode = new System.Windows.Forms.Label();
            this.separator3 = new CDBurnerXP.Controls.Separator();
            this.separator2 = new CDBurnerXP.Controls.Separator();
            this.separator1 = new CDBurnerXP.Controls.Separator();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(397, 13);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Choose the method to use to load a Super Mario Flash v3.0 level code";
            // 
            // radiobuttonInternet
            // 
            this.radiobuttonInternet.AutoSize = true;
            this.radiobuttonInternet.Checked = true;
            this.radiobuttonInternet.Location = new System.Drawing.Point(15, 34);
            this.radiobuttonInternet.Name = "radiobuttonInternet";
            this.radiobuttonInternet.Size = new System.Drawing.Size(211, 17);
            this.radiobuttonInternet.TabIndex = 1;
            this.radiobuttonInternet.TabStop = true;
            this.radiobuttonInternet.Text = "Load a level from the following website";
            this.radiobuttonInternet.UseVisualStyleBackColor = true;
            this.radiobuttonInternet.CheckedChanged += new System.EventHandler(this.radiobuttonMethods_CheckedChanged);
            // 
            // labelInternetMessage
            // 
            this.labelInternetMessage.Location = new System.Drawing.Point(31, 54);
            this.labelInternetMessage.Name = "labelInternetMessage";
            this.labelInternetMessage.Size = new System.Drawing.Size(509, 41);
            this.labelInternetMessage.TabIndex = 3;
            this.labelInternetMessage.Text = resources.GetString("labelInternetMessage.Text");
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Location = new System.Drawing.Point(31, 104);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(50, 13);
            this.labelWebsite.TabIndex = 4;
            this.labelWebsite.Text = "Website:";
            // 
            // textboxWebsite
            // 
            this.textboxWebsite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textboxWebsite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.textboxWebsite.Location = new System.Drawing.Point(87, 101);
            this.textboxWebsite.Name = "textboxWebsite";
            this.textboxWebsite.Size = new System.Drawing.Size(453, 21);
            this.textboxWebsite.TabIndex = 5;
            // 
            // radiobuttonCode
            // 
            this.radiobuttonCode.AutoSize = true;
            this.radiobuttonCode.Location = new System.Drawing.Point(15, 137);
            this.radiobuttonCode.Name = "radiobuttonCode";
            this.radiobuttonCode.Size = new System.Drawing.Size(197, 17);
            this.radiobuttonCode.TabIndex = 6;
            this.radiobuttonCode.Text = "Load a level from the following code";
            this.radiobuttonCode.UseVisualStyleBackColor = true;
            this.radiobuttonCode.CheckedChanged += new System.EventHandler(this.radiobuttonMethods_CheckedChanged);
            // 
            // labelCodeMessage
            // 
            this.labelCodeMessage.Enabled = false;
            this.labelCodeMessage.Location = new System.Drawing.Point(31, 157);
            this.labelCodeMessage.Name = "labelCodeMessage";
            this.labelCodeMessage.Size = new System.Drawing.Size(509, 27);
            this.labelCodeMessage.TabIndex = 8;
            this.labelCodeMessage.Text = "Level2Pic will validate the code for errors and notify you about them. If the val" +
                "idation is successful, then you will be allowed to make a level map of this leve" +
                "l.";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Enabled = false;
            this.labelCode.Location = new System.Drawing.Point(31, 193);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(36, 13);
            this.labelCode.TabIndex = 9;
            this.labelCode.Text = "Code:";
            // 
            // textboxCode
            // 
            this.textboxCode.Enabled = false;
            this.textboxCode.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxCode.Location = new System.Drawing.Point(87, 193);
            this.textboxCode.Multiline = true;
            this.textboxCode.Name = "textboxCode";
            this.textboxCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxCode.Size = new System.Drawing.Size(453, 68);
            this.textboxCode.TabIndex = 10;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(384, 282);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "&Load";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(465, 282);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "&Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelGetCode
            // 
            this.labelGetCode.AutoSize = true;
            this.labelGetCode.Location = new System.Drawing.Point(12, 287);
            this.labelGetCode.Name = "labelGetCode";
            this.labelGetCode.Size = new System.Drawing.Size(223, 13);
            this.labelGetCode.TabIndex = 14;
            this.labelGetCode.Text = "Downloading website\'s source... Please wait.";
            this.labelGetCode.Visible = false;
            // 
            // separator3
            // 
            this.separator3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.separator3.Location = new System.Drawing.Point(17, 267);
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(523, 10);
            this.separator3.TabIndex = 11;
            this.separator3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // separator2
            // 
            this.separator2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.separator2.Location = new System.Drawing.Point(218, 137);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(322, 17);
            this.separator2.TabIndex = 7;
            this.separator2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // separator1
            // 
            this.separator1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.separator1.Location = new System.Drawing.Point(232, 34);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(308, 17);
            this.separator1.TabIndex = 2;
            this.separator1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Load
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(552, 314);
            this.Controls.Add(this.labelGetCode);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.separator3);
            this.Controls.Add(this.textboxCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelCodeMessage);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.radiobuttonCode);
            this.Controls.Add(this.textboxWebsite);
            this.Controls.Add(this.labelWebsite);
            this.Controls.Add(this.labelInternetMessage);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.radiobuttonInternet);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Load";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Level Code";
            this.Activated += new System.EventHandler(this.Load_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.RadioButton radiobuttonInternet;
        private CDBurnerXP.Controls.Separator separator1;
        private System.Windows.Forms.Label labelInternetMessage;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.TextBox textboxWebsite;
        private System.Windows.Forms.RadioButton radiobuttonCode;
        private CDBurnerXP.Controls.Separator separator2;
        private System.Windows.Forms.Label labelCodeMessage;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textboxCode;
        private CDBurnerXP.Controls.Separator separator3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelGetCode;
    }
}