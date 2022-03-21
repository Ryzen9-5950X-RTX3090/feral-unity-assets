using System;
using System.Runtime.CompilerServices;
using BestHTTP.SocketIO3.Transports;
using PlatformSupport.Collections.ObjectModel;
using PlatformSupport.Collections.Specialized;

namespace BestHTTP.SocketIO3
{
	public sealed class SocketOptions
	{
		private float randomizationFactor;

		private ObservableDictionary<string, string> additionalQueryParams;

		public Func<SocketManager, Socket, object> Auth;

		private string BuiltQueryParams;

		public TransportTypes ConnectWith
		{
			[CompilerGenerated]
			get
			{
				return default(TransportTypes);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Reconnection
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int ReconnectionAttempts
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TimeSpan ReconnectionDelay
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TimeSpan ReconnectionDelayMax
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float RandomizationFactor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public TimeSpan Timeout
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool AutoConnect
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ObservableDictionary<string, string> AdditionalQueryParams
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool QueryParamsOnlyForHandshake
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public HTTPRequestCallbackDelegate HTTPRequestCustomizationCallback
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal string BuildQueryParams()
		{
			return null;
		}

		private void AdditionalQueryParams_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
		}
	}
}
