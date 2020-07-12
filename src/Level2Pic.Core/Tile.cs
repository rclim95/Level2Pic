// <copyright file="Tile.cs" company="Limotto Productions">
// Copyright © Limotto Productions
//
// This project is licensed under the MIT License. For more information, see LICENSE.md.
// </copyright>

namespace Level2Pic.Core
{
    /// <summary>
    /// Represents a tile that can be placed in a level.
    /// </summary>
    public class Tile
    {
        /// <summary>
        /// Gets or sets a description of the tile.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the ID of the tile.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the tile.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the sprite that should be used to represent this tile visually.
        /// </summary>
        public Sprite Sprite { get; set; }
    }
}
