using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	public class RipeMD128Digest : GeneralDigest
	{
		private const int DigestLength = 16;

		private int H0;

		private int H1;

		private int H2;

		private int H3;

		private int[] X;

		private int xOff;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public RipeMD128Digest()
		{
		}

		public RipeMD128Digest(RipeMD128Digest t)
		{
		}

		private void CopyIn(RipeMD128Digest t)
		{
		}

		public override int GetDigestSize()
		{
			return default(int);
		}

		internal override void ProcessWord(byte[] input, int inOff)
		{
		}

		internal override void ProcessLength(long bitLength)
		{
		}

		private void UnpackWord(int word, byte[] outBytes, int outOff)
		{
		}

		public override int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}

		public override void Reset()
		{
		}

		private int RL(int x, int n)
		{
			return default(int);
		}

		private int F1(int x, int y, int z)
		{
			return default(int);
		}

		private int F2(int x, int y, int z)
		{
			return default(int);
		}

		private int F3(int x, int y, int z)
		{
			return default(int);
		}

		private int F4(int x, int y, int z)
		{
			return default(int);
		}

		private int F1(int a, int b, int c, int d, int x, int s)
		{
			return default(int);
		}

		private int F2(int a, int b, int c, int d, int x, int s)
		{
			return default(int);
		}

		private int F3(int a, int b, int c, int d, int x, int s)
		{
			return default(int);
		}

		private int F4(int a, int b, int c, int d, int x, int s)
		{
			return default(int);
		}

		private int FF1(int a, int b, int c, int d, int x, int s)
		{
			return default(int);
		}

		private int FF2(int a, int b, int c, int d, int x, int s)
		{
			return default(int);
		}

		private int FF3(int a, int b, int c, int d, int x, int s)
		{
			return default(int);
		}

		private int FF4(int a, int b, int c, int d, int x, int s)
		{
			return default(int);
		}

		internal override void ProcessBlock()
		{
		}

		public override IMemoable Copy()
		{
			return null;
		}

		public override void Reset(IMemoable other)
		{
		}
	}
}
