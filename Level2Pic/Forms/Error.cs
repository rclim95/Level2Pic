using System;
using System.Windows.Forms;
using Level2Pic.Library;

namespace Level2Pic.Forms
{
    public partial class Error : Form
    {
        public Error(string code)
        {
            InitializeComponent();

            try
            {
                // Attempt to load the level code specified
                Level level = new Level(code);
                Zone zoneMain = level.Main;
                Zone zoneBonus = level.Bonus;

                // If all go sucessful, load the warnings
                foreach (string warning in level.Warnings)
                {
                    ListViewItem itemWarning = new ListViewItem();
                    itemWarning.Group = this.listviewError.Groups[1];
                    itemWarning.ImageKey = "Warning";
                    itemWarning.Text = warning;
                    this.listviewError.Items.Add(itemWarning);
                }
            }
            catch (Exception ex)
            {
                // Add this as a critical error
                this.listviewError.Items.Add(new ListViewItem()
                {
                    Group = this.listviewError.Groups[0],
                    ImageKey = "Error",
                    Text = ex.Message
                });

            }
        }
    }
}
