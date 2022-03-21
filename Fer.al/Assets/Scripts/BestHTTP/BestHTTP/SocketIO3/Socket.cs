using System;
using System.Runtime.CompilerServices;
using BestHTTP.Logger;
using BestHTTP.SocketIO3.Events;

namespace BestHTTP.SocketIO3
{
	public sealed class Socket : ISocket
	{
		internal TypedEventTable TypedEventTable;

		private IncomingPacket currentPacket;

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

		internal Socket(string nsp, SocketManager manager)
		{
		}

		private void OnConnected(ConnectResponse resp)
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

		public EmitBuilder Volatile()
		{
			return default(EmitBuilder);
		}

		public EmitBuilder ExpectAcknowledgement(Action callback)
		{
			return default(EmitBuilder);
		}

		public EmitBuilder ExpectAcknowledgement<T>(Action<T> callback)
		{
			return default(EmitBuilder);
		}

		public Socket Emit(string eventName, object[] args)
		{
			return null;
		}

		public Socket EmitAck(object[] args)
		{
			return null;
		}

		public void On(SocketIOEventTypes eventType, Action callback)
		{
		}

		public void On<T>(SocketIOEventTypes eventType, Action<T> callback)
		{
		}

		public void On(string eventName, Action callback)
		{
		}

		public void On<T>(string eventName, Action<T> callback)
		{
		}

		public void On<T1, T2>(string eventName, Action<T1, T2> callback)
		{
		}

		public void On<T1, T2, T3>(string eventName, Action<T1, T2, T3> callback)
		{
		}

		public void On<T1, T2, T3, T4>(string eventName, Action<T1, T2, T3, T4> callback)
		{
		}

		public void On<T1, T2, T3, T4, T5>(string eventName, Action<T1, T2, T3, T4, T5> callback)
		{
		}

		public void Once(string eventName, Action callback)
		{
		}

		public void Once<T>(string eventName, Action<T> callback)
		{
		}

		public void Once<T1, T2>(string eventName, Action<T1, T2> callback)
		{
		}

		public void Once<T1, T2, T3>(string eventName, Action<T1, T2, T3> callback)
		{
		}

		public void Once<T1, T2, T3, T4>(string eventName, Action<T1, T2, T3, T4> callback)
		{
		}

		public void Once<T1, T2, T3, T4, T5>(string eventName, Action<T1, T2, T3, T4, T5> callback)
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

		void ISocket.OnPacket(IncomingPacket packet)
		{
		}

		public Subscription GetSubscription(string name)
		{
			return null;
		}

		void ISocket.EmitEvent(SocketIOEventTypes type, object[] args)
		{
		}

		void ISocket.EmitEvent(string eventName, object[] args)
		{
		}

		void ISocket.EmitError(string msg)
		{
		}

		internal void OnTransportOpen()
		{
		}
	}
}
