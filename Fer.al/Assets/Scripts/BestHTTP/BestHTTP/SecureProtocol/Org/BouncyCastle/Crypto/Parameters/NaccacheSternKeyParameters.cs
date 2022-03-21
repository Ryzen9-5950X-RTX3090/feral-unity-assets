using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class NaccacheSternKeyParameters : AsymmetricKeyParameter
	{
		private readonly BigInteger g;

		private readonly BigInteger n;

		private readonly int lowerSigmaBound;

		public BigInteger G
		{
			get
			{
				return null;
			}
		}

		public int LowerSigmaBound
		{
			get
			{
				return default(int);
			}
		}

		public BigInteger Modulus
		{
			get
			{
				return null;
			}
		}

		public NaccacheSternKeyParameters(bool privateKey, BigInteger g, BigInteger n, int lowerSigmaBound)
		{
		}
	}
}
