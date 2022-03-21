using System.Runtime.CompilerServices;
using BestHTTP.Connections;

namespace BestHTTP.Core
{
	[IsReadOnly]
	public struct ConnectionEventInfo
	{
		public readonly ConnectionBase Source;

		public readonly ConnectionEvents Event;

		public readonly HTTPConnectionStates State;

		public readonly HostProtocolSupport ProtocolSupport;

		public readonly HTTPRequest Request;

		public ConnectionEventInfo(ConnectionBase sourceConn, ConnectionEvents @event)
		{
		}

		public ConnectionEventInfo(ConnectionBase sourceConn, HTTPConnectionStates newState)
		{
		}

		public ConnectionEventInfo(ConnectionBase sourceConn, HostProtocolSupport protocolSupport)
		{
		}

		public ConnectionEventInfo(ConnectionBase sourceConn, HTTPRequest request)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
