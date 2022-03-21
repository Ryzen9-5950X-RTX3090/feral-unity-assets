using System;

namespace Server
{
	[AttributeUsage(AttributeTargets.Class)]
	public class RoutedMessageAttribute : MessageRouteAttribute
	{
		public RoutedMessageAttribute(XtCmd cmd, QueueMessageMode queueMode = QueueMessageMode.Never)
		{
		}

		public RoutedMessageAttribute(string cmd, QueueMessageMode queueMode = QueueMessageMode.Never)
		{
		}
	}
}
