using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
{
	public class KeyDerivationFunc : AlgorithmIdentifier
	{
		internal KeyDerivationFunc(Asn1Sequence seq)
		{
		}

		public KeyDerivationFunc(DerObjectIdentifier id, Asn1Encodable parameters)
		{
		}
	}
}
