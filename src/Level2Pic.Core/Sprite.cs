// <copyright file="Sprite.cs" company="rclim95 Productions">
// Copyright © rclim95 Productions
//
// This project is licensed under the MIT License. For more information, see LICENSE.md.
// </copyright>

namespace Level2Pic.Core
{
    using System.Drawing;

    /// <summary>
    /// Represents a sprite that is part of a spritesheet.
    /// </summary>
    /// <remarks>
    /// When a sprite needs to be rotated and flipped, the sprite will be rotated first and then
    /// flipped.
    /// </remarks>
    public class Sprite
    {
        /// <summary>
        /// Gets or sets how the sprite should be flipped.
        /// </summary>
        public FlipType FlipType { get; set; }

        /// <summary>
        /// Gets or sets how the sprite should be rotated.
        /// </summary>
        public RotateType RotateType { get; set; }

        /// <summary>
        /// Gets or sets the text used to label the sprite.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the location of the sprite relative to the spritesheet it belongs to.
        /// </summary>
        public Point Position { get; set; }

        /// <summary>
        /// Gets or sets the size of the sprite relative to the spritesheet it belongs to.
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// Gets the <see cref="Rectangle" /> that contains the bound of the sprite in respect to
        /// the spritesheet it belongs to.
        /// </summary>
        /// <returns>
        /// A <see cref="Rectangle" /> that contains the bounds of the sprite. This is composed of
        /// the sprite's <see cref="Position" /> and <see cref="Size" />.
        /// </returns>
        public Rectangle GetBounds()
        {
            return new Rectangle(this.Position, this.Size);
        }
    }
}
