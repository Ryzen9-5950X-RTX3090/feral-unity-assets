using System.IO;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption
{
	internal class ZipAESStream : CryptoStream
	{
		private Stream _stream;

		private ZipAESTransform _transform;

		private byte[] _slideBuffer;

		private int _slideBufStartPos;

		private int _slideBufFreePos;

		private int _blockAndAuth;

		public ZipAESStream(Stream stream, ZipAESTransform transform, CryptoStreamMode mode)
		{
		}

		public override int Read(byte[] outBuffer, int offset, int count)
		{
			return default(int);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
}
