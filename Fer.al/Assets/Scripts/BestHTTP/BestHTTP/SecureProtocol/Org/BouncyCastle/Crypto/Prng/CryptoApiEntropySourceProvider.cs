using System.Security.Cryptography;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
{
	public class CryptoApiEntropySourceProvider : IEntropySourceProvider
	{
		private class CryptoApiEntropySource : IEntropySource
		{
			private readonly RandomNumberGenerator mRng;

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

			internal CryptoApiEntropySource(RandomNumberGenerator rng, bool predictionResistant, int entropySize)
			{
			}

			byte[] IEntropySource.GetEntropy()
			{
				return null;
			}
		}

		private readonly RandomNumberGenerator mRng;

		private readonly bool mPredictionResistant;

		public CryptoApiEntropySourceProvider()
		{
		}

		public CryptoApiEntropySourceProvider(RandomNumberGenerator rng, bool isPredictionResistant)
		{
		}

		public IEntropySource Get(int bitsRequired)
		{
			return null;
		}
	}
}
