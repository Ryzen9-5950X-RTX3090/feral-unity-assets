using System;
using System.Runtime.Serialization;
using Amazon.Runtime.EventStreams.Internal;

namespace Amazon.Runtime.EventStreams
{
	[Serializable]
	public sealed class EventStreamErrorCodeException : EventStreamException
	{
		public int ErrorCode
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public EventStreamErrorCodeException(int errorCode)
		{
		}

		public EventStreamErrorCodeException(int errorCode, string message)
		{
		}

		private EventStreamErrorCodeException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
