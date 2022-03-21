using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	public class MD5Digest : GeneralDigest
	{
		private const int DigestLength = 16;

		private uint H1;

		private uint H2;

		private uint H3;

		private uint H4;

		private uint[] X;

		private int xOff;

		private static readonly int S11;

		private static readonly int S12;

		private static readonly int S13;

		private static readonly int S14;

		private static readonly int S21;

		private static readonly int S22;

		private static readonly int S23;

		private static readonly int S24;

		private static readonly int S31;

		private static readonly int S32;

		private static readonly int S33;

		private static readonly int S34;

		private static readonly int S41;

		private static readonly int S42;

		private static readonly int S43;

		private static readonly int S44;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public MD5Digest()
		{
		}

		public MD5Digest(MD5Digest t)
		{
		}

		private void CopyIn(MD5Digest t)
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

		public override int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}

		public override void Reset()
		{
		}

		private static uint RotateLeft(uint x, int n)
		{
			return default(uint);
		}

		private static uint F(uint u, uint v, uint w)
		{
			return default(uint);
		}

		private static uint G(uint u, uint v, uint w)
		{
			return default(uint);
		}

		private static uint H(uint u, uint v, uint w)
		{
			return default(uint);
		}

		private static uint K(uint u, uint v, uint w)
		{
			return default(uint);
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
