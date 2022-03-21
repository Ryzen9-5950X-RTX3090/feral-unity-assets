using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	public class ShakeDigest : KeccakDigest, IXof, IDigest
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

		public ShakeDigest()
		{
		}

		public ShakeDigest(int bitLength)
		{
		}

		public ShakeDigest(ShakeDigest source)
		{
		}

		public override int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}

		public virtual int DoFinal(byte[] output, int outOff, int outLen)
		{
			return default(int);
		}

		public virtual int DoOutput(byte[] output, int outOff, int outLen)
		{
			return default(int);
		}

		protected override int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
		{
			return default(int);
		}

		protected virtual int DoFinal(byte[] output, int outOff, int outLen, byte partialByte, int partialBits)
		{
			return default(int);
		}

		public override IMemoable Copy()
		{
			return null;
		}
	}
}
