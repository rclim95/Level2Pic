// <copyright file="Sprite.cs" company="NZoid154 Softwares">
// Copyright (c) 2010 - 2011
// </copyright>

namespace Level2Pic.Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Xml.Serialization;
    
    /// <summary>
    /// Represents a two-dimensional graphical object that makes a Super Mario Flash level.
    /// </summary>
    [Serializable()]
    [XmlInclude(typeof(Point))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Size))]
    public class Sprite
    {
        /// <summary>
        /// The file path to the image that contains the sprite.
        /// </summary>
        private string filePath = null;

        /// <summary>
        /// The symbols to find and replace.
        /// </summary>
        private Dictionary<string, string> findReplace = new Dictionary<string, string>() { { "$(AppDir)", Path.GetDirectoryName(Assembly.GetCallingAssembly().Location) }, { "$(LibDir)", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) } };

        /// <summary>
        /// The location of the sprite in the image.
        /// </summary>
        private Point location;

        /// <summary>
        /// The size of the sprite in the image.
        /// </summary>
        private Size size;

        /// <summary>
        /// Initializes a new instance of the Sprite class.
        /// </summary>
        public Sprite()
        {
            this.location = new Point();
            this.size = new Size();
        }

        /// <summary>
        /// Gets the bounds of the sprite in the image set.
        /// </summary>
        /// <remarks>
        /// You can set the image to use by using the &quot;ImagePath&quot; property. To set the location and size, see the &quot;Location&quot; and &quot;Size&quot; properties, respectively.
        /// </remarks>
        [Browsable(false)]
        public Rectangle Bounds
        {
            get
            {
                return new Rectangle(this.Location, this.Size);
            }
        }

        /// <summary>
        /// Gets or sets a description that briefly describes the sprite.
        /// </summary>
        [Category("General")]
        [Description("A description that briefly describes the sprite.")]
        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the full image path. This replaces all symbols with its corresponding values.
        /// </summary>
        [Category("Path")]
        [Description("The full path to the image. All symbols have been replaced with their corresponding values.")]
        [DisplayName("Full Path")]
        [ReadOnly(true)]
        public string FullImagePath
        {
            get
            {
                string fullPath = this.ImagePath;
                
                foreach (KeyValuePair<string, string> key in this.findReplace)
                {
                    // Replace all strings
                    fullPath = fullPath.Replace(key.Key, key.Value);
                }

                return fullPath;
            }
        }

        /// <summary>
        /// Gets or sets the path to the image.
        /// </summary>
        [Category("Path")]
        [Description("The path to the image. The image must exist.")]
        [DisplayName("Sprite Path")]
        [Editor(typeof(ImageFileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string ImagePath
        {
            get
            {
                return this.filePath;
            }

            set
            {
                string fullPath = value;

                // Get the full path
                foreach (KeyValuePair<string, string> key in this.findReplace)
                {
                    // Replace all strings
                    fullPath = fullPath.Replace(key.Key, key.Value);
                }

                // Does it exist?
                if (!File.Exists(fullPath))
                {
                    throw new FileNotFoundException();
                }

                this.filePath = value;
            }
        }

        /// <summary>
        /// Gets or sets the location of the sprite in the image.
        /// </summary>
        /// <remarks>
        /// You can set the image to use by using the &quot;ImagePath&quot; property. The location must not be negative and must be within the image set.
        /// </remarks>
        [Category("Display")]
        [DefaultValue(typeof(Point), "0, 0")]
        [Description("The coordinates of the sprite in the image loaded for the sprite. The coordinates must exist within the image.")]
        [DisplayName("Sprite Location")]
        public Point Location
        {
            get
            {
                return this.location;
            }

            set
            {
                if (!this.InsideImage(this.Size, value))
                {
                    throw new Exception("The coordinate is outside the dimensions of the image.");
                }

                this.location = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the sprite.
        /// </summary>
        [Category("General")]
        [Description("The name of the sprite.")]
        [DisplayName("(Name)")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets how the image should be rotated and flipped.
        /// </summary>
        [Category("Display")]
        [Description("The way the image should be rotated and flipped.")]
        [DisplayName("Rotation and Flipping")]
        public RotateFlipType RotateFlip
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the size of the sprite.
        /// </summary>
        /// <remarks>
        /// You can set the image to use by using the &quot;ImagePath&quot; property. The size of the sprite must not be negative, zero (e.g.: (0, 0)), or exceeds the size of the image set.
        /// </remarks>
        [Category("Display")]
        [DefaultValue(typeof(Size), "16, 16")]
        [Description("The size of the sprite. It must not exceed the image loaded for the sprite. It also must not be less than or equal to 0.")]
        [DisplayName("Sprite Size")]
        public Size Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (!this.InsideImage(value, this.Location))
                {
                    throw new Exception("The size is outside the dimensions of the image.");
                }

                this.size = value;
            }
        }

        /// <summary>
        /// Explicitly converts the sprite into a Bitmap.
        /// </summary>
        /// <param name="sprite">The sprite to explicitly convert.</param>
        /// <returns>The sprite as a Bitmap.</returns>
        public static explicit operator Bitmap(Sprite sprite)
        {
            // Make sure the file actually exists.
            if (!File.Exists(sprite.FullImagePath))
            {
                throw new FileNotFoundException("The file could not be found.", sprite.FullImagePath);
            }

            // Continue with the conversion process.
            using (Bitmap image = (Bitmap)Bitmap.FromFile(sprite.FullImagePath))
            {
                Bitmap spriteImage = image.Clone(sprite.Bounds, System.Drawing.Imaging.PixelFormat.DontCare);
                spriteImage.RotateFlip(sprite.RotateFlip);
                return spriteImage;
            }
        }

        /// <summary>
        /// Determines if the coordinate and the size is inside the image. 
        /// </summary>
        /// <param name="size">The size to test..</param>
        /// <param name="location">The location or coordinate to test.</param>
        /// <returns>True if the bounds is in the image; otherwise, false.</returns>
        private bool InsideImage(Size size, Point location)
        {
            // Make sure the file actually exists.
            if (!File.Exists(this.FullImagePath))
            {
                throw new FileNotFoundException("The file could not be found.", this.FullImagePath);
            }

            using (Bitmap image = (Bitmap)Bitmap.FromFile(this.FullImagePath))
            {
                GraphicsUnit unit = GraphicsUnit.Pixel;

                return image.GetBounds(ref unit).Contains(new RectangleF(location.X, location.Y, size.Width, size.Height));
            }
        }
    }
}
