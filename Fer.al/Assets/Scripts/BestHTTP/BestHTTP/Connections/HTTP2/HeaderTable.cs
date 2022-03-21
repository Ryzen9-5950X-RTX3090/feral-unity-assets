using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.Connections.HTTP2
{
	internal sealed class HeaderTable
	{
		private static string[] StaticTableValues;

		private static string[] StaticTable;

		private uint _maxDynamicTableSize;

		private List<KeyValuePair<string, string>> DynamicTable;

		private HTTP2SettingsRegistry settingsRegistry;

		public uint DynamicTableSize
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public uint MaxDynamicTableSize
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public HeaderTable(HTTP2SettingsRegistry registry)
		{
		}

		public KeyValuePair<uint, uint> GetIndex(string key, string value)
		{
			return default(KeyValuePair<uint, uint>);
		}

		public string GetKey(uint index)
		{
			return null;
		}

		public KeyValuePair<string, string> GetHeader(uint index)
		{
			return default(KeyValuePair<string, string>);
		}

		public void Add(KeyValuePair<string, string> header)
		{
		}

		private uint CalculateEntrySize(KeyValuePair<string, string> entry)
		{
			return default(uint);
		}

		private void EvictEntries(uint newHeaderSize)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
