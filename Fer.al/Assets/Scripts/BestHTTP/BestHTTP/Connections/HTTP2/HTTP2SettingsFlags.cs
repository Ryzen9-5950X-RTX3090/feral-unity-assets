using System;

namespace BestHTTP.Connections.HTTP2
{
	[Flags]
	internal enum HTTP2SettingsFlags : byte
	{
		None = 0,
		ACK = 1
	}
}
