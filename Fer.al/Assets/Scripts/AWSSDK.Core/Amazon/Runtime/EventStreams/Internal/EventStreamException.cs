using System;
using System.Runtime.Serialization;

namespace Amazon.Runtime.EventStreams.Internal
{
	[Serializable]
	public abstract class EventStreamException : Exception
	{
		protected EventStreamException()
		{
		}

		protected EventStreamException(string message)
		{
		}

		protected EventStreamException(string message, Exception innerException)
		{
		}

		protected EventStreamException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
