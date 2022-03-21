using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class ECPublicKeyParameters : ECKeyParameters
	{
		private readonly ECPoint q;

		public ECPoint Q
		{
			get
			{
				return null;
			}
		}

		public ECPublicKeyParameters(ECPoint q, ECDomainParameters parameters)
		{
		}

		public ECPublicKeyParameters(ECPoint q, DerObjectIdentifier publicKeyParamSet)
		{
		}

		public ECPublicKeyParameters(string algorithm, ECPoint q, ECDomainParameters parameters)
		{
		}

		public ECPublicKeyParameters(string algorithm, ECPoint q, DerObjectIdentifier publicKeyParamSet)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected bool Equals(ECPublicKeyParameters other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
