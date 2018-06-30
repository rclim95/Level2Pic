using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Level2Pic.Library;

namespace Level2Pic
{
    public partial class Main : Form
    {
        private ZoneArgument argumentOneZone;
        private LevelArgument argumentTwoZone;
        private Converter converter;
        private string currentCode;
        private Level currentLevel;
        private SpriteDocument document;
        private Classes.Dapper dapperLevel;
        private int previousPanelSize;

        public Main()
        {
            InitializeComponent();

            this.document = new SpriteDocument();
            this.document.Load(Application.StartupPath + "/Options/Graphics.xml");

            this.Text = string.Format("Level2Pic v{0}", new Version(Application.ProductVersion).ToString(2));
        }

        private void CheckLevel(string code)
        {
            // Set the current code
            this.currentCode = code;

            // Attempt to parse it
            Level levelToCheck;
            if (Level.TryParse(code, out levelToCheck))
            {
                this.LoadLevel(levelToCheck);
            }
            else
            {
                // Enable errors and warnings dialog and disable everything else
                this.toolstripmenuSaveMap.Enabled = false;
                this.toolstripmenuCopy.Enabled = false;
                this.toolstripmenuRender.Enabled = false;
                this.toolstripmenuLevelProperties.Enabled = false;
                this.toolstripbuttonProperties.Enabled = false;
                this.toolstripbuttonRender.Enabled = false;
                this.toolstripbuttonSave.Enabled = false;
                this.toolstripbuttonCopy.Enabled = false;
                this.splitcontainerMain.Panel1.Enabled = false;

                this.pictureboxMain.Image = null;
                this.toolstripmenuErrors.Enabled = true;
                this.toolstripbuttonErrors.Enabled = true;
                this.toolstripbuttonErrors.Text = string.Format("Error List ({0:N})", 1);
                this.labelStatus.Text = "Error validating level. Check the \"Error\" dialog for more information.";
            }
        }

        private void comboboxAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboboxAreas.SelectedIndex == 0)
            {
                this.propertygridMap.SelectedObject = this.argumentTwoZone;
                this.argumentTwoZone.Text = (this.argumentTwoZone.Text == null) ? this.currentLevel.Name : this.argumentTwoZone.Text;
            }
            else
            {
                this.propertygridMap.SelectedObject = this.argumentOneZone;
                this.argumentOneZone.Text = (this.argumentOneZone.Text == null) ? this.currentLevel.Name : this.argumentOneZone.Text;
            }

            // TODO: Do some rendering here
        }

        private void LoadLevel(Level level)
        {
            this.currentLevel = level;

            // Enable controls
            this.toolstripmenuRender.Enabled = true;
            this.toolstripmenuLevelProperties.Enabled = true;
            this.toolstripbuttonProperties.Enabled = true;
            this.toolstripbuttonRender.Enabled = true;
            this.splitcontainerMain.Panel1.Enabled = true;

            // Reset values
            this.argumentOneZone = new ZoneArgument();
            this.argumentTwoZone = new LevelArgument();
            this.comboboxAreas.SelectedIndex = Properties.Settings.Default.DefaultSelection;
            
            // Has warnings?
            if (level.Warnings.Length > 0)
            {
                this.toolstripmenuErrors.Enabled = true;
                this.toolstripbuttonErrors.Enabled = true;
                this.toolstripbuttonErrors.Text = this.toolstripbuttonErrors.Text = string.Format("&Error List ({0:N})", level.Warnings.Length);
                this.labelStatus.Text = string.Format("Loaded \"{0}\" sucessfully with {1:N} warnings", level.Name.Replace(Environment.NewLine, string.Empty), level.Warnings.Length);
            }
            else
            {
                this.toolstripmenuErrors.Enabled = false;
                this.toolstripbuttonErrors.Enabled = false;
                this.toolstripbuttonErrors.Text = "&Error List (0)";
                this.labelStatus.Text = string.Format("Loaded \"{0}\" sucessfully", level.Name.Replace(Environment.NewLine, string.Empty));
            }

            this.Text = string.Format("{0} - Level2Pic v{1}", this.currentLevel.Name, new Version(Application.ProductVersion).ToString(2));
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the converter is null and check if the converter is busy.
            if (this.converter != null && this.converter.IsBusy)
            {
                MessageBox.Show("Level2Pic is currently working on a level map. You must cancel the operation in order to exit Level2Pic.", "Level2Pic: Operation in Progress", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void panelPicture_SizeChanged(object sender, EventArgs e)
        {
            // Center the control
            this.pictureboxMain.Top = (this.pictureboxMain.Parent.Height - this.pictureboxMain.Height) / 2;
        }

        private void pictureboxMain_SizeChanged(object sender, EventArgs e)
        {
            // Center the control
            this.pictureboxMain.Top = (this.pictureboxMain.Parent.Height - this.pictureboxMain.Height) / 2;
        }

        private void toolstripmenuErrors_Click(object sender, EventArgs e)
        {
            new Forms.Error(this.currentCode).ShowDialog();
        }

        private void toolstripmenuLevelProperties_Click(object sender, EventArgs e)
        {
            if (this.dapperLevel == null)
            {
                new Forms.Information(this.currentLevel, this.document).ShowDialog();
            }
            else
            {
                new Forms.Information(this.dapperLevel, this.document).ShowDialog();
            }
        }

        private void toolstripmenuLoad_Click(object sender, EventArgs e)
        {
            Forms.Load loadDialog = new Forms.Load();
            if (loadDialog.ShowDialog() == DialogResult.OK)
            {
                // Get what type of code we're loading
                if (loadDialog.FromWebsite == false)
                {
                    this.dapperLevel = null;
                    this.CheckLevel(loadDialog.Levels[0]);
                }
                else
                {
                    // From the Dapper?
                    if (loadDialog.IsDapper)
                    {
                        this.dapperLevel = new Classes.Dapper(loadDialog.WebsiteSource);
                        this.CheckLevel(this.dapperLevel.Code);
                    }
                    else
                    {
                        this.dapperLevel = null;
                        
                        // Determine if there are multiple levels
                        if (loadDialog.Levels.Length > 1)
                        {
                            // Initialize the Multiple dialog to determine the level the user wants to load
                            Forms.Multiple multiple = new Forms.Multiple(loadDialog.Levels);
                            if (multiple.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                this.CheckLevel(multiple.Level);
                            }
                        }
                        else
                        {
                            this.CheckLevel(loadDialog.Levels[0]);
                        }
                    }
                }
            }
        }

        private void toolstripmenuManageGraphics_Click(object sender, EventArgs e)
        {
            new Forms.Graphics(this.document).Show();
        }

        private void toolstripmenuOptions_Click(object sender, EventArgs e)
        {
            new Forms.Options().ShowDialog();
        }

        private void toolstripmenuProperty_Click(object sender, EventArgs e)
        {
            if (this.toolstripmenuProperty.Checked)
            {
                this.splitcontainerMain.SplitterDistance = this.previousPanelSize;
            }
            else
            {
                this.previousPanelSize = this.splitcontainerMain.SplitterDistance;
                this.splitcontainerMain.SplitterDistance = 0;
            }
        }

        private void toolstripmenuRender_Click(object sender, EventArgs e)
        {
            // Disable controls that may cause trouble
            this.toolstripmenuLoad.Enabled = false;
            this.toolstripbuttonLoad.Enabled = false;
            this.toolstripmenuSaveMap.Enabled = false;
            this.toolstripbuttonSave.Enabled = false;
            this.toolstripmenuCopy.Enabled = false;
            this.toolstripbuttonCopy.Enabled = false;
            this.toolstripmenuRender.Enabled = false;
            this.toolstripmenuStopRender.Enabled = true;
            this.splitcontainerMain.Panel1.Enabled = false;

            // Set up the render button
            this.toolstripbuttonRender.Image = Properties.Resources.Stop;
            this.toolstripbuttonRender.Text = "&Stop Rendering";

            // Set up the progress bar
            this.labelStatus.BorderSides = ToolStripStatusLabelBorderSides.Right;
            this.progressbarStatus.Visible = true;

            // Begin converting
            DateTime startTime = DateTime.Now;
            this.converter = new Converter(this.currentLevel, this.document);
            this.converter.ProgressChanged += delegate(object s, ProgressChangedEventArgs args)
            {
                this.labelStatus.Text = string.Format("Drawing level map... {0:##}% complete", args.ProgressPercentage);
                this.progressbarStatus.Value = args.ProgressPercentage;
            };
            this.converter.Completed += delegate(object s, CompletedEventArgs args)
            {
                // Enable controls
                this.toolstripmenuLoad.Enabled = true;
                this.toolstripbuttonLoad.Enabled = true;
                this.toolstripmenuSaveMap.Enabled = true;
                this.toolstripbuttonSave.Enabled = true;
                this.toolstripmenuCopy.Enabled = true;
                this.toolstripbuttonCopy.Enabled = true;
                this.toolstripmenuRender.Enabled = true;
                this.toolstripmenuStopRender.Enabled = false;
                this.splitcontainerMain.Panel1.Enabled = true;

                // Set up the render button
                this.toolstripbuttonRender.Image = Properties.Resources.Render;
                this.toolstripbuttonRender.Text = "&Render Level";

                // Set up the progress bar
                this.labelStatus.BorderSides = ToolStripStatusLabelBorderSides.None;
                this.progressbarStatus.Visible = false;

                // Pass or fail?
                if (args.Cancelled)
                {
                    this.labelStatus.Text = "Task canceled.";
                }
                else if (args.Error == null)
                {
                    TimeSpan endTime = DateTime.Now.Subtract(startTime);
                    this.labelStatus.Text = string.Format("Finish in {0:##}.{1:###} second(s)", endTime.Seconds, endTime.Milliseconds);
                    this.pictureboxMain.Image = args.Result;
                }
                else
                {
                    this.labelStatus.Text = "Error rendering level map. " + args.Error.Message;
                }
            };

            // What are we converting?
            switch (this.comboboxAreas.SelectedIndex)
            {
                case 0:
                    // Both Zone
                    this.converter.ConvertAsync(this.argumentTwoZone);
                    break;
                case 1:
                    // Main Zone
                    this.converter.ConvertAsync(Zones.Main, this.argumentOneZone);
                    break;
                case 2:
                    // Bonus Zone
                    this.converter.ConvertAsync(Zones.Bonus, this.argumentOneZone);
                    break;
            }
        }

        private void toolstripmenuStandard_Click(object sender, EventArgs e)
        {
            this.toolstripStandard.Visible = this.toolstripmenuStandard.Checked;
        }

        private void toolstripmenuStatusBar_Click(object sender, EventArgs e)
        {
            this.statusMain.Visible = this.toolstripmenuStatusBar.Checked;
        }

        private void toolstripmenuStopRender_Click(object sender, EventArgs e)
        {
            // Cancel
            this.labelStatus.Text = "Canceling...";
            this.converter.CancelAsync();
        }
    }
}
