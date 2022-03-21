using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.Connections
{
	public sealed class KeepAliveHeader
	{
		public TimeSpan TimeOut
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int MaxRequests
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Parse(List<string> headerValues)
		{
		}
	}
}
