using System;
using System.Runtime.CompilerServices;

namespace BestHTTP.Caching
{
	public sealed class HTTPCacheMaintananceParams
	{
		public TimeSpan DeleteOlder
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

		public ulong MaxCacheSize
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public HTTPCacheMaintananceParams(TimeSpan deleteOlder, ulong maxCacheSize)
		{
		}
	}
}
