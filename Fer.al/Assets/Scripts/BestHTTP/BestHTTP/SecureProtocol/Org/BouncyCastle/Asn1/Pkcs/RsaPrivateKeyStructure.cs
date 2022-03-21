using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
{
	public class RsaPrivateKeyStructure : Asn1Encodable
	{
		private readonly BigInteger modulus;

		private readonly BigInteger publicExponent;

		private readonly BigInteger privateExponent;

		private readonly BigInteger prime1;

		private readonly BigInteger prime2;

		private readonly BigInteger exponent1;

		private readonly BigInteger exponent2;

		private readonly BigInteger coefficient;

		public BigInteger Modulus
		{
			get
			{
				return null;
			}
		}

		public BigInteger PublicExponent
		{
			get
			{
				return null;
			}
		}

		public BigInteger PrivateExponent
		{
			get
			{
				return null;
			}
		}

		public BigInteger Prime1
		{
			get
			{
				return null;
			}
		}

		public BigInteger Prime2
		{
			get
			{
				return null;
			}
		}

		public BigInteger Exponent1
		{
			get
			{
				return null;
			}
		}

		public BigInteger Exponent2
		{
			get
			{
				return null;
			}
		}

		public BigInteger Coefficient
		{
			get
			{
				return null;
			}
		}

		public static RsaPrivateKeyStructure GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		public static RsaPrivateKeyStructure GetInstance(object obj)
		{
			return null;
		}

		public RsaPrivateKeyStructure(BigInteger modulus, BigInteger publicExponent, BigInteger privateExponent, BigInteger prime1, BigInteger prime2, BigInteger exponent1, BigInteger exponent2, BigInteger coefficient)
		{
		}

		public RsaPrivateKeyStructure(Asn1Sequence seq)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
