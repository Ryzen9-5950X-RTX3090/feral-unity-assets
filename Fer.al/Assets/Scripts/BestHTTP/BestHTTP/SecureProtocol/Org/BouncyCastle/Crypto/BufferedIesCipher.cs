using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
	public class BufferedIesCipher : BufferedCipherBase
	{
		private readonly IesEngine engine;

		private bool forEncryption;

		private MemoryStream buffer;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public BufferedIesCipher(IesEngine engine)
		{
		}

		public override void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public override int GetBlockSize()
		{
			return default(int);
		}

		public override int GetOutputSize(int inputLen)
		{
			return default(int);
		}

		public override int GetUpdateOutputSize(int inputLen)
		{
			return default(int);
		}

		public override byte[] ProcessByte(byte input)
		{
			return null;
		}

		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			return null;
		}

		public override byte[] DoFinal()
		{
			return null;
		}

		public override byte[] DoFinal(byte[] input, int inOff, int length)
		{
			return null;
		}

		public override void Reset()
		{
		}
	}
}
