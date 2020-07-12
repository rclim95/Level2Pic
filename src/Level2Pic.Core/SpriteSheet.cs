// <copyright file="SpriteSheet.cs" company="Limotto Productions">
// Copyright © Limotto Productions
//
// This project is licensed under the MIT License. For more information, see LICENSE.md.
// </copyright>

namespace Level2Pic.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;

    /// <summary>
    /// Represents a single image that is composed of multiple <see cref="Sprite" />.
    /// </summary>
    public class SpriteSheet : ICollection<Sprite>
    {
        private readonly List<Sprite> sprites;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpriteSheet" /> class.
        /// </summary>
        /// <param name="path">The path to the spritesheet file.</param>
        /// <param name="width">The width of the spritesheet (in pixels).</param>
        /// <param name="height">The height of the spritesheet (in pixels).</param>
        public SpriteSheet(string path, int width, int height)
        {
            this.sprites = new List<Sprite>();
            this.Path = path;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets the number of sprites that makes up the spritesheet.
        /// </summary>
        public int Count => this.sprites.Count;

        /// <summary>
        /// Gets the height of the spritesheet.
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the collection is read-only.
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Gets the file path to the spritesheet.
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// Gets the width of the spritesheet.
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// Adds a sprite that belongs to this spritesheet.
        /// </summary>
        /// <param name="sprite">The sprite to add.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The bounds of the <paramref name="sprite" /> is out of the range of the spritesheet.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="sprite" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="sprite" /> is already associated with another spritesheet or
        /// <paramref name="sprite" /> already exists in this spritesheet.
        /// </exception>
        public void Add(Sprite sprite)
        {
            // Ensure that sprite is not null.
            if (sprite == null)
            {
                throw new ArgumentNullException(nameof(sprite));
            }

            // Ensure the sprite isn't already associated with another spritesheet
            if (sprite.SpriteSheet != null)
            {
                throw new ArgumentException(
                    "The sprite is already associated with another spritesheet",
                    nameof(sprite));
            }

            // Ensure that the sprite we're adding is within the rectangle of this spritesheet
            if (!this.IsSpriteInBounds(sprite))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(sprite),
                    "The sprite is outside the dimensions of this spritesheet");
            }

            sprite.SpriteSheet = this;
            this.sprites.Add(sprite);
        }

        /// <summary>
        /// Remove all sprite that exists in the spritesheet.
        /// </summary>
        public void Clear()
        {
            // We need to set SpriteSheet for each Sprite to null, since the sprite is no longer
            // associated with the SpriteSheet.
            for (int i = this.sprites.Count - 1; i >= 0; i--)
            {
                this.sprites[i].SpriteSheet = null;
                this.sprites.RemoveAt(i);
            }
        }

        /// <summary>
        /// Checks to see if the specified sprite reference exists in the spritesheet.
        /// </summary>
        /// <param name="sprite">The sprite to check.</param>
        /// <returns>Returns <c>true</c> if it exists, else <c>false</c>.</returns>
        public bool Contains(Sprite sprite)
        {
            return this.sprites.Contains(sprite);
        }

        /// <inheritdoc />
        public void CopyTo(Sprite[] array, int arrayIndex)
        {
            this.sprites.CopyTo(array, arrayIndex);
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.sprites.GetEnumerator();
        }

        /// <inheritdoc />
        public IEnumerator<Sprite> GetEnumerator()
        {
            return this.sprites.GetEnumerator();
        }

        /// <summary>
        /// Diassociates the sprite from this spritesheet and removes it.
        /// </summary>
        /// <param name="sprite">The sprite to remove.</param>
        /// <returns><c>true</c> if the sprite has been removed, else <c>false</c>.</returns>
        public bool Remove(Sprite sprite)
        {
            for (int i = 0; i < this.sprites.Count; i++)
            {
                var currentSprite = this.sprites[i];
                if (currentSprite.Equals(sprite))
                {
                    currentSprite.SpriteSheet = null;
                    this.sprites.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        private bool IsSpriteInBounds(Sprite sprite)
        {
            var spriteSheetRect = new Rectangle(0, 0, this.Width, this.Height);
            var spriteRect = sprite.GetBounds();

            return spriteSheetRect.Contains(spriteRect);
        }
    }
}
