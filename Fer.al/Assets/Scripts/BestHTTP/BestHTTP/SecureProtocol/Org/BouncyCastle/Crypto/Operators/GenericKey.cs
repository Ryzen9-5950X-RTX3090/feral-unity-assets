using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
{
	public class GenericKey
	{
		private readonly AlgorithmIdentifier algorithmIdentifier;

		private readonly object representation;

		public AlgorithmIdentifier AlgorithmIdentifier
		{
			get
			{
				return null;
			}
		}

		public object Representation
		{
			get
			{
				return null;
			}
		}

		public GenericKey(object representation)
		{
		}

		public GenericKey(AlgorithmIdentifier algorithmIdentifier, byte[] representation)
		{
		}

		public GenericKey(AlgorithmIdentifier algorithmIdentifier, object representation)
		{
		}
	}
}
