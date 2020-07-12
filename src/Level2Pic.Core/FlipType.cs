// <copyright file="FlipType.cs" company="Limotto Productions">
// Copyright © Limotto Productions
//
// This project is licensed under the MIT License. For more information, see LICENSE.md.
// </copyright>

namespace Level2Pic.Core
{
    /// <summary>
    /// Defines the possible ways that a <see cref="Sprite" /> can be flipped.
    /// </summary>
    public enum FlipType
    {
        /// <summary>
        /// Don't flip the texture.
        /// </summary>
        FlipNone,

        /// <summary>
        /// Flip the texture on its X axis.
        /// </summary>
        FlipX,

        /// <summary>
        /// Flip the texture on its Y axis.
        /// </summary>
        FlipY,

        /// <summary>
        /// Flip the texture on its X and Y axes.
        /// </summary>
        FlipXY,
    }
}