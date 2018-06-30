// <copyright company="NZoid154 Softwares" file="Converter.cs">
// Copyright (c) 2010 - 2011
// </copyright>

namespace Level2Pic.Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    
    /// <summary>
    /// Provides access to methods that allows the creation of a Super Mario Flash v3.0 level map.
    /// </summary>
    public partial class Converter
    {
        /// <summary>
        /// The size of a small block Level2Pic will use.. This constant represents both the height and width.
        /// </summary>
        private const int BlockSize = 16;

        /// <summary>
        /// The height of the description area when converting two level maps.
        /// </summary>
        private const int DescriptionHeight = 96;

        /// <summary>
        /// The maximum amount of tiles to store into the Cache folder.
        /// </summary>
        private const int MaximumTile = 10;

        /// <summary>
        /// The height of an average Super Mario Flash level.
        /// </summary>
        private const int LevelHeight = 12;

        /// <summary>
        /// The width of an average Super Mario Flash level.
        /// </summary>
        private const int LevelWidth = 225;

        /// <summary>
        /// A value indicating whether the converter is busy.
        /// </summary>
        private bool busy = false;

        /// <summary>
        /// A value indicating whether the operation is being canceled.
        /// </summary>
        private bool canceling = false;

        /// <summary>
        /// The level currently loaded.
        /// </summary>
        private Level level;

        /// <summary>
        /// Called when completion needs to be reported.
        /// </summary>
        private SendOrPostCallback onCompletedDelegate;

        /// <summary>
        /// Called when progress needs to be reported.
        /// </summary>
        private SendOrPostCallback onProgressReportDelegate;

        /// <summary>
        /// The asynchronous operation's state.
        /// </summary>
        private object syncState = new object();

        /// <summary>
        /// A document that contains the list of necessary sprites.
        /// </summary>
        private SpriteDocument sprites;

        /// <summary>
        /// The storage path of Level2Pic.
        /// </summary>
        private string storagePath = string.Empty;

        /// <summary>
        /// Initializes a new instance of the Converter class.
        /// </summary>
        /// <param name="level">The level to turn into a level map.</param>
        /// <param name="document">A document that contains all the necessary level tiles to create a level map.</param>
        public Converter(Level level, SpriteDocument document)
        {
            this.InitializeDelegates();
            this.busy = false;
            this.level = level;
            this.sprites = document;
            this.storagePath = string.Format("{1}{0}{2}{0}", Path.DirectorySeparatorChar, Path.GetTempPath(), "Level2Pic Storage");
            this.InitializeDirectory(string.Format("{1}Cache{0}", Path.DirectorySeparatorChar, this.storagePath));
        }

        /// <summary>
        /// Represents the method that will handle the Level2Pic.Library.Converter.ProgressChanged event of a Level2Pic.Library.Converter.
        /// </summary>
        /// <param name="sender">The object that called the event.</param>
        /// <param name="e">The arguments for the event.</param>
        public delegate void CompletedEventHandler(object sender, CompletedEventArgs e);

        /// <summary>
        /// Represents the method that will handle the Level2Pic.Library.Converter.ProgressChanged event of a Level2Pic.Library.Converter.
        /// </summary>
        /// <param name="sender">The object that called the event.</param>
        /// <param name="e">The arguments for the event.</param>
        public delegate void ProgressChangedEventHandler(object sender, ProgressChangedEventArgs e);

        /// <summary>
        /// Represents the method that will be called to start the converter to convert one zone.
        /// </summary>
        /// <param name="zone">The zone to convert.</param>
        /// <param name="argument">Arguments that specifies how the converter will create the level map.</param>
        /// <param name="asyncOp">The async operation which will be used to track the lifetime of the asynchronous operation.</param>
        private delegate void ZoneConverterEventHandler(Zones zone, ZoneArgument argument, AsyncOperation asyncOp);

        /// <summary>
        /// Represents the method that will be called to start the converter to convert all zones.
        /// </summary>
        /// <param name="argument">Arguments that specifies how the converter will create the level map.</param>
        /// <param name="asyncOp">The async operation which will be used to track the lifetime of the asynchronous operation.</param>
        private delegate void LevelConverterEventHandler(LevelArgument argument, AsyncOperation asyncOp);

        /// <summary>
        /// Occus when the converter have sucessfully or failed to convert the level into a level map.
        /// </summary>
        public event CompletedEventHandler Completed;

        /// <summary>
        /// Occurs when the converter's progress has changed.
        /// </summary>
        public event ProgressChangedEventHandler ProgressChanged;

        /// <summary>
        /// Gets a value indicating whether an asynchronous operation is running and is currently busy.
        /// </summary>
        public bool IsBusy
        {
            get
            {
                return this.busy;
            }
        }

        /// <summary>
        /// Draw a level map based on the zone selected and the arguments specified.
        /// </summary>
        /// <param name="zone">The zone to draw.</param>
        /// <param name="argument">Arguments that specify how the converter will draw the zone.</param>
        public void ConvertAsync(Zones zone, ZoneArgument argument)
        {
            AsyncOperation asyncOp = AsyncOperationManager.CreateOperation(new Guid());

            if (this.IsBusy)
            {
                throw new InvalidOperationException("The converter is currently busy.");
            }

            // Begin
            this.busy = true;
            ZoneConverterEventHandler convertDelegate = new ZoneConverterEventHandler(this.ConvertWorker);
            convertDelegate.BeginInvoke(zone, argument, asyncOp, null, null);          
        }

        /// <summary>
        /// Draw a level map of the whole level.
        /// </summary>
        /// <param name="argument">Arguments that specify how the converter will draw the zone.</param>
        public void ConvertAsync(LevelArgument argument)
        {
            AsyncOperation asyncOp = AsyncOperationManager.CreateOperation(new Guid());

            if (this.IsBusy)
            {
                throw new InvalidOperationException("The converter is currently busy.");
            }

            // Begin
            this.busy = true;
            LevelConverterEventHandler convertDelegate = new LevelConverterEventHandler(this.ConvertWorker);
            convertDelegate.BeginInvoke(argument, asyncOp, null, null);
        }

        /// <summary>
        /// Cancel the asynchronous operation.
        /// </summary>
        public void CancelAsync()
        {
            this.canceling = true;
        }

        /// <summary>
        /// Initializes a new instance of delegates.
        /// </summary>
        protected void InitializeDelegates()
        {
           this.onCompletedDelegate = new SendOrPostCallback(this.ConverterCompleted);
           this.onProgressReportDelegate = new SendOrPostCallback(this.ReportProgress);
        }

        /// <summary>
        /// Raises the Level2Pic.Library.Converter.Completed event.
        /// </summary>
        /// <param name="e">Arguments for the event.</param>
        protected virtual void OnCompleted(CompletedEventArgs e)
        {
            if (this.Completed != null)
            {
                this.Completed(this, e);
            }
        }

        /// <summary>
        /// Raises the Level2Pic.Library.Converter.ProgressChanged event.
        /// </summary>
        /// <param name="e">Arguments for the event.</param>
        protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
        {
            if (this.ProgressChanged != null)
            {
                this.ProgressChanged(this, e);
            }
        }

        /// <summary>
        /// Method called for handling asychronous operation completion. This is the method that the underlying, free-threaded aysnchronous behavior will invoke. This will happen on an arbitrary thread.
        /// </summary>
        /// <param name="map">A picture of the level map.</param>
        /// <param name="exception">Any exceptions that had occured while the operation was operating.</param>
        /// <param name="canceled">A value indicating whether the opreation was canceled by the user.</param>
        /// <param name="asyncOp">The asynchronous operation.</param>
        private void CompletionMethod(Bitmap map, Exception exception, bool canceled, AsyncOperation asyncOp)
        {
            CompletedEventArgs e = new CompletedEventArgs(exception, canceled, asyncOp.UserSuppliedState)
            {
                Result = map
            };

            // Let the asyncOp marshall the call for completion.
            this.busy = false;
            asyncOp.PostOperationCompleted(this.onCompletedDelegate, e);
        }

        /// <summary>
        /// This method is invoked via the AsyncOperation object, so it is guaranteed to be executed on the correct thread.
        /// </summary>
        /// <param name="operationState">The state of the operation.</param>
        private void ConverterCompleted(object operationState)
        {
            CompletedEventArgs e = (CompletedEventArgs)operationState;
            this.OnCompleted(e);
        }

        /// <summary>
        /// Initialize the directory for storing images and begin caching tiles that are often used.
        /// </summary>
        /// <param name="cachePath">The path to store temporary images.</param>
        private void InitializeDirectory(string cachePath)
        {
            int index = 0;
            var orderedCount = from count in this.level.Count
                               orderby count.Value descending
                               select count;

            if (!Directory.Exists(cachePath))
            {
                Directory.CreateDirectory(cachePath);
            }

            foreach (KeyValuePair<int, int> tile in orderedCount)
            {
                // The amount of tiles we store will depend on the counter's number of elements halved.
                if (index < this.level.Count.Count / 2)
                {
                    ((Bitmap)this.sprites.Sprites[tile.Key]).Save(cachePath + tile.Key.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }
                else
                {
                    break;
                }

                index++;
            }
        }

        /// <summary>
        /// This method is invoked via the AsyncOperation object, so it is guaranteed to be executed on the correct thread.
        /// </summary>
        /// <param name="state">The state of the operation.</param>
        private void ReportProgress(object state)
        {
            ProgressChangedEventArgs e = (ProgressChangedEventArgs)state;
            this.OnProgressChanged(e);
        }
    }

    /// <summary>
    /// Provides access to methods that allows the creation of a Super Mario Flash v3.0 level map.
    /// </summary>
    public partial class Converter
    {
        /// <summary>
        /// Automatically change the size of a font to fit inside a specified size.
        /// </summary>
        /// <param name="font">The font to fit.</param>
        /// <param name="size">The size to make the font fit into.</param>
        /// <param name="text">The text to measure and autosize.</param>
        /// <returns>The font, whose size has been changed to fit inside the size specified in the parameter.</returns>
        private Font AutoSize(Font font, Size size, string text)
        {
            // Make sure there is text and the size isn't zero.
            if (string.IsNullOrEmpty(text) || size.IsEmpty)
            {
                return font;
            }

            // Calculate the new size of the font using ratios.
            SizeF textSize = TextRenderer.MeasureText(text, font);
            float heightRatio = size.Height / textSize.Height;
            float widthRatio = size.Width / textSize.Width;
            float ratio = Math.Min(heightRatio, widthRatio);

            return new Font(font.Name, 12f * ratio);
        }

        /// <summary>
        /// This method performs the actual conversion. Note that it's executed on the worker thread.
        /// </summary>
        /// <param name="zone">The zone to convert.</param>
        /// <param name="argument">Arguments that states how the converter will create the level map.</param>
        /// <param name="asyncOp">The async operation which will be used to track the lifetime of the asynchronous operation.</param>
        private void ConvertWorker(Zones zone, ZoneArgument argument, AsyncOperation asyncOp)
        {
            Bitmap map = new Bitmap(this.GetWidth(Zones.Main, false), LevelHeight * BlockSize);
            Exception errors = null;

            try
            {
                Rectangle croppedSize = new Rectangle()
                {
                    X = ((((int)argument.StartPosition + 320) / 20) * BlockSize) - 256,
                    Y = 0,
                    Width = (((int)argument.EndPosition + 320) / 20) * BlockSize,
                    Height = LevelHeight * BlockSize 
                };

                using (Graphics graphic = Graphics.FromImage(map))
                {
                    graphic.DrawImage(this.DrawZone(zone, false, false, asyncOp), 0, 0);
                    graphic.DrawString(argument.Text, argument.AutoSize ? this.AutoSize(argument.Font, argument.Cropping ? croppedSize.Size : map.PhysicalDimension.ToSize(), argument.Text) : argument.Font, new SolidBrush(Color.FromArgb(argument.Opacity, argument.Color)), new PointF(0, 0));
                    
                    // Does the user want to crop?
                    if (argument.Cropping)
                    {
                        map = map.Clone(croppedSize, System.Drawing.Imaging.PixelFormat.DontCare);
                    }
                }
            }
            catch (Exception ex)
            {
                ex = errors;
            }

            // Activate the completion method.
            this.CompletionMethod(this.canceling ? null : map, errors, this.canceling, asyncOp);
        }

        /// <summary>
        /// This method performs the actual conversion. Note that it's executed on the worker thread.
        /// </summary>
        /// <param name="argument">Arguments that states how the converter will create the level map.</param>
        /// <param name="asyncOp">The async operation which will be used to track the lifetime of the asynchronous operation.</param>
        private void ConvertWorker(LevelArgument argument, AsyncOperation asyncOp)
        {
            Bitmap map = new Bitmap(this.GetWidth(Zones.Main, false), ((LevelHeight * BlockSize) * 2) + DescriptionHeight);
            Exception errors = null;

            try
            {
                using (Graphics graphic = Graphics.FromImage(map))
                {
                    graphic.DrawImage(this.DrawZone(Zones.Main, false, true, asyncOp), 0, 0);
                    graphic.DrawImage(this.DrawBackground(argument), 0, LevelHeight * BlockSize);
                    graphic.DrawImage(this.DrawZone(Zones.Bonus, false, true, asyncOp), 0, (LevelHeight * BlockSize) + DescriptionHeight);

                    // Draw the background area's string
                    graphic.DrawString(
                        argument.Text,
                        argument.AutoSize ? this.AutoSize(argument.Font, new Size(LevelWidth * BlockSize, DescriptionHeight), argument.Text) : argument.Font,
                        new SolidBrush(argument.FontColor),
                        new RectangleF(0, LevelHeight * BlockSize, LevelWidth * BlockSize, DescriptionHeight),
                        new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                }
            }
            catch (Exception ex)
            {
                ex = errors;
            }

            // Activate the completion method
            this.CompletionMethod(this.canceling ? null : map, errors, this.canceling, asyncOp);
        }

        /// <summary>
        /// Draws a background for the middle area of the level map.
        /// </summary>
        /// <param name="arguments">Arguments to pass to determine what to draw.</param>
        /// <returns>The background according to the arguments passed.</returns>
        private Bitmap DrawBackground(LevelArgument arguments)
        {
            Bitmap background = new Bitmap(LevelWidth * BlockSize, DescriptionHeight);

            using (Graphics graphic = Graphics.FromImage(background))
            {
                switch (arguments.Background)
                {
                    case BackgroundTypes.Default:
                        using (LinearGradientBrush gradient = new LinearGradientBrush(new Point(0, 0), new Point(0, DescriptionHeight), Color.LightBlue, Color.Blue))
                        {
                            gradient.InterpolationColors = new ColorBlend()
                            {
                                Colors = new Color[]
                                {
                                    Color.FromArgb(0, 51, 153),
                                    Color.FromArgb(1, 102, 208),
                                    Color.FromArgb(0, 51, 153)
                                },
                                Positions = new float[] { 0.0f, 0.5f, 1.0f }
                            };

                            graphic.FillRectangle(gradient, 0, 0, background.Width, background.Height);
                        }

                        break;
                    case BackgroundTypes.Image:
                        graphic.DrawImage(arguments.BackgroundImage, 0, 0, background.Width, background.Height);
                        break;
                    case BackgroundTypes.Solid:
                        graphic.FillRectangle(new SolidBrush(arguments.BackgroundColor), 0, 0, background.Width, background.Height);
                        break;
                }
            }

            return background;
        }

        /// <summary>
        /// Draws a level map according to the specified zone.
        /// </summary>
        /// <param name="zone">The zone to convert.</param>
        /// <param name="convertToLength">Specify if you want the converter to draw to the level's length or draw to an average level length.</param>
        /// <param name="twoZones">Specify if the converter will also convert a second zone.</param>
        /// <param name="asyncOp">The aysnchronous operation.</param>
        /// <returns>The level map of the zone.</returns>
        private Bitmap DrawZone(Zones zone, bool convertToLength, bool twoZones, AsyncOperation asyncOp)
        {
            Bitmap map = new Bitmap(this.GetWidth(zone, convertToLength), LevelHeight * BlockSize);
            ProgressChangedEventArgs progress = null;
            int currentTile = 0;
            int index = (zone == Zones.Main) ? 0 : 2706;
            int maxIndex = (zone == Zones.Main && !twoZones) ? 2699 : 5404;

            using (Graphics graphic = Graphics.FromImage(map))
            {
                // Draw the background first.
                if (zone == Zones.Bonus)
                {
                    graphic.DrawImage((Bitmap)this.sprites.Backgrounds[(int)this.level.Bonus.Background], 0, 0);
                }
                else
                {
                    graphic.DrawImage((Bitmap)this.sprites.Backgrounds[(int)this.level.Main.Background], 0, 0);
                }

                // Start placing the tiles.
                for (int y = 0; y < LevelHeight; y++)
                {
                    for (int x = 0; x < LevelWidth; x++)
                    {
                        // Check if the user pressed cancel.
                        if (this.canceling)
                        {
                            return new Bitmap(1, 1);
                        }

                        currentTile = int.Parse(this.level.Pieces[index]);

                        // Draw tiles and enemies
                        using (Bitmap tile = this.GetSprite(currentTile, string.Format("{1}Cache{0}", Path.DirectorySeparatorChar, this.storagePath)))
                        {
                            if ((tile.PhysicalDimension.Height > 16) && (tile.PhysicalDimension.Height != 32))
                            {
                                graphic.DrawImage(tile, x * 16, (y * 16) - (tile.Height - 16));
                            }
                            else
                            {
                                graphic.DrawImage(tile, x * 16, y * 16);
                            }
                        }               

                        // Draw platform labels (if necessary)
                        if ((currentTile >= 51) && (currentTile <= 55))
                        {
                            using (Bitmap label = (Bitmap)this.sprites.Labels[currentTile])
                            {
                                graphic.DrawImage(label, x * BlockSize, (y * BlockSize) - 10);
                            }
                        }

                        index++;
                        progress = new ProgressChangedEventArgs((int)(((float)index / (float)maxIndex) * 100F), asyncOp);
                        asyncOp.Post(this.onProgressReportDelegate, progress);
                    }
                }
            }

            return map;
        }

        /// <summary>
        /// Gets the image of the requested sprite. This method decides whether to get the image from the loaded document or from the cache.
        /// </summary>
        /// <param name="id">The ID of the sprite.</param>
        /// <param name="cachePath">The path to the cache which contains the most-requested sprites.</param>
        /// <returns>The sprite, either from cache or from the sprite document.</returns>
        private Bitmap GetSprite(int id, string cachePath)
        {
            Sprite currentSprite = this.sprites.Sprites[id];

            // Does the requested sprite exist in the cache?
            if (File.Exists(cachePath + id.ToString() + ".png"))
            {
                Bitmap sprite = (Bitmap)Bitmap.FromFile(cachePath + id.ToString() + ".png");
                return sprite;
            }
            else
            {
                return (Bitmap)this.sprites.Sprites[id];
            }
        }

        /// <summary>
        /// Gets the width to use for the level map according to the parameters.
        /// </summary>
        /// <param name="zone">The zone to convert.</param>
        /// <param name="convertToLength">Specify if you want the converter to draw to the level's length or draw to an average level length.</param>
        /// <returns>The length of the level according to the specified parameters.</returns>
        private int GetWidth(Zones zone, bool convertToLength)
        {
            int mainLength = this.level.Main.Length;
            int bonusLength = this.level.Bonus.Length;

            // Length will be determined according to the set zone and if the user wants to convert to length
            if (convertToLength && zone == Zones.Main)
            {
                return (mainLength / 20) * BlockSize;
            }
            else if (convertToLength && zone == Zones.Bonus)
            {
                return (bonusLength / 20) * BlockSize;
            }
            else
            {
                return Math.Max((mainLength / 20) * BlockSize, (bonusLength / 20) * BlockSize);
            }
        }
    }
}