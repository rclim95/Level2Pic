// <copyright file="RotateType.cs" company="Limotto Productions">
// Copyright © Limotto Productions
//
// This project is licensed under the MIT License. For more information, see LICENSE.md.
// </copyright>

namespace Level2Pic.Core
{
    using System;

    /// <summary>
    /// Defines the possible ways that a <see cref="Sprite" /> can be rotated.
    /// </summary>
    public enum RotateType
    {
        /// <summary>
        /// Don't rotate the texture.
        /// </summary>
        RotateNone,

        /// <summary>
        /// Rotate the texture by 90 degrees clockwise.
        /// </summary>
        Rotate90,

        /// <summary>
        /// Rotate the texture by 180 degrees clockwise.
        /// </summary>
        Rotate180,

        /// <summary>
        /// Rotate the texture by 270 degrees clockwise.
        /// </summary>
        Rotate270,
    }
}