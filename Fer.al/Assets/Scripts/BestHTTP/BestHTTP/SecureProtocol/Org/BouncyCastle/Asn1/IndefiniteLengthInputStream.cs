using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	internal class IndefiniteLengthInputStream : LimitedInputStream
	{
		private int _lookAhead;

		private bool _eofOn00;

		internal IndefiniteLengthInputStream(Stream inStream, int limit)
		{
		}

		internal void SetEofOn00(bool eofOn00)
		{
		}

		private bool CheckForEof()
		{
			return default(bool);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		public override int ReadByte()
		{
			return default(int);
		}

		private int RequireByte()
		{
			return default(int);
		}
	}
}
