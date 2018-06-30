namespace Level2Pic.Forms
{
    partial class Error
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Errors", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Warnings", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.listviewError = new System.Windows.Forms.ListView();
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imagelistIcons = new System.Windows.Forms.ImageList(this.components);
            this.separator1 = new CDBurnerXP.Controls.Separator();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(423, 13);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "View the list of errors and warnings that occured while validating the level";
            // 
            // labelMessage
            // 
            this.labelMessage.Location = new System.Drawing.Point(12, 31);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(570, 27);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Any critical errors displayed below will cause Level2Pic to not load your level. " +
                "Warnings are listed to notify you about issues that may arise when attempting to" +
                " load the level in Super Mario Flash.";
            // 
            // listviewError
            // 
            this.listviewError.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDescription});
            listViewGroup1.Header = "Errors";
            listViewGroup1.Name = "groupErrors";
            listViewGroup2.Header = "Warnings";
            listViewGroup2.Name = "groupWarnings";
            this.listviewError.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listviewError.Location = new System.Drawing.Point(15, 71);
            this.listviewError.Name = "listviewError";
            this.listviewError.Size = new System.Drawing.Size(567, 163);
            this.listviewError.SmallImageList = this.imagelistIcons;
            this.listviewError.TabIndex = 2;
            this.listviewError.UseCompatibleStateImageBehavior = false;
            this.listviewError.View = System.Windows.Forms.View.Details;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 544;
            // 
            // imagelistIcons
            // 
            this.imagelistIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelistIcons.ImageStream")));
            this.imagelistIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelistIcons.Images.SetKeyName(0, "Warning");
            this.imagelistIcons.Images.SetKeyName(1, "Error");
            // 
            // separator1
            // 
            this.separator1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.separator1.Location = new System.Drawing.Point(15, 237);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(567, 11);
            this.separator1.TabIndex = 3;
            this.separator1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(507, 253);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(597, 288);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.listviewError);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Error";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.ListView listviewError;
        private System.Windows.Forms.ImageList imagelistIcons;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private CDBurnerXP.Controls.Separator separator1;
        private System.Windows.Forms.Button buttonCancel;
    }
}