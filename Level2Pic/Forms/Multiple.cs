using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Level2Pic.Library;

namespace Level2Pic.Forms
{
    public partial class Multiple : Form
    {
        private string[] levelsLoaded;

        public Multiple(string[] levels)
        {
            InitializeComponent();

            this.levelsLoaded = levels;

            // Add all the multiple levels found into the list
            foreach (string level in levels)
            {
                this.comboboxLevel.Items.Add(new Level(level).Name);
            }
            this.comboboxLevel.SelectedIndex = 0;
        }

        /// <summary>
        /// Get the level to load
        /// </summary>
        public string Level
        {
            get
            {
                return this.textboxCode.Text;
            }
        }

        private void comboboxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textboxCode.Text = this.levelsLoaded[this.comboboxLevel.SelectedIndex];
        }
    }
}
