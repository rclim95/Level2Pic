// <copyright file="Texture.cs" company="rclim95 Productions">
// Copyright © rclim95 Productions
//
// This project is licensed under the MIT License. For more information, see LICENSE.md.
// </copyright>

namespace Level2Pic.Core
{
    /// <summary>
    /// Represents a 2D texture that provides a visual representation of a <see cref="Tile" />.
    /// </summary>
    public class Texture
    {
        /// <summary>
        /// Gets or sets the path to the texture.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets how the texture should be flipped.
        /// </summary>
        public FlipType FlipType { get; set; }

        /// <summary>
        /// Gets or sets how the texture should be rotated.
        /// </summary>
        public RotateType RotateType { get; set; }
    }
}
