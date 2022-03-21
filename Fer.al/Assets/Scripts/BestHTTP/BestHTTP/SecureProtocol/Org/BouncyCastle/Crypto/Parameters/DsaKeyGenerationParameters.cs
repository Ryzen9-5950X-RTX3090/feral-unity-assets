using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class DsaKeyGenerationParameters : KeyGenerationParameters
	{
		private readonly DsaParameters parameters;

		public DsaParameters Parameters
		{
			get
			{
				return null;
			}
		}

		public DsaKeyGenerationParameters(SecureRandom random, DsaParameters parameters)
		{
		}
	}
}
