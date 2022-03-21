using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	public class KeccakDigest : IDigest, IMemoable
	{
		private static readonly ulong[] KeccakRoundConstants;

		private ulong[] state;

		protected byte[] dataQueue;

		protected int rate;

		protected int bitsInQueue;

		protected int fixedOutputLength;

		protected bool squeezing;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public KeccakDigest()
		{
		}

		public KeccakDigest(int bitLength)
		{
		}

		public KeccakDigest(KeccakDigest source)
		{
		}

		private void CopyIn(KeccakDigest source)
		{
		}

		public virtual int GetDigestSize()
		{
			return default(int);
		}

		public virtual void Update(byte input)
		{
		}

		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		public virtual int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}

		protected virtual int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
		{
			return default(int);
		}

		public virtual void Reset()
		{
		}

		public virtual int GetByteLength()
		{
			return default(int);
		}

		private void Init(int bitLength)
		{
		}

		private void InitSponge(int rate)
		{
		}

		protected void Absorb(byte data)
		{
		}

		protected void Absorb(byte[] data, int off, int len)
		{
		}

		protected void AbsorbBits(int data, int bits)
		{
		}

		private void PadAndSwitchToSqueezingPhase()
		{
		}

		protected void Squeeze(byte[] output, int offset, long outputLength)
		{
		}

		private void KeccakAbsorb(byte[] data, int off)
		{
		}

		private void KeccakExtract()
		{
		}

		private void KeccakPermutation()
		{
		}

		public virtual IMemoable Copy()
		{
			return null;
		}

		public virtual void Reset(IMemoable other)
		{
		}
	}
}
