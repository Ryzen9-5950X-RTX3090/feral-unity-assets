namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class SM2KeyExchangePublicParameters : ICipherParameters
	{
		private readonly ECPublicKeyParameters mStaticPublicKey;

		private readonly ECPublicKeyParameters mEphemeralPublicKey;

		public virtual ECPublicKeyParameters StaticPublicKey
		{
			get
			{
				return null;
			}
		}

		public virtual ECPublicKeyParameters EphemeralPublicKey
		{
			get
			{
				return null;
			}
		}

		public SM2KeyExchangePublicParameters(ECPublicKeyParameters staticPublicKey, ECPublicKeyParameters ephemeralPublicKey)
		{
		}
	}
}
