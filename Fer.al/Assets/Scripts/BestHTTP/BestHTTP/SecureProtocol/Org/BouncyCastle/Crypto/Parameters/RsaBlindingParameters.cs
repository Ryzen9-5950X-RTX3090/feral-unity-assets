using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class RsaBlindingParameters : ICipherParameters
	{
		private readonly RsaKeyParameters publicKey;

		private readonly BigInteger blindingFactor;

		public RsaKeyParameters PublicKey
		{
			get
			{
				return null;
			}
		}

		public BigInteger BlindingFactor
		{
			get
			{
				return null;
			}
		}

		public RsaBlindingParameters(RsaKeyParameters publicKey, BigInteger blindingFactor)
		{
		}
	}
}
