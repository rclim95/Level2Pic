namespace Level2Pic.Forms
{
    partial class Graphics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphics));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxDescriptions = new System.Windows.Forms.TextBox();
            this.labelSpriteName = new System.Windows.Forms.Label();
            this.pictureboxSprite = new System.Windows.Forms.PictureBox();
            this.splitcontainerSprites = new System.Windows.Forms.SplitContainer();
            this.listviewSprites = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboboxSprites = new System.Windows.Forms.ComboBox();
            this.propertygridSprites = new System.Windows.Forms.PropertyGrid();
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxSprite)).BeginInit();
            this.splitcontainerSprites.Panel1.SuspendLayout();
            this.splitcontainerSprites.Panel2.SuspendLayout();
            this.splitcontainerSprites.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitcontainerSprites, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.textboxDescriptions);
            this.panel1.Controls.Add(this.labelSpriteName);
            this.panel1.Controls.Add(this.pictureboxSprite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 109);
            this.panel1.TabIndex = 0;
            // 
            // textboxDescriptions
            // 
            this.textboxDescriptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxDescriptions.BackColor = System.Drawing.SystemColors.Info;
            this.textboxDescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxDescriptions.Location = new System.Drawing.Point(112, 32);
            this.textboxDescriptions.Multiline = true;
            this.textboxDescriptions.Name = "textboxDescriptions";
            this.textboxDescriptions.Size = new System.Drawing.Size(505, 59);
            this.textboxDescriptions.TabIndex = 2;
            this.textboxDescriptions.Text = "To begin, select a sprite in the list above. Information and properties will be d" +
                "isplayed here and in the Properties pane on the right.";
            // 
            // labelSpriteName
            // 
            this.labelSpriteName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpriteName.Location = new System.Drawing.Point(112, 13);
            this.labelSpriteName.Name = "labelSpriteName";
            this.labelSpriteName.Size = new System.Drawing.Size(505, 16);
            this.labelSpriteName.TabIndex = 1;
            this.labelSpriteName.Text = "No Sprite Selected";
            // 
            // pictureboxSprite
            // 
            this.pictureboxSprite.Location = new System.Drawing.Point(3, 4);
            this.pictureboxSprite.Name = "pictureboxSprite";
            this.pictureboxSprite.Size = new System.Drawing.Size(100, 100);
            this.pictureboxSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureboxSprite.TabIndex = 0;
            this.pictureboxSprite.TabStop = false;
            // 
            // splitcontainerSprites
            // 
            this.splitcontainerSprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitcontainerSprites.Location = new System.Drawing.Point(3, 3);
            this.splitcontainerSprites.Name = "splitcontainerSprites";
            // 
            // splitcontainerSprites.Panel1
            // 
            this.splitcontainerSprites.Panel1.Controls.Add(this.listviewSprites);
            this.splitcontainerSprites.Panel1.Controls.Add(this.comboboxSprites);
            // 
            // splitcontainerSprites.Panel2
            // 
            this.splitcontainerSprites.Panel2.Controls.Add(this.propertygridSprites);
            this.splitcontainerSprites.Size = new System.Drawing.Size(626, 325);
            this.splitcontainerSprites.SplitterDistance = 442;
            this.splitcontainerSprites.TabIndex = 1;
            // 
            // listviewSprites
            // 
            this.listviewSprites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listviewSprites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnSize});
            this.listviewSprites.FullRowSelect = true;
            this.listviewSprites.HideSelection = false;
            this.listviewSprites.Location = new System.Drawing.Point(3, 30);
            this.listviewSprites.MultiSelect = false;
            this.listviewSprites.Name = "listviewSprites";
            this.listviewSprites.ShowItemToolTips = true;
            this.listviewSprites.Size = new System.Drawing.Size(436, 295);
            this.listviewSprites.TabIndex = 2;
            this.listviewSprites.UseCompatibleStateImageBehavior = false;
            this.listviewSprites.View = System.Windows.Forms.View.Details;
            this.listviewSprites.SelectedIndexChanged += new System.EventHandler(this.listviewSprites_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 34;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 316;
            // 
            // comboboxSprites
            // 
            this.comboboxSprites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxSprites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxSprites.FormattingEnabled = true;
            this.comboboxSprites.Items.AddRange(new object[] {
            "Backgrounds",
            "Tiles and Enemies",
            "Platform Labels"});
            this.comboboxSprites.Location = new System.Drawing.Point(3, 3);
            this.comboboxSprites.Name = "comboboxSprites";
            this.comboboxSprites.Size = new System.Drawing.Size(436, 21);
            this.comboboxSprites.TabIndex = 1;
            this.comboboxSprites.SelectedIndexChanged += new System.EventHandler(this.comboboxSprites_SelectedIndexChanged);
            // 
            // propertygridSprites
            // 
            this.propertygridSprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertygridSprites.Location = new System.Drawing.Point(0, 0);
            this.propertygridSprites.Name = "propertygridSprites";
            this.propertygridSprites.Size = new System.Drawing.Size(180, 325);
            this.propertygridSprites.TabIndex = 0;
            this.propertygridSprites.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertygridSprites_PropertyValueChanged);
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size";
            // 
            // Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graphics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Graphics Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Graphics_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxSprite)).EndInit();
            this.splitcontainerSprites.Panel1.ResumeLayout(false);
            this.splitcontainerSprites.Panel2.ResumeLayout(false);
            this.splitcontainerSprites.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureboxSprite;
        private System.Windows.Forms.TextBox textboxDescriptions;
        private System.Windows.Forms.Label labelSpriteName;
        private System.Windows.Forms.SplitContainer splitcontainerSprites;
        private System.Windows.Forms.ComboBox comboboxSprites;
        private System.Windows.Forms.ListView listviewSprites;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.PropertyGrid propertygridSprites;
        private System.Windows.Forms.ColumnHeader columnSize;
    }
}