using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.SocketIO.Events;

namespace BestHTTP.SocketIO
{
	public sealed class Socket : ISocket
	{
		private Dictionary<int, SocketIOAckCallback> AckCallbacks;

		private EventTable EventCallbacks;

		private List<object> arguments;

		public SocketManager Manager
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

		public string Namespace
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

		public string Id
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

		public bool IsOpen
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

		public bool AutoDecodePayload
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

		internal Socket(string nsp, SocketManager manager)
		{
		}

		void ISocket.Open()
		{
		}

		public void Disconnect()
		{
		}

		void ISocket.Disconnect(bool remove)
		{
		}

		public Socket Emit(string eventName, object[] args)
		{
			return null;
		}

		public Socket Emit(string eventName, SocketIOAckCallback callback, object[] args)
		{
			return null;
		}

		public Socket EmitAck(Packet originalPacket, object[] args)
		{
			return null;
		}

		public void On(string eventName, SocketIOCallback callback)
		{
		}

		public void On(SocketIOEventTypes type, SocketIOCallback callback)
		{
		}

		public void On(string eventName, SocketIOCallback callback, bool autoDecodePayload)
		{
		}

		public void On(SocketIOEventTypes type, SocketIOCallback callback, bool autoDecodePayload)
		{
		}

		public void Once(string eventName, SocketIOCallback callback)
		{
		}

		public void Once(SocketIOEventTypes type, SocketIOCallback callback)
		{
		}

		public void Once(string eventName, SocketIOCallback callback, bool autoDecodePayload)
		{
		}

		public void Once(SocketIOEventTypes type, SocketIOCallback callback, bool autoDecodePayload)
		{
		}

		public void Off()
		{
		}

		public void Off(string eventName)
		{
		}

		public void Off(SocketIOEventTypes type)
		{
		}

		public void Off(string eventName, SocketIOCallback callback)
		{
		}

		public void Off(SocketIOEventTypes type, SocketIOCallback callback)
		{
		}

		void ISocket.OnPacket(Packet packet)
		{
		}

		void ISocket.EmitEvent(SocketIOEventTypes type, object[] args)
		{
		}

		void ISocket.EmitEvent(string eventName, object[] args)
		{
		}

		void ISocket.EmitError(SocketIOErrors errCode, string msg)
		{
		}

		internal void OnTransportOpen()
		{
		}
	}
}
