using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	public sealed class ZipExtraData : IDisposable
	{
		private int _index;

		private int _readValueStart;

		private int _readValueLength;

		private MemoryStream _newEntry;

		private byte[] _data;

		public int ValueLength
		{
			get
			{
				return default(int);
			}
		}

		public int UnreadCount
		{
			get
			{
				return default(int);
			}
		}

		public ZipExtraData(byte[] data)
		{
		}

		public bool Find(int headerID)
		{
			return default(bool);
		}

		public long ReadLong()
		{
			return default(long);
		}

		public int ReadInt()
		{
			return default(int);
		}

		public int ReadShort()
		{
			return default(int);
		}

		public int ReadByte()
		{
			return default(int);
		}

		public void Skip(int amount)
		{
		}

		private void ReadCheck(int length)
		{
		}

		private int ReadShortInternal()
		{
			return default(int);
		}

		public void Dispose()
		{
		}
	}
}
