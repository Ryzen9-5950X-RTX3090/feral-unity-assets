namespace Unity.IO.Compression
{
	internal class InputBuffer
	{
		private byte[] buffer;

		private int start;

		private int end;

		private uint bitBuffer;

		private int bitsInBuffer;

		public int AvailableBits
		{
			get
			{
				return default(int);
			}
		}

		public int AvailableBytes
		{
			get
			{
				return default(int);
			}
		}

		public bool EnsureBitsAvailable(int count)
		{
			return default(bool);
		}

		public uint TryLoad16Bits()
		{
			return default(uint);
		}

		private uint GetBitMask(int count)
		{
			return default(uint);
		}

		public int GetBits(int count)
		{
			return default(int);
		}

		public int CopyTo(byte[] output, int offset, int length)
		{
			return default(int);
		}

		public bool NeedsInput()
		{
			return default(bool);
		}

		public void SetInput(byte[] buffer, int offset, int length)
		{
		}

		public void SkipBits(int n)
		{
		}

		public void SkipToByteBoundary()
		{
		}
	}
}
