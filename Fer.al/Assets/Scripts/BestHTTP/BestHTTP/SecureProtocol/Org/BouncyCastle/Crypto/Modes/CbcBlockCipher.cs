using BestHTTP.PlatformSupport.IL2CPP;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
	[Il2CppEagerStaticClassConstruction]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public class CbcBlockCipher : IBlockCipher
	{
		private byte[] IV;

		private byte[] cbcV;

		private byte[] cbcNextV;

		private int blockSize;

		private IBlockCipher cipher;

		private bool encrypting;

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

		public CbcBlockCipher(IBlockCipher cipher)
		{
		}

		public IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public int GetBlockSize()
		{
			return default(int);
		}

		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		public void Reset()
		{
		}

		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return default(int);
		}
	}
}
