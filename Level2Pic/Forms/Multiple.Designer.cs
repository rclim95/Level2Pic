namespace Level2Pic.Forms
{
    partial class Multiple
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.comboboxLevel = new System.Windows.Forms.ComboBox();
            this.textboxCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.separator1 = new CDBurnerXP.Controls.Separator();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(308, 13);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Multiple levels were found while reading the webpage";
            // 
            // labelMessage
            // 
            this.labelMessage.Location = new System.Drawing.Point(12, 31);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(501, 28);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Select the level you would like to load in the \"Level\" list below. The code will " +
                "automatically be shown to you upon selecting a level.";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(12, 68);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(36, 13);
            this.labelLevel.TabIndex = 2;
            this.labelLevel.Text = "Level:";
            // 
            // comboboxLevel
            // 
            this.comboboxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxLevel.FormattingEnabled = true;
            this.comboboxLevel.Location = new System.Drawing.Point(100, 65);
            this.comboboxLevel.Name = "comboboxLevel";
            this.comboboxLevel.Size = new System.Drawing.Size(413, 21);
            this.comboboxLevel.TabIndex = 3;
            this.comboboxLevel.SelectedIndexChanged += new System.EventHandler(this.comboboxLevel_SelectedIndexChanged);
            // 
            // textboxCode
            // 
            this.textboxCode.BackColor = System.Drawing.SystemColors.Window;
            this.textboxCode.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxCode.Location = new System.Drawing.Point(100, 93);
            this.textboxCode.Multiline = true;
            this.textboxCode.Name = "textboxCode";
            this.textboxCode.ReadOnly = true;
            this.textboxCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxCode.Size = new System.Drawing.Size(413, 85);
            this.textboxCode.TabIndex = 5;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(12, 94);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(36, 13);
            this.labelCode.TabIndex = 4;
            this.labelCode.Text = "Code:";
            // 
            // separator1
            // 
            this.separator1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.separator1.Location = new System.Drawing.Point(12, 181);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(501, 10);
            this.separator1.TabIndex = 6;
            this.separator1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonLoad
            // 
            this.buttonLoad.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLoad.Location = new System.Drawing.Point(357, 194);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(438, 194);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Cancel";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // Multiple
            // 
            this.AcceptButton = this.buttonLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(525, 225);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.textboxCode);
            this.Controls.Add(this.comboboxLevel);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Multiple";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Multiple Level Located";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ComboBox comboboxLevel;
        private System.Windows.Forms.TextBox textboxCode;
        private System.Windows.Forms.Label labelCode;
        private CDBurnerXP.Controls.Separator separator1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonClose;
    }
}