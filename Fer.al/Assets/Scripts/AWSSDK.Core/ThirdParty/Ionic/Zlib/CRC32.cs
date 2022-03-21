using System.IO;

namespace ThirdParty.Ionic.Zlib
{
	internal class CRC32
	{
		private long _TotalBytesRead;

		private static uint[] crc32Table;

		private const int BUFFER_SIZE = 8192;

		private uint _RunningCrc32Result;

		public long TotalBytesRead
		{
			get
			{
				return default(long);
			}
		}

		public int Crc32Result
		{
			get
			{
				return default(int);
			}
		}

		public int GetCrc32(Stream input)
		{
			return default(int);
		}

		public int GetCrc32AndCopy(Stream input, Stream output)
		{
			return default(int);
		}

		public int ComputeCrc32(int W, byte B)
		{
			return default(int);
		}

		internal int _InternalComputeCrc32(uint W, byte B)
		{
			return default(int);
		}

		public void SlurpBlock(byte[] block, int offset, int count)
		{
		}

		static CRC32()
		{
		}
	}
}
