using System;

namespace Amazon.Util.Internal.PlatformServices
{
	public class NetworkReachability : INetworkReachability
	{
		internal EventHandler<NetworkStatusEventArgs> mNetworkReachabilityChanged;

		internal static readonly object reachabilityChangedLock;

		public NetworkStatus NetworkStatus
		{
			get
			{
				return default(NetworkStatus);
			}
		}

		public event EventHandler<NetworkStatusEventArgs> NetworkReachabilityChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal void OnNetworkReachabilityChanged(NetworkStatus status)
		{
		}
	}
}
