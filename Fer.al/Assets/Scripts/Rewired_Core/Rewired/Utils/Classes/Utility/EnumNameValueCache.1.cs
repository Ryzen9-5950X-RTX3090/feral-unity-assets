using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal sealed class EnumNameValueCache<TEnum> where TEnum : struct, IComparable, IFormattable
	{
		private static EnumNameValueCache<TEnum> cgQSKcLQtQfbpbkhJZbwNacwBwhD;

		private readonly ADictionary<string, TEnum> CUrJNaZhqqqBMbHtTsHDIviUqFc;

		private readonly string[] jxdcgvDAxvmxryXjKrUVKLjFIuy;

		private readonly long[] DOGjWfNqXhJwrYMCygTRCsZHQkS;

		public static EnumNameValueCache<TEnum> Default
		{
			get
			{
				return null;
			}
		}

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public static void Free()
		{
		}

		private EnumNameValueCache()
		{
		}

		public TEnum GetValue(string name)
		{
			return (TEnum)null;
		}

		public bool TryGetValue(string name, out TEnum value)
		{
			return default(bool);
		}

		public string GetName(long value)
		{
			return null;
		}

		public bool TryGetName(long value, out string name)
		{
			return default(bool);
		}

		public TEnum GetValueAt(int index)
		{
			return (TEnum)null;
		}

		public string GetNameAt(int index)
		{
			return null;
		}

		public int IndexOf(string name)
		{
			return default(int);
		}

		public int IndexOf(long value)
		{
			return default(int);
		}

		public bool Contains(string name)
		{
			return default(bool);
		}

		public bool Contains(long value)
		{
			return default(bool);
		}
	}
}
