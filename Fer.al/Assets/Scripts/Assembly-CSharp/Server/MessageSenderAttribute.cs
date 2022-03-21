using System;
using System.Runtime.CompilerServices;

namespace Server
{
	[AttributeUsage(AttributeTargets.Method)]
	public class MessageSenderAttribute : Attribute
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

		public bool AllowRedundant
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MessageSenderAttribute(XtCmd cmd, bool allowRedundant = false)
		{
		}

		public MessageSenderAttribute(string cmd, bool allowRedundant = false)
		{
		}
	}
}
