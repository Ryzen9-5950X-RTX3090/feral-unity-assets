using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.EventStreams.Internal
{
	public class EventStreamMessageReceivedEventArgs : EventArgs
	{
		public EventStreamMessage Message
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public object Context
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public EventStreamMessageReceivedEventArgs(EventStreamMessage message)
		{
		}

		public EventStreamMessageReceivedEventArgs(EventStreamMessage message, object context)
		{
		}
	}
}
