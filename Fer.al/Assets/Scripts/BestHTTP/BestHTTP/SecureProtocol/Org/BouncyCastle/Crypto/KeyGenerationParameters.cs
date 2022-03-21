using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
	public class KeyGenerationParameters
	{
		private SecureRandom random;

		private int strength;

		public SecureRandom Random
		{
			get
			{
				return null;
			}
		}

		public int Strength
		{
			get
			{
				return default(int);
			}
		}

		public KeyGenerationParameters(SecureRandom random, int strength)
		{
		}
	}
}
