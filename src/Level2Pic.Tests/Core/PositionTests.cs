// <copyright file="PositionTests.cs" company="rclim95 Productions">
// Copyright © rclim95 Productions
//
// This project is licensed under the MIT License. For more information, see LICENSE.md.
// </copyright>

namespace Level2Pic.Core.Tests
{
    using Level2Pic.Core;
    using Xunit;

    /// <summary>
    /// Responsible for testing the <see cref="Position" /> struct.
    /// </summary>
    public class PositionTests
    {
        /// <summary>
        /// Ensure that the equality operator works.
        /// </summary>
        [Fact]
        public void TestEquality()
        {
            var position1 = new Position(1, 1);
            var position2 = new Position(1, 1);

            Assert.True(position1 == position2);
            Assert.False(position1 != position2);
        }

        /// <summary>
        /// Ensure that the inequality operator works.
        /// </summary>
        [Fact]
        public void TestInequality()
        {
            var position1 = new Position(1, 2);
            var position2 = new Position(2, 1);

            Assert.True(position1 != position2);
            Assert.False(position1 == position2);
        }
    }
}
