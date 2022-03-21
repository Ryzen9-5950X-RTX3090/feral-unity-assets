namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class StreamManipulator
	{
		private byte[] window_;

		private int windowStart_;

		private int windowEnd_;

		private uint buffer_;

		private int bitsInBuffer_;

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

		public bool IsNeedingInput
		{
			get
			{
				return default(bool);
			}
		}

		public int PeekBits(int bitCount)
		{
			return default(int);
		}

		public void DropBits(int bitCount)
		{
		}

		public void SkipToByteBoundary()
		{
		}

		public int CopyBytes(byte[] output, int offset, int length)
		{
			return default(int);
		}

		public void Reset()
		{
		}

		public void SetInput(byte[] buffer, int offset, int count)
		{
		}
	}
}
