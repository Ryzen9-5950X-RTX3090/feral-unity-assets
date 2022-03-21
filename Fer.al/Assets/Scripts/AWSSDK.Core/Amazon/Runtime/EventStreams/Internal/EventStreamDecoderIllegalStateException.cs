using System;
using System.Runtime.Serialization;

namespace Amazon.Runtime.EventStreams.Internal
{
	[Serializable]
	public class EventStreamDecoderIllegalStateException : Exception
	{
		public EventStreamDecoderIllegalStateException(string message)
		{
		}

		protected EventStreamDecoderIllegalStateException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
