using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.WebSocket;

namespace BestHTTP.SocketIO.Transports
{
	internal sealed class WebSocketTransport : ITransport
	{
		private Packet PacketWithAttachment;

		private byte[] Buffer;

		public TransportTypes Type
		{
			get
			{
				return default(TransportTypes);
			}
		}

		public TransportStates State
		{
			[CompilerGenerated]
			get
			{
				return default(TransportStates);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

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

		public bool IsRequestInProgress
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsPollingInProgress
		{
			get
			{
				return default(bool);
			}
		}

		public BestHTTP.WebSocket.WebSocket Implementation
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

		public WebSocketTransport(SocketManager manager)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void Poll()
		{
		}

		private void OnOpen(BestHTTP.WebSocket.WebSocket ws)
		{
		}

		private void OnMessage(BestHTTP.WebSocket.WebSocket ws, string message)
		{
		}

		private void OnBinary(BestHTTP.WebSocket.WebSocket ws, byte[] data)
		{
		}

		private void OnError(BestHTTP.WebSocket.WebSocket ws, string error)
		{
		}

		private void OnClosed(BestHTTP.WebSocket.WebSocket ws, ushort code, string message)
		{
		}

		public void Send(Packet packet)
		{
		}

		public void Send(List<Packet> packets)
		{
		}

		private void OnPacket(Packet packet)
		{
		}
	}
}
