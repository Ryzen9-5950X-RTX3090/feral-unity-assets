using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
	public class CcmBlockCipher : IAeadBlockCipher, IAeadCipher
	{
		private static readonly int BlockSize;

		private readonly IBlockCipher cipher;

		private readonly byte[] macBlock;

		private bool forEncryption;

		private byte[] nonce;

		private byte[] initialAssociatedText;

		private int macSize;

		private ICipherParameters keyParam;

		private readonly MemoryStream associatedText;

		private readonly MemoryStream data;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public CcmBlockCipher(IBlockCipher cipher)
		{
		}

		public virtual IBlockCipher GetUnderlyingCipher()
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

		public virtual int ProcessBytes(byte[] inBytes, int inOff, int inLen, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public virtual int DoFinal(byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public virtual void Reset()
		{
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

		public virtual byte[] ProcessPacket(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		public virtual int ProcessPacket(byte[] input, int inOff, int inLen, byte[] output, int outOff)
		{
			return default(int);
		}

		private int CalculateMac(byte[] data, int dataOff, int dataLen, byte[] macBlock)
		{
			return default(int);
		}

		private int GetMacSize(bool forEncryption, int requestedMacBits)
		{
			return default(int);
		}

		private int GetAssociatedTextLength()
		{
			return default(int);
		}

		private bool HasAssociatedText()
		{
			return default(bool);
		}
	}
}
