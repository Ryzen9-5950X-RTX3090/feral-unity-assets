using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class NaccacheSternKeyGenerationParameters : KeyGenerationParameters
	{
		private readonly int certainty;

		private readonly int countSmallPrimes;

		public int Certainty
		{
			get
			{
				return default(int);
			}
		}

		public int CountSmallPrimes
		{
			get
			{
				return default(int);
			}
		}

		public bool IsDebug
		{
			get
			{
				return default(bool);
			}
		}

		public NaccacheSternKeyGenerationParameters(SecureRandom random, int strength, int certainty, int countSmallPrimes)
		{
		}

		public NaccacheSternKeyGenerationParameters(SecureRandom random, int strength, int certainty, int countSmallPrimes, bool debug)
		{
		}
	}
}
