using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
{
	public sealed class X448Agreement : IRawAgreement
	{
		private X448PrivateKeyParameters privateKey;

		public int AgreementSize
		{
			get
			{
				return default(int);
			}
		}

		public void Init(ICipherParameters parameters)
		{
		}

		public void CalculateAgreement(ICipherParameters publicKey, byte[] buf, int off)
		{
		}
	}
}
