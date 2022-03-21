using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BestHTTP.SocketIO.Transports
{
	public sealed class PollingTransport : ITransport
	{
		public enum PayloadTypes : byte
		{
			Text,
			Binary
		}

		private HTTPRequest LastRequest;

		private HTTPRequest PollRequest;

		private Packet PacketWithAttachment;

		private List<Packet> lonelyPacketList;

		private StringBuilder sendBuilder;

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

		public PollingTransport(SocketManager manager)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void Send(Packet packet)
		{
		}

		public void Send(List<Packet> packets)
		{
		}

		private void SendV3(List<Packet> packets, HTTPRequest request)
		{
		}

		private void SendV2(List<Packet> packets, HTTPRequest request)
		{
		}

		private void OnRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		public void Poll()
		{
		}

		private void OnPollRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		private void OnPacket(Packet packet)
		{
		}

		private SupportedSocketIOVersions GetServerVersion(HTTPResponse resp)
		{
			return default(SupportedSocketIOVersions);
		}

		private void ParseResponse(HTTPResponse resp)
		{
		}

		private void ParseResponseV3(HTTPResponse resp)
		{
		}

		private int FindNextRecordSeparator(byte[] data, int startIdx)
		{
			return default(int);
		}

		private void ParseResponseV2(HTTPResponse resp)
		{
		}
	}
}
