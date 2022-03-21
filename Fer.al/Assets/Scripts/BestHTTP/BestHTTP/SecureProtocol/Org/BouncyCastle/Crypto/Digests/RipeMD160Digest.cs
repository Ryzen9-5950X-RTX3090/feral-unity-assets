using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	public class RipeMD160Digest : GeneralDigest
	{
		private const int DigestLength = 20;

		private int H0;

		private int H1;

		private int H2;

		private int H3;

		private int H4;

		private int[] X;

		private int xOff;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public RipeMD160Digest()
		{
		}

		public RipeMD160Digest(RipeMD160Digest t)
		{
		}

		private void CopyIn(RipeMD160Digest t)
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

		private int F5(int x, int y, int z)
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
