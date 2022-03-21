using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
	public class KeyTransRecipientInfo : Asn1Encodable
	{
		private DerInteger version;

		private RecipientIdentifier rid;

		private AlgorithmIdentifier keyEncryptionAlgorithm;

		private Asn1OctetString encryptedKey;

		public DerInteger Version
		{
			get
			{
				return null;
			}
		}

		public RecipientIdentifier RecipientIdentifier
		{
			get
			{
				return null;
			}
		}

		public AlgorithmIdentifier KeyEncryptionAlgorithm
		{
			get
			{
				return null;
			}
		}

		public Asn1OctetString EncryptedKey
		{
			get
			{
				return null;
			}
		}

		public KeyTransRecipientInfo(RecipientIdentifier rid, AlgorithmIdentifier keyEncryptionAlgorithm, Asn1OctetString encryptedKey)
		{
		}

		public KeyTransRecipientInfo(Asn1Sequence seq)
		{
		}

		public static KeyTransRecipientInfo GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
