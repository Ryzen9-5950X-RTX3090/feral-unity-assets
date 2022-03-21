using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class RsaKeyParameters : AsymmetricKeyParameter
	{
		private static readonly BigInteger SmallPrimesProduct;

		private readonly BigInteger modulus;

		private readonly BigInteger exponent;

		public BigInteger Modulus
		{
			get
			{
				return null;
			}
		}

		public BigInteger Exponent
		{
			get
			{
				return null;
			}
		}

		private static BigInteger Validate(BigInteger modulus)
		{
			return null;
		}

		public RsaKeyParameters(bool isPrivate, BigInteger modulus, BigInteger exponent)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
