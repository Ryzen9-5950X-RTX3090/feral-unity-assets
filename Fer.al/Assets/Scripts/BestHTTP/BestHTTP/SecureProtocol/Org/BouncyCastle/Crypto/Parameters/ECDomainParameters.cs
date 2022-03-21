using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class ECDomainParameters
	{
		private readonly ECCurve curve;

		private readonly byte[] seed;

		private readonly ECPoint g;

		private readonly BigInteger n;

		private readonly BigInteger h;

		private BigInteger hInv;

		public ECCurve Curve
		{
			get
			{
				return null;
			}
		}

		public ECPoint G
		{
			get
			{
				return null;
			}
		}

		public BigInteger N
		{
			get
			{
				return null;
			}
		}

		public BigInteger H
		{
			get
			{
				return null;
			}
		}

		public BigInteger HInv
		{
			get
			{
				return null;
			}
		}

		public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n)
		{
		}

		public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n, BigInteger h)
		{
		}

		public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n, BigInteger h, byte[] seed)
		{
		}

		public byte[] GetSeed()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected virtual bool Equals(ECDomainParameters other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public BigInteger ValidatePrivateScalar(BigInteger d)
		{
			return null;
		}

		public ECPoint ValidatePublicPoint(ECPoint q)
		{
			return null;
		}

		internal static ECPoint ValidatePublicPoint(ECCurve c, ECPoint q)
		{
			return null;
		}
	}
}
