using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
{
	public class CfbBlockCipherMac : IMac
	{
		private byte[] mac;

		private byte[] Buffer;

		private int bufOff;

		private MacCFBBlockCipher cipher;

		private IBlockCipherPadding padding;

		private int macSize;

		public string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public CfbBlockCipherMac(IBlockCipher cipher)
		{
		}

		public CfbBlockCipherMac(IBlockCipher cipher, IBlockCipherPadding padding)
		{
		}

		public CfbBlockCipherMac(IBlockCipher cipher, int cfbBitSize, int macSizeInBits)
		{
		}

		public CfbBlockCipherMac(IBlockCipher cipher, int cfbBitSize, int macSizeInBits, IBlockCipherPadding padding)
		{
		}

		public void Init(ICipherParameters parameters)
		{
		}

		public int GetMacSize()
		{
			return default(int);
		}

		public void Update(byte input)
		{
		}

		public void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		public int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}

		public void Reset()
		{
		}
	}
}
