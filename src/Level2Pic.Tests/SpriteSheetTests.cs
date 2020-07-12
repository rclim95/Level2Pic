// <copyright file="SpriteSheetTests.cs" company="Limotto Productions">
// Copyright © Limotto Productions
//
// This project is licensed under the MIT License. For more information, see LICENSE.md.
// </copyright>

namespace Level2Pic.Core.Tests
{
    using System;
    using System.Drawing;
    using Xunit;

    /// <summary>
    /// Tests the <see cref="SpriteSheet" /> class.
    /// </summary>
    public class SpriteSheetTests
    {
        /// <summary>
        /// Ensures that adding a null sprite (i.e., passing <c>null</c> to
        /// <see cref="SpriteSheet.Add(Sprite)" /> results in an exception being thrown.
        /// </summary>
        [Fact]
        public void TestAddNullSprite()
        {
            var spriteSheet = new SpriteSheet("Test.png", 32, 32);
            Assert.Throws<ArgumentNullException>(() =>
            {
                spriteSheet.Add(null);
            });
        }

        /// <summary>
        /// Ensures that adding a sprite associates the sprite with the spritesheet and exists
        /// in the spritesheet.
        /// </summary>
        [Fact]
        public void TestAddSprite()
        {
            var spriteSheet = new SpriteSheet("Test.png", 32, 32);

            var sprite = new Sprite(Point.Empty, new Size(16, 16));
            spriteSheet.Add(sprite);

            Assert.Same(spriteSheet, sprite.SpriteSheet);
            Assert.Contains(sprite, spriteSheet);
            Assert.Single(spriteSheet);
        }

        /// <summary>
        /// Ensures that adding a sprite that already exists in another spritesheet results in an
        /// exception when attempting to add it to a different spritesheet.
        /// </summary>
        [Fact]
        public void TestAddSpriteOfExistingSpriteSheet()
        {
            var spriteSheet = new SpriteSheet("Test.png", 32, 32);

            var sprite1 = new Sprite(Point.Empty, new Size(16, 16));
            spriteSheet.Add(sprite1);

            var ex = Assert.Throws<ArgumentException>(() =>
            {
                spriteSheet.Add(sprite1);
            });
            Assert.Contains("associated with another spritesheet", ex.Message);
        }

        /// <summary>
        /// Ensures that adding a sprite that is out of range (i.e., is too big for the sprite
        /// sheet) results in an exception.
        /// </summary>
        [Fact]
        public void TestAddSpriteOutOfRange()
        {
            var spriteSheet = new SpriteSheet("Test.png", 32, 32);

            // Don't allow adding sprites that is too big.
            var sprite1 = new Sprite(Point.Empty, new Size(48, 48));
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                spriteSheet.Add(sprite1);
            });
            Assert.True(!spriteSheet.Contains(sprite1));

            // Don't allow adding sprites that is outside the spritesheet.
            var sprite2 = new Sprite(new Point(32, 32), new Size(16, 16));
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                spriteSheet.Add(sprite2);
            });
            Assert.True(!spriteSheet.Contains(sprite2));
        }

        /// <summary>
        /// Ensures that clearing all sprites remove all sprites from the collection and
        /// diassociates them from the spritesheet.
        /// </summary>
        [Fact]
        public void TestClearSprites()
        {
            var sprite1 = new Sprite(Point.Empty, new Size(16, 16));
            var sprite2 = new Sprite(new Point(16, 0), new Size(16, 16));

            var spriteSheet = new SpriteSheet("Test.png", 32, 32);
            spriteSheet.Add(sprite1);
            spriteSheet.Add(sprite2);
            spriteSheet.Clear();

            Assert.Empty(spriteSheet);
            Assert.True(!spriteSheet.Contains(sprite1));
            Assert.True(!spriteSheet.Contains(sprite2));
            Assert.Null(sprite1.SpriteSheet);
            Assert.Null(sprite2.SpriteSheet);
        }

        /// <summary>
        /// Ensures that the number of sprites reported in a spritesheet is correct.
        /// </summary>
        [Fact]
        public void TestCount()
        {
            var sprites = new Sprite[]
            {
                new Sprite(Point.Empty, new Size(16, 16)),
                new Sprite(new Point(16, 0), new Size(16, 16)),
                new Sprite(new Point(32, 0), new Size(16, 16)),
            };
            var spriteSheet = new SpriteSheet("Test.png", 64, 16);
            foreach (var sprite in sprites)
            {
                spriteSheet.Add(sprite);
            }

            Assert.Equal(sprites.Length, spriteSheet.Count);
        }

        /// <summary>
        /// Ensures that removing a sprite that does not exist in the spritesheet results in
        /// <see cref="SpriteSheet.Remove(Sprite)" /> returning <c>false</c>.
        /// </summary>
        [Fact]
        public void TestRemoveNonexistantSprite()
        {
            var sprite = new Sprite(Point.Empty, new Size(16, 16));
            var spriteSheet = new SpriteSheet("Test.png", 32, 16);

            bool isSpriteRemoved = spriteSheet.Remove(sprite);
            Assert.False(isSpriteRemoved);
            Assert.Null(sprite.SpriteSheet);
        }

        /// <summary>
        /// Ensures that removing a sprite disassociates it from the spritesheet and removes it
        /// from the spritesheet.
        /// </summary>
        [Fact]
        public void TestRemoveSprite()
        {
            var sprite1 = new Sprite(Point.Empty, new Size(16, 16));
            var sprite2 = new Sprite(new Point(16, 0), new Size(16, 16));

            var spriteSheet = new SpriteSheet("Test.png", 32, 16);
            spriteSheet.Add(sprite1);
            spriteSheet.Add(sprite2);

            bool isSpriteRemoved = spriteSheet.Remove(sprite1);
            Assert.True(isSpriteRemoved);
            Assert.True(!spriteSheet.Contains(sprite1));
            Assert.Null(sprite1.SpriteSheet);
            Assert.Single(spriteSheet);
        }
    }
}