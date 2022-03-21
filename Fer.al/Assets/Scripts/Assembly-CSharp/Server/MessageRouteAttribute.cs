using System;
using System.Runtime.CompilerServices;

namespace Server
{
	public class MessageRouteAttribute : Attribute
	{
		public string Cmd
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

		public QueueMessageMode QueueMode
		{
			[CompilerGenerated]
			get
			{
				return default(QueueMessageMode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MessageRouteAttribute(XtCmd cmd, QueueMessageMode queueMode = QueueMessageMode.Never)
		{
		}

		public MessageRouteAttribute(string cmd, QueueMessageMode queueMode = QueueMessageMode.Never)
		{
		}
	}
}
