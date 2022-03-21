using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
	public class CmsTypedStream
	{
		private class FullReaderStream : FilterStream
		{
			internal FullReaderStream(Stream input)
			{
			}

			public override int Read(byte[] buf, int off, int len)
			{
				return default(int);
			}
		}

		private const int BufferSize = 32768;

		private readonly string _oid;

		private readonly Stream _in;

		public string ContentType
		{
			get
			{
				return null;
			}
		}

		public Stream ContentStream
		{
			get
			{
				return null;
			}
		}

		public CmsTypedStream(Stream inStream)
		{
		}

		public CmsTypedStream(string oid, Stream inStream)
		{
		}

		public CmsTypedStream(string oid, Stream inStream, int bufSize)
		{
		}

		public void Drain()
		{
		}
	}
}
