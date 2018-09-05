// <copyright file="Position.cs" company="rclim95 Productions">
// Copyright © rclim95 Productions
//
// This project is licensed under the MIT License. For more information, see LICENSE.md.
// </copyright>

namespace Level2Pic.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents a tile position on a 2D grid in a level.
    /// </summary>
    public struct Position : IEquatable<Position>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Position" /> struct.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets the X component of this position.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Gets the Y component of this position.
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Compares two <see cref="Position" /> objects for equality.
        /// </summary>
        /// <param name="lhs">The position (on the left-hand side of the equality operator) to compare.</param>
        /// <param name="rhs">The position (on the right-hand side of the equality operator) to compare.</param>
        /// <returns><c>true</c> if the X and Y components of both positions are the same; otherwise, <c>false</c>.</returns>
        public static bool operator ==(Position lhs, Position rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Compares two <see cref="Position" /> objects for inequality.
        /// </summary>
        /// <param name="lhs">The position (on the left-hand side of the equality operator) to compare.</param>
        /// <param name="rhs">The position (on the right-hand side of the equality operator) to compare.</param>
        /// <returns><c>true</c> if the X and Y components of both positions are different; otherwise, <c>false</c>.</returns>
        public static bool operator !=(Position lhs, Position rhs)
        {
            return !(lhs == rhs);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return obj is Position && this.Equals((Position)obj);
        }

        /// <inheritdoc />
        public bool Equals(Position other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = (hashCode * -1521134295) + this.X.GetHashCode();
            hashCode = (hashCode * -1521134295) + this.Y.GetHashCode();
            return hashCode;
        }
    }
}
