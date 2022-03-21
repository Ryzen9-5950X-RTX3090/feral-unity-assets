using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class ElGamalKeyGenerationParameters : KeyGenerationParameters
	{
		private readonly ElGamalParameters parameters;

		public ElGamalParameters Parameters
		{
			get
			{
				return null;
			}
		}

		public ElGamalKeyGenerationParameters(SecureRandom random, ElGamalParameters parameters)
		{
		}

		internal static int GetStrength(ElGamalParameters parameters)
		{
			return default(int);
		}
	}
}
