using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	internal class DefiniteLengthInputStream : LimitedInputStream
	{
		private static readonly byte[] EmptyBytes;

		private readonly int _originalLength;

		private int _remaining;

		internal int Remaining
		{
			get
			{
				return default(int);
			}
		}

		internal DefiniteLengthInputStream(Stream inStream, int length, int limit)
		{
		}

		public override int ReadByte()
		{
			return default(int);
		}

		public override int Read(byte[] buf, int off, int len)
		{
			return default(int);
		}

		internal void ReadAllIntoByteArray(byte[] buf)
		{
		}

		internal byte[] ToArray()
		{
			return null;
		}
	}
}
