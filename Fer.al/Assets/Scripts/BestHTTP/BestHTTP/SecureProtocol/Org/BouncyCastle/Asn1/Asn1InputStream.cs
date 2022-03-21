using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class Asn1InputStream : FilterStream
	{
		private readonly int limit;

		private readonly byte[][] tmpBuffers;

		internal virtual int Limit
		{
			get
			{
				return default(int);
			}
		}

		internal static int FindLimit(Stream input)
		{
			return default(int);
		}

		public Asn1InputStream(Stream inputStream)
		{
		}

		public Asn1InputStream(Stream inputStream, int limit)
		{
		}

		public Asn1InputStream(byte[] input)
		{
		}

		private Asn1Object BuildObject(int tag, int tagNo, int length)
		{
			return null;
		}

		internal virtual Asn1EncodableVector ReadVector(DefiniteLengthInputStream dIn)
		{
			return null;
		}

		internal virtual DerSequence CreateDerSequence(DefiniteLengthInputStream dIn)
		{
			return null;
		}

		internal virtual DerSet CreateDerSet(DefiniteLengthInputStream dIn)
		{
			return null;
		}

		public Asn1Object ReadObject()
		{
			return null;
		}

		internal static int ReadTagNumber(Stream s, int tag)
		{
			return default(int);
		}

		internal static int ReadLength(Stream s, int limit, bool isParsing)
		{
			return default(int);
		}

		private static byte[] GetBuffer(DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
		{
			return null;
		}

		private static char[] GetBmpCharBuffer(DefiniteLengthInputStream defIn)
		{
			return null;
		}

		internal static Asn1Object CreatePrimitiveDerObject(int tagNo, DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
		{
			return null;
		}
	}
}
