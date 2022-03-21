using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class Gost3410PublicKeyParameters : Gost3410KeyParameters
	{
		private readonly BigInteger y;

		public BigInteger Y
		{
			get
			{
				return null;
			}
		}

		public Gost3410PublicKeyParameters(BigInteger y, Gost3410Parameters parameters)
		{
		}

		public Gost3410PublicKeyParameters(BigInteger y, DerObjectIdentifier publicKeyParamSet)
		{
		}
	}
}
