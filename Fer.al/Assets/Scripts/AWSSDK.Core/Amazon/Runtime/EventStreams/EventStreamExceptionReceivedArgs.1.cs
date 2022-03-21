using System;
using System.Runtime.CompilerServices;
using Amazon.Runtime.EventStreams.Internal;

namespace Amazon.Runtime.EventStreams
{
	public class EventStreamExceptionReceivedArgs<T> : EventArgs where T : EventStreamException
	{
		[CompilerGenerated]
		private readonly T <EventStreamException>k__BackingField;

		public T EventStreamException
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public EventStreamExceptionReceivedArgs(T eventStreamException)
		{
		}
	}
}
