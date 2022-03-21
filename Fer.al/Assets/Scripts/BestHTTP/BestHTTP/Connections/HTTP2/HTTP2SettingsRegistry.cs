using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.Connections.HTTP2
{
	internal sealed class HTTP2SettingsRegistry
	{
		public Action<HTTP2SettingsRegistry, HTTP2Settings, uint, uint> OnSettingChangedEvent;

		private uint[] values;

		private bool[] changeFlags;

		private HTTP2SettingsManager _parent;

		public bool IsReadOnly
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public uint this[HTTP2Settings setting]
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public bool IsChanged
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public HTTP2SettingsRegistry(HTTP2SettingsManager parent, bool readOnly, bool treatItAsAlreadyChanged)
		{
		}

		public void Merge(List<KeyValuePair<HTTP2Settings, uint>> settings)
		{
		}

		public void Merge(HTTP2SettingsRegistry from)
		{
		}

		public HTTP2FrameHeaderAndPayload CreateFrame()
		{
			return default(HTTP2FrameHeaderAndPayload);
		}
	}
}
