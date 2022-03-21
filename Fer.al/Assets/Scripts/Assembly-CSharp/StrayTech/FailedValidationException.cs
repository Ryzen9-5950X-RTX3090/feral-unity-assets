using System;
using System.Runtime.Serialization;

namespace StrayTech
{
	[Serializable]
	public class FailedValidationException : Exception
	{
		public FailedValidationException()
		{
		}

		public FailedValidationException(string message)
		{
		}

		public FailedValidationException(string message, Exception inner)
		{
		}

		protected FailedValidationException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
