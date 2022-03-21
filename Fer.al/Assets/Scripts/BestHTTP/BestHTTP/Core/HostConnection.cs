using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP.Connections;
using BestHTTP.Logger;

namespace BestHTTP.Core
{
	public sealed class HostConnection
	{
		private List<ConnectionBase> Connections;

		private List<HTTPRequest> Queue;

		public HostDefinition Host
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

		public string VariantId
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

		public HostProtocolSupport ProtocolSupport
		{
			[CompilerGenerated]
			get
			{
				return default(HostProtocolSupport);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DateTime LastProtocolSupportUpdate
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int QueuedRequests
		{
			get
			{
				return default(int);
			}
		}

		public LoggingContext Context
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

		public HostConnection(HostDefinition host, string variantId)
		{
		}

		internal void AddProtocol(HostProtocolSupport protocolSupport)
		{
		}

		internal HostConnection Send(HTTPRequest request)
		{
			return null;
		}

		internal ConnectionBase GetNextAvailable(HTTPRequest request)
		{
			return null;
		}

		internal HostConnection RecycleConnection(ConnectionBase conn)
		{
			return null;
		}

		internal HostConnection RemoveConnection(ConnectionBase conn, HTTPConnectionStates setState)
		{
			return null;
		}

		internal HostConnection TryToSendQueuedRequests()
		{
			return null;
		}

		private bool CloseConnectionAfterInactivity(DateTime now, object context)
		{
			return default(bool);
		}

		internal void Shutdown()
		{
		}

		internal void SaveTo(BinaryWriter bw)
		{
		}

		internal void LoadFrom(int version, BinaryReader br)
		{
		}
	}
}
