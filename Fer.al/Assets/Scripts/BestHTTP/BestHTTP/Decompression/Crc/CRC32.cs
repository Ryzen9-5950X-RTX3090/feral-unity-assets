using System.IO;

namespace BestHTTP.Decompression.Crc
{
	internal class CRC32
	{
		private uint dwPolynomial;

		private long _TotalBytesRead;

		private bool reverseBits;

		private uint[] crc32Table;

		private const int BUFFER_SIZE = 8192;

		private uint _register;

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

		public void UpdateCRC(byte b)
		{
		}

		public void UpdateCRC(byte b, int n)
		{
		}

		private static uint ReverseBits(uint data)
		{
			return default(uint);
		}

		private static byte ReverseBits(byte data)
		{
			return default(byte);
		}

		private void GenerateLookupTable()
		{
		}

		private uint gf2_matrix_times(uint[] matrix, uint vec)
		{
			return default(uint);
		}

		private void gf2_matrix_square(uint[] square, uint[] mat)
		{
		}

		public void Combine(int crc, int length)
		{
		}

		public CRC32()
		{
		}

		public CRC32(bool reverseBits)
		{
		}

		public CRC32(int polynomial, bool reverseBits)
		{
		}

		public void Reset()
		{
		}
	}
}
