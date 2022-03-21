using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
	public class KeyAgreeRecipientInfo : Asn1Encodable
	{
		private DerInteger version;

		private OriginatorIdentifierOrKey originator;

		private Asn1OctetString ukm;

		private AlgorithmIdentifier keyEncryptionAlgorithm;

		private Asn1Sequence recipientEncryptedKeys;

		public DerInteger Version
		{
			get
			{
				return null;
			}
		}

		public OriginatorIdentifierOrKey Originator
		{
			get
			{
				return null;
			}
		}

		public Asn1OctetString UserKeyingMaterial
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

		public Asn1Sequence RecipientEncryptedKeys
		{
			get
			{
				return null;
			}
		}

		public KeyAgreeRecipientInfo(OriginatorIdentifierOrKey originator, Asn1OctetString ukm, AlgorithmIdentifier keyEncryptionAlgorithm, Asn1Sequence recipientEncryptedKeys)
		{
		}

		public KeyAgreeRecipientInfo(Asn1Sequence seq)
		{
		}

		public static KeyAgreeRecipientInfo GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		public static KeyAgreeRecipientInfo GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
