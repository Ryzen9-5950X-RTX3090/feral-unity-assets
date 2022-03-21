using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class DHPublicKeyParameters : DHKeyParameters
	{
		private readonly BigInteger y;

		public virtual BigInteger Y
		{
			get
			{
				return null;
			}
		}

		private static BigInteger Validate(BigInteger y, DHParameters dhParams)
		{
			return null;
		}

		public DHPublicKeyParameters(BigInteger y, DHParameters parameters)
		{
		}

		public DHPublicKeyParameters(BigInteger y, DHParameters parameters, DerObjectIdentifier algorithmOid)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected bool Equals(DHPublicKeyParameters other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
