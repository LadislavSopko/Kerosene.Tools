﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kerosene.Tools
{
	// =====================================================
	/// <summary>
	/// Represents a failed attempt of executing an operation.
	/// </summary>
	[Serializable]
	public class CannotExecuteException : Exception
	{
		/// <summary>
		/// Default constructor for an empty instance.
		/// </summary>
		public CannotExecuteException() { }

		/// <summary>
		/// Initializes a new instance with the given message.
		/// </summary>
		/// <param name="message">An string containing a description of the error.</param>
		public CannotExecuteException(string message) : base(message) { }

		/// <summary>
		/// Initializes a new instance with the given message and a reference to the exception that
		/// can be considered the cause of this one.
		/// </summary>
		/// <param name="message">An string containing a description of the error.</param>
		/// <param name="inner">A reference to the exception that can be considered as the cause
		/// of this one, or null if this information is not available or needed.</param>
		public CannotExecuteException(string message, Exception inner) : base(message, inner) { }
	}
}
