using System;
using System.Runtime.CompilerServices;

namespace Amazon.Util.Internal.PlatformServices
{
	public class NetworkStatusEventArgs : EventArgs
	{
		public NetworkStatus Status
		{
			[CompilerGenerated]
			get
			{
				return default(NetworkStatus);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NetworkStatusEventArgs(NetworkStatus status)
		{
		}
	}
}
