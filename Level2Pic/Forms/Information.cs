using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Level2Pic.Library;

namespace Level2Pic.Forms
{
    public partial class Information : Form
    {
        private Classes.ListViewColumnSorter lvwColumnSorter;
        private SpriteDocument documentLoaded;
        private Level levelLoaded;        
        
        private delegate void CodeCallback(Level level);
        private delegate void CounterCallback(SpriteDocument document, Level level);

        public Information(Level level, SpriteDocument document)
        {
            InitializeComponent();

            this.lvwColumnSorter = new Classes.ListViewColumnSorter();
            this.listviewCount.ListViewItemSorter = lvwColumnSorter;
            this.documentLoaded = document;
            this.levelLoaded = level;
            this.tabcontrolMain.TabPages.Remove(this.tabpageInternet);
            this.Text = string.Format("{0} Properties", level.Name);
            this.SetLevelInfo(level);
        }

        public Information(Classes.Dapper dapper, SpriteDocument document)
        {
            InitializeComponent();

            this.lvwColumnSorter = new Classes.ListViewColumnSorter();
            this.listviewCount.ListViewItemSorter = lvwColumnSorter;
            this.documentLoaded = document;
            this.levelLoaded = new Level(dapper.Code);
            this.Text = string.Format("{0} Properties", this.levelLoaded.Name);
            this.SetLevelInfo(this.levelLoaded);

            // Set the Pouetpu-Games information
            this.labelAverageRatingValue.Text = string.Format("{0:P} ({1:N}/20)", dapper.Ratings, dapper.Ratings * 20);
            this.labelDatePublishedValue.Text = dapper.Published.ToLongDateString();
            this.labelStatusValue.Text = dapper.Status;
            this.labelViewsValue.Text = string.Format("{0:N} view(s)", dapper.Views);
            this.labelVotesValue.Text = string.Format("{0:N} vote(s)", dapper.Votes);
            this.linkAuthorValue.Links[0].LinkData = dapper.AuthorUri.ToString();
            this.linkAuthorValue.Text = dapper.Author;
            this.linkOnlineNameValue.Links[0].LinkData = dapper.Uri.ToString();
            this.linkOnlineNameValue.Text = dapper.Name;
            this.textboxDescription.Text = dapper.Description;
        }

        public Level Code
        {
            get
            {
                return levelLoaded;
            }
        }


        private void backgroundworkerCode_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Level level = this.levelLoaded;
            SpriteDocument document = this.documentLoaded;

            this.Invoke(new CodeCallback(this.SetLevelCode), new object[] { level });
            this.Invoke(new CounterCallback(this.SetCounter), new object[] { document, level });
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            this.textboxLevelCode.SelectAll();
            this.textboxLevelCode.Copy();
            this.textboxLevelCode.Focus();

            MessageBox.Show("The level code have been copied to your computer's clipboard.", "Level2Pic: Level Code Copied");
        }

        private void comboboxBonusBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.levelLoaded.Bonus.Background = (Backgrounds)(this.comboboxBonusBackground.SelectedIndex + 1);
        }

        private void comboboxBonusMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.levelLoaded.Bonus.Music = (Musics)(this.comboboxBonusMusic.SelectedIndex);
        }

        private void comboboxMainBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.levelLoaded.Main.Background = (Backgrounds)(this.comboboxMainBackground.SelectedIndex + 1);
        }

        private void comboboxMainMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.levelLoaded.Main.Music = (Musics)(this.comboboxMainMusic.SelectedIndex);
        }

        private void linkLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Level2Pic could load the requested webpage because the following error had occured:\n\n" + ex.Message, "Level2Pic: Couldn't Launch Link", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listviewCount_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listviewCount.Sort();
        }

        private void numericBonusLength_ValueChanged(object sender, EventArgs e)
        {
            this.numericBonusLength.Value = Math.Round((this.numericBonusLength.Value / 20)) * 20;
            this.levelLoaded.Bonus.Length = (int)this.numericBonusLength.Value + 320;
            this.labelBonusPixel.Text = string.Format("screen(s) wide ({0:N} pixel(s))", this.levelLoaded.Bonus.Length);
        }
        
        private void numericMainLength_ValueChanged(object sender, EventArgs e)
        {
            this.numericMainLength.Value = Math.Round((this.numericMainLength.Value / 20)) * 20;
            this.levelLoaded.Main.Length = (int)this.numericMainLength.Value + 320;
            this.labelMainPixel.Text = string.Format("screen(s) wide ({0:N} pixel(s))", this.levelLoaded.Main.Length);
        }

        private void SetCounter(SpriteDocument document, Level level)
        {
            // Has it been set already?
            if (this.listviewCount.Items.Count == 0)
            {
                foreach (KeyValuePair<int, int> sprite in level.Count)
                {
                    ListViewItem spriteItem = new ListViewItem();

                    spriteItem.Text = this.documentLoaded.Sprites[sprite.Key].Name;
                    spriteItem.SubItems.Add(sprite.Value.ToString("N"));
                    spriteItem.SubItems.Add(((float)sprite.Value / 5400F).ToString("0.##%"));
                
                    this.listviewCount.Items.Add(spriteItem);
                }
            }
        }

        private void SetLevelCode(Level level)
        {
            this.textboxLevelCode.Text = "Please wait while Level2Pic loads the level code...";
            this.textboxLevelCode.Text = level.ToCode();
        }

        private void SetLevelInfo(Level level)
        {
            this.textboxName.Text = level.Name;

            this.comboboxMainBackground.SelectedIndex = (int)level.Main.Background - 1;
            this.comboboxMainMusic.SelectedIndex = (int)level.Main.Music;
            this.numericMainLength.Value = level.Main.Length - 320;
            this.labelMainPixel.Text = string.Format(this.labelMainPixel.Text, level.Main.Length);

            this.comboboxBonusBackground.SelectedIndex = (int)level.Bonus.Background - 1;
            this.comboboxBonusMusic.SelectedIndex = (int)level.Bonus.Music;
            this.numericBonusLength.Value = level.Bonus.Length - 320;
            this.labelBonusPixel.Text = string.Format(this.labelBonusPixel.Text, level.Bonus.Length);
        }

        private void tabcontrolMain_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == this.tabpageCode)
            {
                this.backgroundworkerCode.RunWorkerAsync();
            }
        }

        private void textboxName_TextChanged(object sender, EventArgs e)
        {
            // Make sure parentheseses aren't found (they mess up the level)
            if (Regex.Matches(this.textboxName.Text, "(\\(|\\)|,)").Count > 0)
            {
                MessageBox.Show("The name you have specified is invalid because it contains parentheses or commas. Remove all traces of parentheses and commas and try again.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textboxName.SelectAll();
                this.textboxName.Focus();
            }
            else
            {
                this.levelLoaded.Name = this.textboxName.Text;
            }
        }
    }
}
