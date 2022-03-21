using System;
using System.Runtime.Serialization;

namespace Amazon.Runtime.EventStreams
{
	[Serializable]
	public sealed class EventStreamValidationException : Exception
	{
		public EventStreamValidationException()
		{
		}

		public EventStreamValidationException(string message)
		{
		}

		public EventStreamValidationException(string message, Exception innerException)
		{
		}

		private EventStreamValidationException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
