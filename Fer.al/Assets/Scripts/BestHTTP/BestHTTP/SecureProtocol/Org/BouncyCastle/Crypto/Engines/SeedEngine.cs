namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class SeedEngine : IBlockCipher
	{
		private const int BlockSize = 16;

		private static readonly uint[] SS0;

		private static readonly uint[] SS1;

		private static readonly uint[] SS2;

		private static readonly uint[] SS3;

		private static readonly uint[] KC;

		private int[] wKey;

		private bool forEncryption;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return default(bool);
			}
		}

		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public virtual int GetBlockSize()
		{
			return default(int);
		}

		public virtual int ProcessBlock(byte[] inBuf, int inOff, byte[] outBuf, int outOff)
		{
			return default(int);
		}

		public virtual void Reset()
		{
		}

		private int[] createWorkingKey(byte[] inKey)
		{
			return null;
		}

		private int extractW1(long lVal)
		{
			return default(int);
		}

		private int extractW0(long lVal)
		{
			return default(int);
		}

		private long rotateLeft8(long x)
		{
			return default(long);
		}

		private long rotateRight8(long x)
		{
			return default(long);
		}

		private long bytesToLong(byte[] src, int srcOff)
		{
			return default(long);
		}

		private void longToBytes(byte[] dest, int destOff, long value)
		{
		}

		private int G(int x)
		{
			return default(int);
		}

		private long F(int ki0, int ki1, long r)
		{
			return default(long);
		}

		private int phaseCalc1(int r0, int ki0, int r1, int ki1)
		{
			return default(int);
		}

		private int phaseCalc2(int r0, int ki0, int r1, int ki1)
		{
			return default(int);
		}
	}
}
