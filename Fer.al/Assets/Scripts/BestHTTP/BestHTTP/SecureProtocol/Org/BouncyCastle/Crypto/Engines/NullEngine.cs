namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class NullEngine : IBlockCipher
	{
		private bool initialised;

		private const int BlockSize = 1;

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

		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		public virtual void Reset()
		{
		}
	}
}
