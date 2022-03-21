using BestHTTP.PlatformSupport.IL2CPP;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	[Il2CppEagerStaticClassConstruction]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public class Sha1Digest : GeneralDigest
	{
		private const int DigestLength = 20;

		private uint H1;

		private uint H2;

		private uint H3;

		private uint H4;

		private uint H5;

		private uint[] X;

		private int xOff;

		private const uint Y1 = 1518500249u;

		private const uint Y2 = 1859775393u;

		private const uint Y3 = 2400959708u;

		private const uint Y4 = 3395469782u;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public Sha1Digest()
		{
		}

		public Sha1Digest(Sha1Digest t)
		{
		}

		private void CopyIn(Sha1Digest t)
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

		private static uint F(uint u, uint v, uint w)
		{
			return default(uint);
		}

		private static uint H(uint u, uint v, uint w)
		{
			return default(uint);
		}

		private static uint G(uint u, uint v, uint w)
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
