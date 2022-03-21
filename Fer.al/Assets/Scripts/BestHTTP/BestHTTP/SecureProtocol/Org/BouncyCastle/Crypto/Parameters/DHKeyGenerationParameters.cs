using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class DHKeyGenerationParameters : KeyGenerationParameters
	{
		private readonly DHParameters parameters;

		public DHParameters Parameters
		{
			get
			{
				return null;
			}
		}

		public DHKeyGenerationParameters(SecureRandom random, DHParameters parameters)
		{
		}

		internal static int GetStrength(DHParameters parameters)
		{
			return default(int);
		}
	}
}
