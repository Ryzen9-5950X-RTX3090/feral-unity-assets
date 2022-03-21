using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
{
	public class BufferedCipherWrapper : ICipher
	{
		private readonly IBufferedCipher bufferedCipher;

		private readonly CipherStream stream;

		public Stream Stream
		{
			get
			{
				return null;
			}
		}

		public BufferedCipherWrapper(IBufferedCipher bufferedCipher, Stream source)
		{
		}

		public int GetMaxOutputSize(int inputLen)
		{
			return default(int);
		}

		public int GetUpdateOutputSize(int inputLen)
		{
			return default(int);
		}
	}
}
