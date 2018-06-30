// <copyright file="LevelException.cs" company="NZoid154 Software">
// Copyright (c) 2010
// </copyright>
namespace Level2Pic.Library
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents a level error while validating a level code
    /// </summary>
    [Serializable]
    public class LevelException : Exception
    {
        /// <summary>
        /// Contains the default exception message
        /// </summary>
        private const string ExceptionMessage = "An error occured while validating the level code.";

        /// <summary>
        /// Initializes a new instance of the LevelException class
        /// </summary>
        public LevelException() : base(ExceptionMessage)
        { 
        }

        /// <summary>
        /// Initializes a new instance of the LevelException class with a specified error message
        /// </summary>
        /// <param name="message">The error message string</param>
        public LevelException(string message) : base(ExceptionMessage + " " + message)
        { 
        }

        /// <summary>
        /// Initializes a new instance of the LevelException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message string</param>
        /// <param name="inner">The inner exception reference</param>
        public LevelException(string message, Exception inner) : base(ExceptionMessage + " " + message, inner) 
        { 
        }

        /// <summary>
        /// Initializes a new instance of the LevelException class with with serialized data.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination. </param>
        protected LevelException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) 
        { 
        }
    }
}
