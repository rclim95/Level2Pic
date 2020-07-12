using System;
using System.Collections.Generic;
using System.Drawing;

namespace Level2Pic.Library
{
    /// <summary>
    /// Specifies the kind of sprite that is being used.
    /// </summary>
    public enum SpriteKind
    {
        /// <summary>
        /// The sprite that is used for backgrounds.
        /// </summary>
        Background,

        /// <summary>
        /// The sprite that is used for labels on platforms.
        /// </summary>
        Label,

        /// <summary>
        /// The sprites that is used for tiles and enemies.
        /// </summary>
        Tile
    }

    /// <summary>
    /// Provides a class that is responsible for caching all sprites that are loaded.
    /// </summary>
    public class SpriteCacheManager : IDisposable
    {
        private readonly SpriteDocument _document;
        private readonly Dictionary<(SpriteKind, int), Bitmap> _spriteBitmaps;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpriteCacheManager" /> class.
        /// </summary>
        /// <param name="document">The document that should be loaded by the cache manager.</param>
        public SpriteCacheManager(SpriteDocument document)
        {
            _document = document;
            _spriteBitmaps = new Dictionary<(SpriteKind, int), Bitmap>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempt to load and cache all sprites that were found.
        /// </summary>
        public void Load()
        {
        }
    }
}