namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class NoekeonEngine : IBlockCipher
	{
		private const int GenericSize = 16;

		private static readonly uint[] nullVector;

		private static readonly uint[] roundConstants;

		private uint[] state;

		private uint[] subKeys;

		private uint[] decryptKeys;

		private bool _initialised;

		private bool _forEncryption;

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

		public virtual int GetBlockSize()
		{
			return default(int);
		}

		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		public virtual void Reset()
		{
		}

		private void setKey(byte[] key)
		{
		}

		private int encryptBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		private int decryptBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		private void gamma(uint[] a)
		{
		}

		private void theta(uint[] a, uint[] k)
		{
		}

		private void pi1(uint[] a)
		{
		}

		private void pi2(uint[] a)
		{
		}

		private uint rotl(uint x, int y)
		{
			return default(uint);
		}
	}
}
