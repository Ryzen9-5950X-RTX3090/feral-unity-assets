using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.EventStreams
{
	public class EventStreamMessage : IEventStreamMessage
	{
		internal const int SizeOfInt32 = 4;

		internal const int PreludeLen = 12;

		internal const int TrailerLen = 4;

		internal const int FramingSize = 16;

		public const string ContentType = "vnd.amazon.eventstream";

		public Dictionary<string, IEventStreamHeader> Headers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public byte[] Payload
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private EventStreamMessage()
		{
		}

		public EventStreamMessage(List<IEventStreamHeader> headers, byte[] payload)
		{
		}

		public static EventStreamMessage FromBuffer(byte[] buffer, int offset, int length)
		{
			return null;
		}

		public byte[] ToByteArray()
		{
			return null;
		}
	}
}
