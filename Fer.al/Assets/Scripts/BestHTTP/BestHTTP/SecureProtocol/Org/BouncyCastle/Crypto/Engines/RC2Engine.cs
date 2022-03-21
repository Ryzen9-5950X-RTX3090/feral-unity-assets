namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class RC2Engine : IBlockCipher
	{
		private static readonly byte[] piTable;

		private const int BLOCK_SIZE = 8;

		private int[] workingKey;

		private bool encrypting;

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

		private int[] GenerateWorkingKey(byte[] key, int bits)
		{
			return null;
		}

		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public virtual void Reset()
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

		private int RotateWordLeft(int x, int y)
		{
			return default(int);
		}

		private void EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
		}

		private void DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
		}
	}
}
