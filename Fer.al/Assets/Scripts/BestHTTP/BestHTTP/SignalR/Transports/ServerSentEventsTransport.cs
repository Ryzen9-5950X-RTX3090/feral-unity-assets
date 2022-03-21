using BestHTTP.ServerSentEvents;

namespace BestHTTP.SignalR.Transports
{
	public sealed class ServerSentEventsTransport : PostSendTransportBase
	{
		private EventSource EventSource;

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

		public ServerSentEventsTransport(Connection con)
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

		public override void Abort()
		{
		}

		protected override void Aborted()
		{
		}

		private void OnEventSourceOpen(EventSource eventSource)
		{
		}

		private void OnEventSourceMessage(EventSource eventSource, Message message)
		{
		}

		private void OnEventSourceError(EventSource eventSource, string error)
		{
		}

		private void OnEventSourceClosed(EventSource eventSource)
		{
		}
	}
}
