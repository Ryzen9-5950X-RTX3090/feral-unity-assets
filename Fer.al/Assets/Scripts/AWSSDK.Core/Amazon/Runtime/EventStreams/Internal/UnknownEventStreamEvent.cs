using System.Runtime.CompilerServices;

namespace Amazon.Runtime.EventStreams.Internal
{
	public class UnknownEventStreamEvent : IEventStreamEvent
	{
		public IEventStreamMessage ReceivedMessage
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

		public string EventType
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

		public UnknownEventStreamEvent()
		{
		}

		public UnknownEventStreamEvent(IEventStreamMessage receivedMessage, string eventType)
		{
		}
	}
}
