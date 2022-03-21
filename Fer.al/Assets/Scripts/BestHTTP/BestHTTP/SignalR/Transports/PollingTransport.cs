using System;
using BestHTTP.Extensions;

namespace BestHTTP.SignalR.Transports
{
	public sealed class PollingTransport : PostSendTransportBase, IHeartbeat
	{
		private DateTime LastPoll;

		private TimeSpan PollDelay;

		private TimeSpan PollTimeout;

		private HTTPRequest pollRequest;

		public override bool SupportsKeepAlive
		{
			get
			{
				return default(bool);
			}
		}

		public override TransportTypes Type
		{
			get
			{
				return default(TransportTypes);
			}
		}

		public PollingTransport(Connection connection)
		{
		}

		public override void Connect()
		{
		}

		public override void Stop()
		{
		}

		protected override void Started()
		{
		}

		protected override void Aborted()
		{
		}

		private void OnConnectRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		private void OnPollRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		private void Poll()
		{
		}

		void IHeartbeat.OnHeartbeatUpdate(TimeSpan dif)
		{
		}
	}
}
