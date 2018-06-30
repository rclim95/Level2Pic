using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using HtmlAgilityPack;
using Level2Pic.Library;
using System.Collections.Generic;

namespace Level2Pic.Forms
{
    public partial class Load : Form
    {
        private WebClient downloader = new WebClient();

        public Load()
        {
            InitializeComponent();

            // WebClient: UploadStringCompleted
            this.downloader.UploadStringCompleted += delegate(object s, UploadStringCompletedEventArgs e)
            {
                if (e.Cancelled == true)
                {
                    this.buttonCancel.Text = "&Close";
                    this.EnableControls(true);
                    return;
                }
                else if (e.Error != null)
                {
                    this.buttonCancel.Text = "&Close";
                    this.EnableControls(true);
                    MessageBox.Show("Unable to download the requested website. The following error had occured:\n\n" + e.Error.Message, "Level2Pic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.labelGetCode.Text = "Reading website's source for level codes... Please wait.";

                    // Is this Dapper?
                    if (this.IsDapper == true)
                    {
                        Classes.Dapper dapper = new Classes.Dapper(e.Result);

                        // Make sure the Dapper doesn't report any errors
                        if (dapper.Error != null)
                        {
                            this.buttonCancel.Text = "&Close";
                            this.EnableControls(true);
                            MessageBox.Show("Unable to obtain the level code from Pouetpu-Games. The service used to retrieve the webpage gave the following error:\n\n" + dapper.Error.Message, "Level2Pic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument(); 
                        html.LoadHtml(e.Result);
                       
                        // Are there any levels?
                        if ((html.DocumentNode.SelectNodes("//textarea") == null) || (html.DocumentNode.SelectNodes("//textarea").Count == 0))
                        {
                            this.buttonCancel.Text = "&Close";
                            MessageBox.Show("Unable to find any levels. Level2Pic did not locate any \"textarea\" tags in the website's source.", "Level2Pic: No Code Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.EnableControls(true);
                            return;
                        }
                        else
                        {
                            List<string> codes = new List<string>();
                            foreach (HtmlNode textarea in html.DocumentNode.SelectNodes("//textarea"))
                            {
                                // Parse all "levels" found and see if it's valid
                                Level levelToParse;
                                if (Level.TryParse(HttpUtility.HtmlDecode(textarea.InnerText), out levelToParse))
                                {
                                    codes.Add(HttpUtility.HtmlDecode(textarea.InnerText));
                                }
                            }

                            // If there's no valid level, then return
                            if (codes.Count == 0)
                            {
                                this.buttonCancel.Text = "&Close";
                                MessageBox.Show("Unable to find any levels. Level2Pic did not find any valid level code inside the \"textarea\" tags in the website's source.", "Level2Pic: No Code Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.EnableControls(true);
                                return;
                            }
                            else
                            {
                                this.Levels = codes.ToArray();
                            }
                        }
                    }

                    this.WebsiteSource = e.Result;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            };
        }

        /// <summary>
        /// Gets a value indicating whether the code is coming from a website
        /// </summary>
        public bool FromWebsite
        {
            get
            {
                return this.radiobuttonInternet.Checked;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the source type is Dapper-styled
        /// </summary>
        public bool IsDapper
        {
            get;
            private set;
        }


        /// <summary>
        /// Gets the level code
        /// </summary>
        public string[] Levels
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the website's source
        /// </summary>
        public string WebsiteSource
        {
            get;
            private set;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Downloader busy?
            if (downloader.IsBusy)
            {
                // Cancel
                this.downloader.CancelAsync();
                this.buttonCancel.Text = "&Close";
            }
            else
            {
                // Close dialog
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.radiobuttonCode.Checked)
            {
                if (this.textboxCode.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("You must enter a level code in order to continue.", "Level2Pic: Level Code Required");
                    return;
                }
                else
                {
                    this.Levels = new string[] { this.textboxCode.Text };
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                Uri websiteToParse;

                if (this.textboxWebsite.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("You must enter a website's URL in order to continue.", "Level2Pic: Website Reauired");
                    return;
                }

                if (!Uri.TryCreate(this.textboxWebsite.Text, UriKind.Absolute, out websiteToParse))
                {
                    MessageBox.Show("The website you have entered is not in an absolute format (e.g., http://www.example.com/).", "Level2Pic: Invalid URL");
                    return;
                }

                this.labelGetCode.Text = "Downloading website's source... Please wait.";
                this.buttonCancel.Text = "&Cancel";
                this.EnableControls(false);
                this.GetCode();
            }
        }

        private void EnableControls(bool enabled)
        {
            foreach (Control control in this.Controls)
            {
                if ((control.Name != "labelGetCode") && (control.Name != "buttonCancel"))
                {
                    control.Enabled = enabled;
                }
            }

            if (enabled)
            {
                // Enable or disable the radio buttons accordingly
                this.radiobuttonMethods_CheckedChanged(new object(), new EventArgs());
            }

            // Show the labelGetCode accordingly
            this.labelGetCode.Visible = !enabled;
        }

        private void GetCode()
        {
            Regex regexURL = new Regex("http://(www\\.|)pouetpu-games\\.(com|net)/(index.php|)\\?section=4&id=[0-9]+");

            if (regexURL.Match(this.textboxWebsite.Text).Success)
            {
                this.IsDapper = true;
                this.downloader.UploadStringAsync(new Uri(string.Format("http://open.dapper.net/RunDapp?dappName=Pouetpugames&v=1&applyToUrl={0}", HttpUtility.UrlEncode(regexURL.Match(this.textboxWebsite.Text).Value)), UriKind.Absolute), string.Empty);
            }
            else
            {
                this.IsDapper = false;
                this.downloader.UploadStringAsync(new Uri(this.textboxWebsite.Text, UriKind.RelativeOrAbsolute), string.Empty);
            }
        }

        private void Load_Activated(object sender, EventArgs e)
        {
            // Detect if the code box or the website box have been given focused. If not, then determine who should focus be given to.
            if ((this.textboxCode.Focused == false) && (this.textboxCode.Focused == false))
            {
                if (this.radiobuttonCode.Checked)
                {
                    this.textboxCode.Focus();
                }
                else
                {
                    this.textboxWebsite.Focus();
                }
            }
        }

        private void radiobuttonMethods_CheckedChanged(object sender, EventArgs e)
        {
            // Determine what's being checked
            if (radiobuttonCode.Checked == true)
            {
                this.labelCode.Enabled = true;
                this.labelCodeMessage.Enabled = true;
                this.textboxCode.Enabled = true;
                this.labelInternetMessage.Enabled = false;
                this.labelWebsite.Enabled = false;
                this.textboxWebsite.Enabled = false;

                this.textboxCode.SelectAll();
                this.textboxCode.Focus();
            }
            else
            {
                this.labelCode.Enabled = false;
                this.labelCodeMessage.Enabled = false;
                this.textboxCode.Enabled = false;
                this.labelInternetMessage.Enabled = true;
                this.labelWebsite.Enabled = true;
                this.textboxWebsite.Enabled = true;

                this.textboxWebsite.SelectAll();
                this.textboxWebsite.Focus();
            }
        }
    }
}
