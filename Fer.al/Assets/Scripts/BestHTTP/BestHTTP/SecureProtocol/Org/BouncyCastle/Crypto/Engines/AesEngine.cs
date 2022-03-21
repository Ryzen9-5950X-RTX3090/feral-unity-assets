namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class AesEngine : IBlockCipher
	{
		private static readonly byte[] S;

		private static readonly byte[] Si;

		private static readonly byte[] rcon;

		private static readonly uint[] T0;

		private static readonly uint[] Tinv0;

		private const uint m1 = 2155905152u;

		private const uint m2 = 2139062143u;

		private const uint m3 = 27u;

		private const uint m4 = 3233857728u;

		private const uint m5 = 1061109567u;

		private int ROUNDS;

		private uint[][] WorkingKey;

		private uint C0;

		private uint C1;

		private uint C2;

		private uint C3;

		private bool forEncryption;

		private byte[] s;

		private const int BLOCK_SIZE = 16;

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

		private static uint Shift(uint r, int shift)
		{
			return default(uint);
		}

		private static uint FFmulX(uint x)
		{
			return default(uint);
		}

		private static uint FFmulX2(uint x)
		{
			return default(uint);
		}

		private static uint Inv_Mcol(uint x)
		{
			return default(uint);
		}

		private static uint SubWord(uint x)
		{
			return default(uint);
		}

		private uint[][] GenerateWorkingKey(byte[] key, bool forEncryption)
		{
			return null;
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

		private void UnPackBlock(byte[] bytes, int off)
		{
		}

		private void PackBlock(byte[] bytes, int off)
		{
		}

		private void EncryptBlock(uint[][] KW)
		{
		}

		private void DecryptBlock(uint[][] KW)
		{
		}
	}
}
