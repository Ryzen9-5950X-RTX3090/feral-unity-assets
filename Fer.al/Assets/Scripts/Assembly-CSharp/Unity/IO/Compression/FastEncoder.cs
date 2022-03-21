namespace Unity.IO.Compression
{
	internal class FastEncoder
	{
		private FastEncoderWindow inputWindow;

		private Match currentMatch;

		private double lastCompressionRatio;

		internal int BytesInHistory
		{
			get
			{
				return default(int);
			}
		}

		internal DeflateInput UnprocessedInput
		{
			get
			{
				return null;
			}
		}

		internal double LastCompressionRatio
		{
			get
			{
				return default(double);
			}
		}

		internal void FlushInput()
		{
		}

		internal void GetBlock(DeflateInput input, OutputBuffer output, int maxBytesToCopy)
		{
		}

		internal void GetCompressedData(DeflateInput input, OutputBuffer output)
		{
		}

		internal void GetBlockHeader(OutputBuffer output)
		{
		}

		internal void GetBlockFooter(OutputBuffer output)
		{
		}

		private void GetCompressedOutput(DeflateInput input, OutputBuffer output, int maxBytesToCopy)
		{
		}

		private void GetCompressedOutput(OutputBuffer output)
		{
		}

		private bool InputAvailable(DeflateInput input)
		{
			return default(bool);
		}

		private bool SafeToWriteTo(OutputBuffer output)
		{
			return default(bool);
		}

		private void WriteEndOfBlock(OutputBuffer output)
		{
		}

		internal static void WriteMatch(int matchLen, int matchPos, OutputBuffer output)
		{
		}

		internal static void WriteChar(byte b, OutputBuffer output)
		{
		}

		internal static void WriteDeflatePreamble(OutputBuffer output)
		{
		}
	}
}
