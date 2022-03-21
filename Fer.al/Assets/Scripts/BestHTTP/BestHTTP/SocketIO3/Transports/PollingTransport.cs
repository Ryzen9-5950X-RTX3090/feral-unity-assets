using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BestHTTP.SocketIO3.Transports
{
	public sealed class PollingTransport : ITransport
	{
		private HTTPRequest LastRequest;

		private HTTPRequest PollRequest;

		private List<OutgoingPacket> lonelyPacketList;

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

		public void Send(OutgoingPacket packet)
		{
		}

		public void Send(List<OutgoingPacket> packets)
		{
		}

		private void EncodePackets(List<OutgoingPacket> packets, HTTPRequest request)
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

		private void OnPacket(IncomingPacket packet)
		{
		}

		private void ParseResponse(HTTPResponse resp)
		{
		}

		private int FindNextRecordSeparator(byte[] data, int startIdx)
		{
			return default(int);
		}
	}
}
