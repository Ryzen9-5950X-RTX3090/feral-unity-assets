using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
{
	public class DefaultSignatureCalculator : IStreamCalculator
	{
		private readonly SignerSink mSignerSink;

		public Stream Stream
		{
			get
			{
				return null;
			}
		}

		public DefaultSignatureCalculator(ISigner signer)
		{
		}

		public object GetResult()
		{
			return null;
		}
	}
}
