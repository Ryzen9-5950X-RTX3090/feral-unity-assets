using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class LazyAsn1InputStream : Asn1InputStream
	{
		public LazyAsn1InputStream(byte[] input)
		{
		}

		public LazyAsn1InputStream(Stream inputStream)
		{
		}

		internal override DerSequence CreateDerSequence(DefiniteLengthInputStream dIn)
		{
			return null;
		}

		internal override DerSet CreateDerSet(DefiniteLengthInputStream dIn)
		{
			return null;
		}
	}
}
