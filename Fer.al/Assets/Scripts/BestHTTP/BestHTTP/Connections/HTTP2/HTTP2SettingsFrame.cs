using System.Collections.Generic;

namespace BestHTTP.Connections.HTTP2
{
	internal struct HTTP2SettingsFrame
	{
		public readonly HTTP2FrameHeaderAndPayload Header;

		public List<KeyValuePair<HTTP2Settings, uint>> Settings;

		public HTTP2SettingsFlags Flags
		{
			get
			{
				return default(HTTP2SettingsFlags);
			}
		}

		public HTTP2SettingsFrame(HTTP2FrameHeaderAndPayload header)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
