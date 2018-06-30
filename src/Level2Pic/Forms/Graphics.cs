using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Level2Pic.Library;

namespace Level2Pic.Forms
{
    public partial class Graphics : Form
    {
        private SpriteDocument document;
        private ListViewItem selectedItem = null;
        private Sprite selectedSprite = null;

        public Graphics(SpriteDocument document)
        {
            InitializeComponent();

            this.document = document;
            this.comboboxSprites.SelectedIndex = 0;
        }

        private void comboboxSprites_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listviewSprites.Items.Clear();
            this.labelSpriteName.Text = "No Sprite Selected";
            this.textboxDescriptions.Text = "To begin, select a sprite in the list above. Information and properties will be displayed here and in the Properties pane on the right.";
            this.propertygridSprites.SelectedObject = null;
            this.pictureboxSprite.Image = null;

            switch (this.comboboxSprites.SelectedIndex)
            {
                case 0:
                    // Backgrounds
                    foreach (KeyValuePair<int, Sprite> background in this.document.Backgrounds)
                    {
                        ListViewItem backgroundItem = new ListViewItem();
                        backgroundItem.Text = background.Key.ToString();
                        backgroundItem.SubItems.Add(background.Value.Name);

                        this.listviewSprites.Items.Add(backgroundItem);
                    }
                    break;
                case 1:
                    // Tiles and Enemies
                    foreach (KeyValuePair<int, Sprite> sprite in this.document.Sprites)
                    {
                        ListViewItem spriteItem = new ListViewItem();
                        spriteItem.Text = sprite.Key.ToString();
                        spriteItem.SubItems.Add(sprite.Value.Name);

                        this.listviewSprites.Items.Add(spriteItem);
                    }
                    break;
                case 2:
                    // Platform Labels
                    foreach (KeyValuePair<int, Sprite> label in this.document.Labels)
                    {
                        ListViewItem labelItem = new ListViewItem();
                        labelItem.Text = label.Key.ToString();
                        labelItem.SubItems.Add(label.Value.Name);

                        this.listviewSprites.Items.Add(labelItem);
                    }
                    break;
            }
        }

        private void listviewSprites_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Determine if one item has been selected.
            if (listviewSprites.SelectedItems.Count == 1)
            {
                // Determine what type of item it is first.
                this.selectedItem = listviewSprites.SelectedItems[0];
                switch (this.comboboxSprites.SelectedIndex)
                {
                    case 0:
                        this.selectedSprite = this.document.Backgrounds[int.Parse(this.selectedItem.Text)];
                        break;
                    case 1:
                        this.selectedSprite = this.document.Sprites[int.Parse(this.selectedItem.Text)];
                        break;
                    case 2:
                        this.selectedSprite = this.document.Labels[int.Parse(this.selectedItem.Text)];
                        break;
                }

                // Set the controls
                this.labelSpriteName.Text = this.selectedSprite.Name;
                this.textboxDescriptions.Text = this.selectedSprite.Description.Trim();
                this.pictureboxSprite.Image = (Bitmap)this.selectedSprite;
                this.propertygridSprites.SelectedObject = this.selectedSprite;
            }
            else
            {
                this.labelSpriteName.Text = "No Sprite Selected";
                this.textboxDescriptions.Text = "To begin, select a sprite in the list above. Information and properties will be displayed here and in the Properties pane on the right.";
                this.propertygridSprites.SelectedObject = null;
                this.pictureboxSprite.Image = null;
            }
        }

        private void propertygridSprites_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            this.selectedItem.SubItems[1].Text = this.selectedSprite.Name;
            this.labelSpriteName.Text = this.selectedSprite.Name;
            this.textboxDescriptions.Text = this.selectedSprite.Description;
            this.pictureboxSprite.Image = (Bitmap)this.selectedSprite;
        }

        private void Graphics_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save all changes.
            this.document.Save(Application.StartupPath + "/Options/Graphics.xml");
        }
    }
}
