using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	public class NullDigest : IDigest
	{
		private readonly MemoryStream bOut;

		public string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public int GetByteLength()
		{
			return default(int);
		}

		public int GetDigestSize()
		{
			return default(int);
		}

		public void Update(byte b)
		{
		}

		public void BlockUpdate(byte[] inBytes, int inOff, int len)
		{
		}

		public int DoFinal(byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public void Reset()
		{
		}
	}
}
