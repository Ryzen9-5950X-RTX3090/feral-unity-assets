using BestHTTP.PlatformSupport.IL2CPP;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	[Il2CppEagerStaticClassConstruction]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public sealed class Sha256Digest : GeneralDigest
	{
		private const int DigestLength = 32;

		private uint H1;

		private uint H2;

		private uint H3;

		private uint H4;

		private uint H5;

		private uint H6;

		private uint H7;

		private uint H8;

		private uint[] X;

		private int xOff;

		private static readonly uint[] K;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public Sha256Digest()
		{
		}

		public Sha256Digest(Sha256Digest t)
		{
		}

		private void CopyIn(Sha256Digest t)
		{
		}

		public override int GetDigestSize()
		{
			return default(int);
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

		private void initHs()
		{
		}

		internal override void ProcessWord(byte[] input, int inOff)
		{
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
