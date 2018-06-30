// <copyright file="LevelArgument.cs" company="NZoid154 Softwares">
// Copyright (c) 2010-2011
// </copyright>

namespace Level2Pic.Library
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Xml.Serialization;

    /// <summary>
    /// Constants that specified the type of backgrounds to use in the &quot;middle&quot; area of a two-zone level map.
    /// </summary>
    public enum BackgroundTypes
    {
        /// <summary>
        /// The default background. It is a blue to light blue linear gradient.
        /// </summary>
        Default,

        /// <summary>
        /// The background is based on an image available on the user's computer.
        /// </summary>
        Image,

        /// <summary>
        /// The background is a solid color
        /// </summary>
        Solid
    }

    /// <summary>
    /// Contains necessary data to tell Level2Pic how to &quot;design&quot; a level map with all zones together (or the whole level)
    /// </summary>
    public class LevelArgument
    {
        /// <summary>
        /// Initializes a new instance of the LevelArgument class with the default values set
        /// </summary>
        public LevelArgument()
        {
            this.AutoSize = true;
            this.Background = BackgroundTypes.Default;
            this.BackgroundColor = Color.White;
            this.Font = new Font("Trebuchet MS", 12f);
            this.FontColor = Color.Black;
        }

        /// <summary>
        /// Initializes a new instance of the LevelArgument class with the default values and level name set
        /// </summary>
        /// <param name="name">The name of the level</param>
        public LevelArgument(string name)
        {
            this.AutoSize = true;
            this.Background = BackgroundTypes.Default;
            this.BackgroundColor = Color.White;
            this.Font = new Font("Trebuchet MS", 12f);
            this.FontColor = Color.Black;
            this.Text = name;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the text middle area should automatically be sized to fit the area
        /// </summary>
        [Category("Description")]
        [DefaultValue(true)]
        [Description("Indicates if the text in the middle area should be sized automatically.")]
        public bool AutoSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the background to use in the area between the Main Zone and the Bonus Zone
        /// </summary>
        [Category("Background")]
        [DefaultValue(typeof(BackgroundTypes), "Default")]
        [Description("The type of background to use in the middle area of the level.")]
        [DisplayName("Background Type")]
        public BackgroundTypes Background
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the solid color to use as the background.
        /// </summary>
        /// <remarks>In order for this to take affect, you must set &quot;Background&quot; to &quot;Solid.&quot;</remarks>
        [Category("Background")]
        [DefaultValue(typeof(Color), "White")]
        [Description("The solid color to use as the background. \"Background Type\" must be set to \"Solid\" in order for this to have an affect.")]
        [DisplayName("Background Color")]
        public Color BackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the picture to use as the background.
        /// </summary>
        /// <remarks>In order for this to take affect, you must set &quot;Background&quot; to &quot;Image.&quot;</remarks>
        [Category("Background")]
        [Description("The picture to use as the background. \"Background Type\" must be set to \"Image\" in order for this to have an affect.")]
        [DisplayName("Background Image")]
        public Image BackgroundImage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the font to use in the middle area of the level map
        /// </summary>
        /// <remarks>The font size will be ignored if you set &quot;AutoSize&quot; to True.</remarks>
        [Category("Description")]
        [DefaultValue(typeof(Font), "Trebuchet MS, 12pt")]
        [Description("The font to use in the middle area of the level map. The font size will be ignored if you set \"AutoSize\" to True.")]
        public Font Font
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the color of the font to use in the middle area of the level map
        /// </summary>
        [Category("Description")]
        [DefaultValue(typeof(Color), "Black")]
        [Description("The color to use on the font in the middle area of the level map.")]
        [DisplayName("Font Color")]
        public Color FontColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text to display in the middle area of the level map
        /// </summary>
        [Category("Description")]
        [Description("The text to display in the middle area of the level map.")]
        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        public string Text
        {
            get;
            set;
        }
    }
}
