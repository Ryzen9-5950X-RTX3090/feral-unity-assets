using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
	public class EncryptedContentInfo : Asn1Encodable
	{
		private DerObjectIdentifier contentType;

		private AlgorithmIdentifier contentEncryptionAlgorithm;

		private Asn1OctetString encryptedContent;

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

		public Asn1OctetString EncryptedContent
		{
			get
			{
				return null;
			}
		}

		public EncryptedContentInfo(DerObjectIdentifier contentType, AlgorithmIdentifier contentEncryptionAlgorithm, Asn1OctetString encryptedContent)
		{
		}

		public EncryptedContentInfo(Asn1Sequence seq)
		{
		}

		public static EncryptedContentInfo GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
