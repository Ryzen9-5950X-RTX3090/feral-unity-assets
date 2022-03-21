using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	public class Sha3Digest : KeccakDigest
	{
		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		private static int CheckBitLength(int bitLength)
		{
			return default(int);
		}

		public Sha3Digest()
		{
		}

		public Sha3Digest(int bitLength)
		{
		}

		public Sha3Digest(Sha3Digest source)
		{
		}

		public override int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}

		protected override int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
		{
			return default(int);
		}

		public override IMemoable Copy()
		{
			return null;
		}
	}
}
