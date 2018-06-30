// <copyright file="ZoneArgument.cs" company="NZoid154 Softwares">
// Copyright (c) 2010-2011
// </copyright>

namespace Level2Pic.Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Text;
    using System.Xml.Serialization;

    /// <summary>
    /// Contains necessary data to tell Level2Pic how to &quot;design&quot; a level map with one zone
    /// </summary>
    [Serializable()]
    public class ZoneArgument
    {
        /// <summary>
        /// The position to begin cropping the level map
        /// </summary>
        private uint startPosition = 0;

        /// <summary>
        /// The position to stop cropping the level map
        /// </summary>
        private uint endPosition = 0;

        /// <summary>
        /// Initializes a new instance of the ZoneArgument class with its default value
        /// </summary>
        public ZoneArgument()
        {
            this.AutoSize = true;
            this.Color = Color.Black;
            this.Cropping = false;
            this.EndPosition = 0;
            this.Font = new Font("Trebuchet MS", 12f);
            this.Opacity = 255;
            this.StartPosition = 0;
        }

        /// <summary>
        /// Initializes a new instance of the ZoneArgument class with its default value and its label's text set according to the level's name and zone being used
        /// </summary>
        /// <param name="name">The name of the level</param>
        public ZoneArgument(string name)
        {
            this.AutoSize = true;
            this.Color = Color.Black;
            this.Cropping = false;
            this.EndPosition = 0;
            this.Font = new Font("Trebuchet MS", 12f);
            this.Opacity = 255;
            this.StartPosition = 0;
            this.Text = name;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the text of the &quot;label&quot; should be auto-sized to fit the level map
        /// </summary>
        [Category("Label")]
        [DefaultValue(true)]
        [Description("Indicates if the label's text should be auto-sized to fit the level map.")]
        public bool AutoSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the color to use on the label.
        /// </summary>
        [Category("Label")]
        [DefaultValue(typeof(Color), "Black")]
        [Description("The color to use on the label's text.")]
        public Color Color
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the level should be cropped after the map is created
        /// </summary>
        [Category("Cropping")]
        [DefaultValue(false)]
        [Description("Indicates if the level should be cropped after the level map has been made.")]
        [DisplayName("Crop Level")]
        public bool Cropping 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets the position to stop cropping the level
        /// </summary>
        /// <remarks>
        /// The value will automatically be rounded to 20 automatically (screen sizes are usually counted in 20s in Super Mario Flash)
        /// The value must be between 0 and 4,180 or an error will occur.
        /// </remarks>
        [Category("Cropping")]
        [DefaultValue(typeof(uint), "0")]
        [Description("The position to stop cropping the level.")]
        [DisplayName("End Position")]
        public uint EndPosition
        {
            get
            {
                return this.endPosition;
            }

            set
            {
                if (value > 4180)
                {
                    throw new Exception("The number must be less than 4,180.");
                }
                else
                {
                    this.endPosition = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the font to use for the label.
        /// </summary>
        /// <remarks>
        /// Note that if you set &quot;AutoSize&quot; to true, then the font size specified will be ignored.
        /// </remarks>
        [Category("Label")]
        [DefaultValue(typeof(Font), "Trebuchet MS, 12pt")]
        [Description("The font to use for the label. The font size will be ignored if you set \"AutoSize\" to true.")]
        [XmlIgnore()]
        public Font Font
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the opacity of the label.
        /// </summary>
        [Category("Label")]
        [DefaultValue((byte)255)]
        [Description("Indicates how transparent the text of the label is. A higher \"number\" means it is more visible; otherwise, it is less visible.")]
        public byte Opacity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the position to begin cropping the level
        /// </summary>
        /// <remarks>
        /// The value will automatically be rounded to 20 automatically (screen sizes are usually counted in 20s in Super Mario Flash)
        /// The value must be between 0 and 4,180 or an error will occur.
        /// </remarks>
        [Category("Cropping")]
        [DefaultValue(typeof(uint), "0")]
        [Description("The position to start cropping the level.")]
        [DisplayName("Start Position")]
        public uint StartPosition
        {
            get
            {
                return this.startPosition;
            }

            set
            {
                if (value > 4180)
                {
                    throw new Exception("The number must be less than 4,180.");
                }
                else
                {
                    this.startPosition = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the text of the label.
        /// </summary>
        [Category("Label")]
        [Description("The text to use as a label for the level map.")]
        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        public string Text
        {
            get;
            set;
        }
    }
}
