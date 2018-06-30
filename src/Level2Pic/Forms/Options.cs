using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Level2Pic.Library;

namespace Level2Pic.Forms
{
    public partial class Options : Form
    {
        private string imagePath = string.Empty;
        private LevelArgument levelArguments;
        private ZoneArgument zoneArguments;

        public Options()
        {
            InitializeComponent();

            this.levelArguments = new LevelArgument();
            this.zoneArguments = new ZoneArgument();
            this.GetSettings();

            this.comboboxDefaultSelection.SelectedIndex = Properties.Settings.Default.DefaultSelection;
            this.comboboxZone.SelectedIndex = 0;
            this.propertygridArguments.SelectedObject = this.levelArguments;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void comboboxZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the property grid
            switch (this.comboboxZone.SelectedIndex)
            {
                case 0:
                    this.propertygridArguments.SelectedObject = this.levelArguments;
                    break;
                case 1:
                    this.propertygridArguments.SelectedObject = this.zoneArguments;
                    break;
            }
        }

        private Bitmap DecodeBitmap(byte[] bitmap)
        {
            using (MemoryStream stream = new MemoryStream(bitmap))
            {
                return new Bitmap(stream);
            }
        }

        private byte[] EncodeBitmap(Bitmap bitmap)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                return stream.ToArray();
            }
        }

        private void GetSettings()
        {
            // Levels
           this.levelArguments.AutoSize = Level2Pic.Options.Arguments.Default.Level_AutoSize;
           this.levelArguments.Background = (BackgroundTypes)Enum.Parse(typeof(BackgroundTypes), Level2Pic.Options.Arguments.Default.Level_Background);
           this.levelArguments.BackgroundColor = Level2Pic.Options.Arguments.Default.Level_BackgroundColor;
           // this.levelArguments.BackgroundImage = this.DecodeBitmap(Level2Pic.Options.Arguments.Default.Level_BackgroundImagePath.Split();
           this.levelArguments.Font = Level2Pic.Options.Arguments.Default.Level_Font;
           this.levelArguments.FontColor = Level2Pic.Options.Arguments.Default.Level_FontColor;
           this.levelArguments.Text = Level2Pic.Options.Arguments.Default.Level_Text;
           
           // Zones
           this.zoneArguments.AutoSize = Level2Pic.Options.Arguments.Default.Zone_AutoSize;
           this.zoneArguments.Color = Level2Pic.Options.Arguments.Default.Zone_Color;
           this.zoneArguments.Cropping = Level2Pic.Options.Arguments.Default.Zone_Cropping;
           this.zoneArguments.EndPosition = Level2Pic.Options.Arguments.Default.Zone_EndPosition;
           this.zoneArguments.Font = Level2Pic.Options.Arguments.Default.Zone_Font;
           this.zoneArguments.Opacity = Level2Pic.Options.Arguments.Default.Zone_Opacity;
           this.zoneArguments.StartPosition = Level2Pic.Options.Arguments.Default.Zone_StartPosition;
           this.zoneArguments.Text = Level2Pic.Options.Arguments.Default.Zone_Text;
        }

        private void propertygridArguments_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            this.SetSettings();
        }

        private void SetSettings()
        {
            // Levels
            Level2Pic.Options.Arguments.Default.Level_AutoSize = this.levelArguments.AutoSize;
            Level2Pic.Options.Arguments.Default.Level_Background = this.levelArguments.Background.ToString();
            Level2Pic.Options.Arguments.Default.Level_BackgroundColor = this.levelArguments.BackgroundColor;
            // Level2Pic.Options.Arguments.Default.Level_BackgroundImagePath = this.imagePath;
            Level2Pic.Options.Arguments.Default.Level_Font = this.levelArguments.Font;
            Level2Pic.Options.Arguments.Default.Level_FontColor = this.levelArguments.FontColor;
            Level2Pic.Options.Arguments.Default.Level_Text = this.levelArguments.Text;

            // Zones
            Level2Pic.Options.Arguments.Default.Zone_AutoSize = this.zoneArguments.AutoSize;
            Level2Pic.Options.Arguments.Default.Zone_Color = this.zoneArguments.Color;
            Level2Pic.Options.Arguments.Default.Zone_Cropping = this.zoneArguments.Cropping;
            Level2Pic.Options.Arguments.Default.Zone_EndPosition = this.zoneArguments.EndPosition;
            Level2Pic.Options.Arguments.Default.Zone_Font = this.zoneArguments.Font;
            Level2Pic.Options.Arguments.Default.Zone_Opacity = this.zoneArguments.Opacity;
            Level2Pic.Options.Arguments.Default.Zone_StartPosition = this.zoneArguments.StartPosition;
            Level2Pic.Options.Arguments.Default.Zone_Text = this.zoneArguments.Text;
        }
    }
}
