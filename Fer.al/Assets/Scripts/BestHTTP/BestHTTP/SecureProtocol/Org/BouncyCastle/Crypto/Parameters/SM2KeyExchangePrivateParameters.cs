using BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class SM2KeyExchangePrivateParameters : ICipherParameters
	{
		private readonly bool mInitiator;

		private readonly ECPrivateKeyParameters mStaticPrivateKey;

		private readonly ECPoint mStaticPublicPoint;

		private readonly ECPrivateKeyParameters mEphemeralPrivateKey;

		private readonly ECPoint mEphemeralPublicPoint;

		public virtual bool IsInitiator
		{
			get
			{
				return default(bool);
			}
		}

		public virtual ECPrivateKeyParameters StaticPrivateKey
		{
			get
			{
				return null;
			}
		}

		public virtual ECPoint StaticPublicPoint
		{
			get
			{
				return null;
			}
		}

		public virtual ECPrivateKeyParameters EphemeralPrivateKey
		{
			get
			{
				return null;
			}
		}

		public virtual ECPoint EphemeralPublicPoint
		{
			get
			{
				return null;
			}
		}

		public SM2KeyExchangePrivateParameters(bool initiator, ECPrivateKeyParameters staticPrivateKey, ECPrivateKeyParameters ephemeralPrivateKey)
		{
		}
	}
}
