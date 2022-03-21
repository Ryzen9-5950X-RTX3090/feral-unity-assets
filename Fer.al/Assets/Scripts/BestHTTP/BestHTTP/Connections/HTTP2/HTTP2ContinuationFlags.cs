using System;

namespace BestHTTP.Connections.HTTP2
{
	[Flags]
	internal enum HTTP2ContinuationFlags : byte
	{
		None = 0,
		END_HEADERS = 4
	}
}
