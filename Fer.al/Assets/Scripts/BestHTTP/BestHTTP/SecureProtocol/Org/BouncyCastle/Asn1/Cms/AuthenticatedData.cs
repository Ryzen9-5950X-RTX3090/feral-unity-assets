using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
	public class AuthenticatedData : Asn1Encodable
	{
		private DerInteger version;

		private OriginatorInfo originatorInfo;

		private Asn1Set recipientInfos;

		private AlgorithmIdentifier macAlgorithm;

		private AlgorithmIdentifier digestAlgorithm;

		private ContentInfo encapsulatedContentInfo;

		private Asn1Set authAttrs;

		private Asn1OctetString mac;

		private Asn1Set unauthAttrs;

		public DerInteger Version
		{
			get
			{
				return null;
			}
		}

		public OriginatorInfo OriginatorInfo
		{
			get
			{
				return null;
			}
		}

		public Asn1Set RecipientInfos
		{
			get
			{
				return null;
			}
		}

		public AlgorithmIdentifier MacAlgorithm
		{
			get
			{
				return null;
			}
		}

		public AlgorithmIdentifier DigestAlgorithm
		{
			get
			{
				return null;
			}
		}

		public ContentInfo EncapsulatedContentInfo
		{
			get
			{
				return null;
			}
		}

		public Asn1Set AuthAttrs
		{
			get
			{
				return null;
			}
		}

		public Asn1OctetString Mac
		{
			get
			{
				return null;
			}
		}

		public Asn1Set UnauthAttrs
		{
			get
			{
				return null;
			}
		}

		public AuthenticatedData(OriginatorInfo originatorInfo, Asn1Set recipientInfos, AlgorithmIdentifier macAlgorithm, AlgorithmIdentifier digestAlgorithm, ContentInfo encapsulatedContent, Asn1Set authAttrs, Asn1OctetString mac, Asn1Set unauthAttrs)
		{
		}

		private AuthenticatedData(Asn1Sequence seq)
		{
		}

		public static AuthenticatedData GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		public static AuthenticatedData GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		public static int CalculateVersion(OriginatorInfo origInfo)
		{
			return default(int);
		}
	}
}
