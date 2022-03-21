using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.GZip
{
	public class GZipInputStream : InflaterInputStream
	{
		protected Crc32 crc;

		private bool readGZIPHeader;

		public GZipInputStream(Stream baseInputStream)
		{
		}

		public GZipInputStream(Stream baseInputStream, int size)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		private bool ReadHeader()
		{
			return default(bool);
		}

		private void ReadFooter()
		{
		}
	}
}
