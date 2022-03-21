using System;
using System.Runtime.CompilerServices;
using Amazon.Runtime.EventStreams.Internal;

namespace Amazon.Runtime.EventStreams
{
	public class EventStreamEventReceivedArgs<T> : EventArgs where T : IEventStreamEvent
	{
		[CompilerGenerated]
		private readonly T <EventStreamEvent>k__BackingField;

		public T EventStreamEvent
		{
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
		}

		public EventStreamEventReceivedArgs(T eventStreamEvent)
		{
		}
	}
}
