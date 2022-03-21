using System;
using System.Runtime.Serialization;

namespace Amazon.Runtime.EventStreams
{
	[Serializable]
	public sealed class UnknownEventStreamMessageTypeException : Exception
	{
		public UnknownEventStreamMessageTypeException()
		{
		}

		private UnknownEventStreamMessageTypeException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
