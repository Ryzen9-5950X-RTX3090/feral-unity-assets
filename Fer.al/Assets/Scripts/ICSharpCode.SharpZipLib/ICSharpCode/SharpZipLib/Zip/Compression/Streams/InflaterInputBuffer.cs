using System.IO;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class InflaterInputBuffer
	{
		private int rawLength;

		private byte[] rawData;

		private int clearTextLength;

		private byte[] clearText;

		private int available;

		private ICryptoTransform cryptoTransform;

		private Stream inputStream;

		public int RawLength
		{
			get
			{
				return default(int);
			}
		}

		public int Available
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public InflaterInputBuffer(Stream stream, int bufferSize)
		{
		}

		public void SetInflaterInput(Inflater inflater)
		{
		}

		public void Fill()
		{
		}

		public int ReadClearTextBuffer(byte[] outBuffer, int offset, int length)
		{
			return default(int);
		}

		public int ReadLeByte()
		{
			return default(int);
		}
	}
}
