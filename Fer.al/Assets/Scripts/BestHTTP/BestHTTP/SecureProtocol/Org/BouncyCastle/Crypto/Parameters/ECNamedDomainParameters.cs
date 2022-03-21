using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class ECNamedDomainParameters : ECDomainParameters
	{
		private readonly DerObjectIdentifier name;

		public DerObjectIdentifier Name
		{
			get
			{
				return null;
			}
		}

		public ECNamedDomainParameters(DerObjectIdentifier name, ECDomainParameters dp)
		{
		}

		public ECNamedDomainParameters(DerObjectIdentifier name, ECCurve curve, ECPoint g, BigInteger n)
		{
		}

		public ECNamedDomainParameters(DerObjectIdentifier name, ECCurve curve, ECPoint g, BigInteger n, BigInteger h)
		{
		}

		public ECNamedDomainParameters(DerObjectIdentifier name, ECCurve curve, ECPoint g, BigInteger n, BigInteger h, byte[] seed)
		{
		}
	}
}
