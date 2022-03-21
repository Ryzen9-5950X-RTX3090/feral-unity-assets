using System.Runtime.CompilerServices;

namespace BestHTTP.Core
{
	[IsReadOnly]
	public struct RequestEventInfo
	{
		public readonly HTTPRequest SourceRequest;

		public readonly RequestEvents Event;

		public readonly HTTPRequestStates State;

		public readonly long Progress;

		public readonly long ProgressLength;

		public readonly byte[] Data;

		public readonly int DataLength;

		public RequestEventInfo(HTTPRequest request, RequestEvents @event)
		{
		}

		public RequestEventInfo(HTTPRequest request, HTTPRequestStates newState)
		{
		}

		public RequestEventInfo(HTTPRequest request, RequestEvents @event, long progress, long progressLength)
		{
		}

		public RequestEventInfo(HTTPRequest request, byte[] data, int dataLength)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
