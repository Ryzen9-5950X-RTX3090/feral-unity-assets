using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
	public class Pkcs5Scheme2Utf8PbeKey : CmsPbeKey
	{
		public Pkcs5Scheme2Utf8PbeKey(string password, byte[] salt, int iterationCount)
		{
		}

		public Pkcs5Scheme2Utf8PbeKey(string password, AlgorithmIdentifier keyDerivationAlgorithm)
		{
		}

		public Pkcs5Scheme2Utf8PbeKey(char[] password, byte[] salt, int iterationCount)
		{
		}

		public Pkcs5Scheme2Utf8PbeKey(char[] password, AlgorithmIdentifier keyDerivationAlgorithm)
		{
		}

		internal override KeyParameter GetEncoded(string algorithmOid)
		{
			return null;
		}
	}
}
