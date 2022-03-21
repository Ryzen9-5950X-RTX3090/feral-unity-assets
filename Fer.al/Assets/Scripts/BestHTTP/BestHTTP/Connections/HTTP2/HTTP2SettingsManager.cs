using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.Connections.HTTP2
{
	internal sealed class HTTP2SettingsManager
	{
		public static readonly int SettingsCount;

		public HTTP2SettingsRegistry MySettings
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

		public HTTP2SettingsRegistry InitiatedMySettings
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

		public HTTP2SettingsRegistry RemoteSettings
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

		public DateTime SettingsChangesSentAt
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public HTTP2Handler Parent
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

		public HTTP2SettingsManager(HTTP2Handler parentHandler)
		{
		}

		public void Process(HTTP2FrameHeaderAndPayload frame, List<HTTP2FrameHeaderAndPayload> outgoingFrames)
		{
		}

		public void SendChanges(List<HTTP2FrameHeaderAndPayload> outgoingFrames)
		{
		}
	}
}
