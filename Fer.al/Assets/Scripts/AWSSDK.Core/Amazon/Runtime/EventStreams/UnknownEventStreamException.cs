using System;
using System.Runtime.Serialization;
using Amazon.Runtime.EventStreams.Internal;

namespace Amazon.Runtime.EventStreams
{
	[Serializable]
	public sealed class UnknownEventStreamException : EventStreamException
	{
		public string ExceptionType
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public UnknownEventStreamException(string exceptionType)
		{
		}

		private UnknownEventStreamException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
