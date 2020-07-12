// <copyright file="Sprite.cs" company="Limotto Productions">
// Copyright © Limotto Productions
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
        /// Initializes a new instance of the <see cref="Sprite" /> class.
        /// </summary>
        /// <param name="position">The position of the sprite (relative to the spritesheet that this sprite belongs to).</param>
        /// <param name="size">The size of the sprite (in pixels).</param>
        public Sprite(Point position, Size size)
        {
            this.Position = position;
            this.Size = size;
        }

        /// <summary>
        /// Gets or sets how the sprite should be flipped.
        /// </summary>
        public FlipType FlipType { get; set; }

        /// <summary>
        /// Gets or sets how the sprite should be rotated.
        /// </summary>
        public RotateType RotateType { get; set; }

        /// <summary>
        /// Gets the location of the sprite relative to the spritesheet it belongs to.
        /// </summary>
        public Point Position { get; }

        /// <summary>
        /// Gets the size of the sprite relative to the spritesheet it belongs to.
        /// </summary>
        public Size Size { get; }

        /// <summary>
        /// Gets the spritesheet that this sprite belongs to.
        /// </summary>
        /// <remarks>
        /// This property will be <c>null</c> unless the <see cref="Sprite" /> gets added
        /// to a <see cref="SpriteSheet" />.
        /// </remarks>
        public SpriteSheet SpriteSheet { get; internal set; }

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
