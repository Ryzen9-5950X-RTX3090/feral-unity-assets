using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
	public class EncryptedContentInfoParser
	{
		private DerObjectIdentifier _contentType;

		private AlgorithmIdentifier _contentEncryptionAlgorithm;

		private Asn1TaggedObjectParser _encryptedContent;

		public DerObjectIdentifier ContentType
		{
			get
			{
				return null;
			}
		}

		public AlgorithmIdentifier ContentEncryptionAlgorithm
		{
			get
			{
				return null;
			}
		}

		public EncryptedContentInfoParser(Asn1SequenceParser seq)
		{
		}

		public IAsn1Convertible GetEncryptedContent(int tag)
		{
			return null;
		}
	}
}
