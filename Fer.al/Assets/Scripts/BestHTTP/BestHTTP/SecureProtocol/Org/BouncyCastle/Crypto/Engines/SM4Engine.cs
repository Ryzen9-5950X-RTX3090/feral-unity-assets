namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class SM4Engine : IBlockCipher
	{
		private const int BlockSize = 16;

		private static readonly byte[] Sbox;

		private static readonly uint[] CK;

		private static readonly uint[] FK;

		private uint[] rk;

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

		private static uint tau(uint A)
		{
			return default(uint);
		}

		private static uint L_ap(uint B)
		{
			return default(uint);
		}

		private uint T_ap(uint Z)
		{
			return default(uint);
		}

		private void ExpandKey(bool forEncryption, byte[] key)
		{
		}

		private static uint L(uint B)
		{
			return default(uint);
		}

		private static uint T(uint Z)
		{
			return default(uint);
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
