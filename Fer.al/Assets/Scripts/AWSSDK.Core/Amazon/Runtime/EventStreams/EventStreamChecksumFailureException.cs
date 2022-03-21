using System;
using System.Runtime.Serialization;

namespace Amazon.Runtime.EventStreams
{
	[Serializable]
	public class EventStreamChecksumFailureException : Exception
	{
		public EventStreamChecksumFailureException(string message)
		{
		}

		protected EventStreamChecksumFailureException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
