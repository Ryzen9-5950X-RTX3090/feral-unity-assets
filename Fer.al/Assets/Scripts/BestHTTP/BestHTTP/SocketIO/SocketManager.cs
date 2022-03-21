using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.Extensions;
using BestHTTP.SocketIO.JsonEncoders;
using BestHTTP.SocketIO.Transports;

namespace BestHTTP.SocketIO
{
	public sealed class SocketManager : IHeartbeat, IManager
	{
		public enum States
		{
			Initial,
			Opening,
			Open,
			Paused,
			Reconnecting,
			Closed
		}

		public static IJsonEncoder DefaultEncoder;

		private States state;

		private int nextAckId;

		private Dictionary<string, Socket> Namespaces;

		private List<Socket> Sockets;

		private List<Packet> OfflinePackets;

		private DateTime LastHeartbeat;

		private DateTime ReconnectAt;

		private DateTime ConnectionStarted;

		private bool closing;

		private bool IsWaitingPong;

		private DateTime lastPingReceived;

		public int ProtocolVersion
		{
			get
			{
				return default(int);
			}
		}

		public States State
		{
			get
			{
				return default(States);
			}
			private set
			{
			}
		}

		public SocketOptions Options
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

		public Uri Uri
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

		public HandshakeData Handshake
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

		public ITransport Transport
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

		public ulong RequestCounter
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Socket Socket
		{
			get
			{
				return null;
			}
		}

		public Socket this[string nsp]
		{
			get
			{
				return null;
			}
		}

		public int ReconnectAttempts
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

		public IJsonEncoder Encoder
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

		internal ulong Timestamp
		{
			get
			{
				return default(ulong);
			}
		}

		internal int NextAckId
		{
			get
			{
				return default(int);
			}
		}

		internal States PreviousState
		{
			[CompilerGenerated]
			get
			{
				return default(States);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal ITransport UpgradingTransport
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

		public SocketManager(Uri uri)
		{
		}

		public SocketManager(Uri uri, SocketOptions options)
		{
		}

		public Socket GetSocket()
		{
			return null;
		}

		public Socket GetSocket(string nsp)
		{
			return null;
		}

		void IManager.Remove(Socket socket)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		void IManager.Close(bool removeSockets)
		{
		}

		void IManager.TryToReconnect()
		{
		}

		bool IManager.OnTransportConnected(ITransport trans)
		{
			return default(bool);
		}

		void IManager.OnTransportError(ITransport trans, string err)
		{
		}

		void IManager.OnTransportProbed(ITransport trans)
		{
		}

		private ITransport SelectTransport()
		{
			return null;
		}

		private void SendOfflinePackets()
		{
		}

		void IManager.SendPacket(Packet packet)
		{
		}

		void IManager.OnPacket(Packet packet)
		{
		}

		public void EmitAll(string eventName, object[] args)
		{
		}

		void IManager.EmitEvent(string eventName, object[] args)
		{
		}

		void IManager.EmitEvent(SocketIOEventTypes type, object[] args)
		{
		}

		void IManager.EmitError(SocketIOErrors errCode, string msg)
		{
		}

		void IManager.EmitAll(string eventName, object[] args)
		{
		}

		void IHeartbeat.OnHeartbeatUpdate(TimeSpan dif)
		{
		}
	}
}
