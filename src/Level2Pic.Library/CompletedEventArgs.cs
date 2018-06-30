// <copyright file="CompletedEventArgs.cs" company="NZoid154 Softwares">
// Copyright (c) 2010 - 2011
// </copyright>

namespace Level2Pic.Library
{
    using System;
    using System.ComponentModel;
    using System.Drawing;

    /// <summary>
    /// Provides data for the Level2Pic.Library.Converter.Completed event.
    /// </summary>
    public class CompletedEventArgs : AsyncCompletedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the CompletedEventArgs class.
        /// </summary>
        /// <param name="error">Any error that occured during the asynchronous operation.</param>
        /// <param name="cancelled">A value indicating whether the asynchronous operation was cancelled.</param>
        /// <param name="userState">The optional user-supplied state object passed to the method.</param>
        public CompletedEventArgs(Exception error, bool cancelled, object userState)
            : base(error, cancelled, userState)
        {
        }

        /// <summary>
        /// Gets the bitmap that represents the result of the asynchronous operation.
        /// </summary>
        public Bitmap Result
        {
            get;
            internal set;
        }
    }
}
