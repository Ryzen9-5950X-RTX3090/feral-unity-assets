namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class XteaEngine : IBlockCipher
	{
		private const int rounds = 32;

		private const int block_size = 8;

		private const int delta = -1640531527;

		private uint[] _S;

		private uint[] _sum0;

		private uint[] _sum1;

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

		public virtual int ProcessBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public virtual void Reset()
		{
		}

		private void setKey(byte[] key)
		{
		}

		private int encryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		private int decryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			return default(int);
		}
	}
}
