namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
	public class EaxBlockCipher : IAeadBlockCipher, IAeadCipher
	{
		private enum Tag : byte
		{
			N,
			H,
			C
		}

		private SicBlockCipher cipher;

		private bool forEncryption;

		private int blockSize;

		private IMac mac;

		private byte[] nonceMac;

		private byte[] associatedTextMac;

		private byte[] macBlock;

		private int macSize;

		private byte[] bufBlock;

		private int bufOff;

		private bool cipherInitialized;

		private byte[] initialAssociatedText;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public EaxBlockCipher(IBlockCipher cipher)
		{
		}

		public virtual IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		public virtual int GetBlockSize()
		{
			return default(int);
		}

		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		private void InitCipher()
		{
		}

		private void CalculateMac()
		{
		}

		public virtual void Reset()
		{
		}

		private void Reset(bool clearMac)
		{
		}

		public virtual void ProcessAadByte(byte input)
		{
		}

		public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
		{
		}

		public virtual int ProcessByte(byte input, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public virtual int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public virtual int DoFinal(byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public virtual byte[] GetMac()
		{
			return null;
		}

		public virtual int GetUpdateOutputSize(int len)
		{
			return default(int);
		}

		public virtual int GetOutputSize(int len)
		{
			return default(int);
		}

		private int Process(byte b, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		private bool VerifyMac(byte[] mac, int off)
		{
			return default(bool);
		}
	}
}
