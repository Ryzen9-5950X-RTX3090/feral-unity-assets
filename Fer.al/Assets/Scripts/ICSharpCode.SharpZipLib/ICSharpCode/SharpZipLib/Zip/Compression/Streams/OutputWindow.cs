namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class OutputWindow
	{
		private byte[] window;

		private int windowEnd;

		private int windowFilled;

		public void Write(int value)
		{
		}

		private void SlowRepeat(int repStart, int length, int distance)
		{
		}

		public void Repeat(int length, int distance)
		{
		}

		public int CopyStored(StreamManipulator input, int length)
		{
			return default(int);
		}

		public int GetFreeSpace()
		{
			return default(int);
		}

		public int GetAvailable()
		{
			return default(int);
		}

		public int CopyOutput(byte[] output, int offset, int len)
		{
			return default(int);
		}

		public void Reset()
		{
		}
	}
}
