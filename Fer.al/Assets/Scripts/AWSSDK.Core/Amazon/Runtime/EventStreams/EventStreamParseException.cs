using System;
using System.Runtime.Serialization;

namespace Amazon.Runtime.EventStreams
{
	[Serializable]
	public class EventStreamParseException : Exception
	{
		public EventStreamParseException(string message)
		{
		}

		protected EventStreamParseException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
