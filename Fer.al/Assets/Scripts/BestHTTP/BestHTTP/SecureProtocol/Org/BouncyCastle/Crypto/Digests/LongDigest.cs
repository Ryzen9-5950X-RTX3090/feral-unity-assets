using BestHTTP.PlatformSupport.IL2CPP;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	[Il2CppEagerStaticClassConstruction]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public abstract class LongDigest : IDigest, IMemoable
	{
		private int MyByteLength;

		private byte[] xBuf;

		private int xBufOff;

		private long byteCount1;

		private long byteCount2;

		internal ulong H1;

		internal ulong H2;

		internal ulong H3;

		internal ulong H4;

		internal ulong H5;

		internal ulong H6;

		internal ulong H7;

		internal ulong H8;

		private ulong[] W;

		private int wOff;

		internal static readonly ulong[] K;

		public abstract string AlgorithmName { get; }

		internal LongDigest()
		{
		}

		internal LongDigest(LongDigest t)
		{
		}

		protected void CopyIn(LongDigest t)
		{
		}

		public void Update(byte input)
		{
		}

		public void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		public void Finish()
		{
		}

		public virtual void Reset()
		{
		}

		internal void ProcessWord(byte[] input, int inOff)
		{
		}

		private void AdjustByteCounts()
		{
		}

		internal void ProcessLength(long lowW, long hiW)
		{
		}

		internal void ProcessBlock()
		{
		}

		private static ulong Ch(ulong x, ulong y, ulong z)
		{
			return default(ulong);
		}

		private static ulong Maj(ulong x, ulong y, ulong z)
		{
			return default(ulong);
		}

		private static ulong Sum0(ulong x)
		{
			return default(ulong);
		}

		private static ulong Sum1(ulong x)
		{
			return default(ulong);
		}

		private static ulong Sigma0(ulong x)
		{
			return default(ulong);
		}

		private static ulong Sigma1(ulong x)
		{
			return default(ulong);
		}

		public int GetByteLength()
		{
			return default(int);
		}

		public abstract int GetDigestSize();

		public abstract int DoFinal(byte[] output, int outOff);

		public abstract IMemoable Copy();

		public abstract void Reset(IMemoable t);
	}
}
