// <copyright file="ProgressChangedEventArgs.cs" company="NZoid154 Softwares">
// Coyright (c) 2010 - 2011
// </copyright>

namespace Level2Pic.Library
{
    using System;
    using System.ComponentModel;
    using System.Drawing;

    /// <summary>
    /// Provides data for the Level2Pic.Library.Converter.ProgressChanged event.
    /// </summary>
    public class ProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the ProgressChangedEventArgs class.
        /// </summary>
        /// <param name="progressPercentage">The percentage of an asynchronous task that has been completed.</param>
        /// <param name="userState">A unique user state.</param>
        public ProgressChangedEventArgs(int progressPercentage, object userState)
            : base(progressPercentage, userState)
        {
        }
    }
}
