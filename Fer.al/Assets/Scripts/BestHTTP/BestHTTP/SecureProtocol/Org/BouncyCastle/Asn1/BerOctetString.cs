using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class BerOctetString : DerOctetString, IEnumerable
	{
		private static readonly int DefaultChunkSize;

		private readonly int chunkSize;

		private readonly Asn1OctetString[] octs;

		public static BerOctetString FromSequence(Asn1Sequence seq)
		{
			return null;
		}

		private static byte[] ToBytes(Asn1OctetString[] octs)
		{
			return null;
		}

		private static Asn1OctetString[] ToOctetStringArray(IEnumerable e)
		{
			return null;
		}

		public BerOctetString(IEnumerable e)
		{
		}

		public BerOctetString(byte[] str)
		{
		}

		public BerOctetString(Asn1OctetString[] octs)
		{
		}

		public BerOctetString(byte[] str, int chunkSize)
		{
		}

		public BerOctetString(Asn1OctetString[] octs, int chunkSize)
		{
		}

		private BerOctetString(byte[] str, Asn1OctetString[] octs, int chunkSize)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public IEnumerator GetObjects()
		{
			return null;
		}

		private IList GenerateOcts()
		{
			return null;
		}

		internal override void Encode(DerOutputStream derOut)
		{
		}
	}
}
