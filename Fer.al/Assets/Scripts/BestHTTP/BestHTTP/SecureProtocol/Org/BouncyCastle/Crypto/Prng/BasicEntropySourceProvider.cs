using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
{
	public class BasicEntropySourceProvider : IEntropySourceProvider
	{
		private class BasicEntropySource : IEntropySource
		{
			private readonly SecureRandom mSecureRandom;

			private readonly bool mPredictionResistant;

			private readonly int mEntropySize;

			bool IEntropySource.IsPredictionResistant
			{
				get
				{
					return default(bool);
				}
			}

			int IEntropySource.EntropySize
			{
				get
				{
					return default(int);
				}
			}

			internal BasicEntropySource(SecureRandom secureRandom, bool predictionResistant, int entropySize)
			{
			}

			byte[] IEntropySource.GetEntropy()
			{
				return null;
			}
		}

		private readonly SecureRandom mSecureRandom;

		private readonly bool mPredictionResistant;

		public BasicEntropySourceProvider(SecureRandom secureRandom, bool isPredictionResistant)
		{
		}

		public IEntropySource Get(int bitsRequired)
		{
			return null;
		}
	}
}
