using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class DsaPublicKeyParameters : DsaKeyParameters
	{
		private readonly BigInteger y;

		public BigInteger Y
		{
			get
			{
				return null;
			}
		}

		private static BigInteger Validate(BigInteger y, DsaParameters parameters)
		{
			return null;
		}

		public DsaPublicKeyParameters(BigInteger y, DsaParameters parameters)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected bool Equals(DsaPublicKeyParameters other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
