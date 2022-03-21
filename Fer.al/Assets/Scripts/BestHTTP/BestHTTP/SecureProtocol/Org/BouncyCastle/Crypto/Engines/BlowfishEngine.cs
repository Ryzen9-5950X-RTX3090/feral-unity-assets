namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public sealed class BlowfishEngine : IBlockCipher
	{
		private static readonly uint[] KP;

		private static readonly uint[] KS0;

		private static readonly uint[] KS1;

		private static readonly uint[] KS2;

		private static readonly uint[] KS3;

		private static readonly int ROUNDS;

		private const int BLOCK_SIZE = 8;

		private static readonly int SBOX_SK;

		private static readonly int P_SZ;

		private readonly uint[] S0;

		private readonly uint[] S1;

		private readonly uint[] S2;

		private readonly uint[] S3;

		private readonly uint[] P;

		private bool encrypting;

		private byte[] workingKey;

		public string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public bool IsPartialBlockOkay
		{
			get
			{
				return default(bool);
			}
		}

		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		public void Reset()
		{
		}

		public int GetBlockSize()
		{
			return default(int);
		}

		private uint F(uint x)
		{
			return default(uint);
		}

		private void ProcessTable(uint xl, uint xr, uint[] table)
		{
		}

		private void SetKey(byte[] key)
		{
		}

		private void EncryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
		}

		private void DecryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
		}
	}
}
