using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Util
{
	public class LogMessage : ILogMessage
	{
		public object[] Args
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

		public IFormatProvider Provider
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

		public string Format
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

		public LogMessage(string message)
		{
		}

		public LogMessage(string format, object[] args)
		{
		}

		public LogMessage(IFormatProvider provider, string format, object[] args)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
