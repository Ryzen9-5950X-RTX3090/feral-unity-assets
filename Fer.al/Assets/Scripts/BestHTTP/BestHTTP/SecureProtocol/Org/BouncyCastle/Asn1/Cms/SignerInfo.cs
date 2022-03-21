using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
	public class SignerInfo : Asn1Encodable
	{
		private DerInteger version;

		private SignerIdentifier sid;

		private AlgorithmIdentifier digAlgorithm;

		private Asn1Set authenticatedAttributes;

		private AlgorithmIdentifier digEncryptionAlgorithm;

		private Asn1OctetString encryptedDigest;

		private Asn1Set unauthenticatedAttributes;

		public DerInteger Version
		{
			get
			{
				return null;
			}
		}

		public SignerIdentifier SignerID
		{
			get
			{
				return null;
			}
		}

		public Asn1Set AuthenticatedAttributes
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

		public Asn1OctetString EncryptedDigest
		{
			get
			{
				return null;
			}
		}

		public AlgorithmIdentifier DigestEncryptionAlgorithm
		{
			get
			{
				return null;
			}
		}

		public Asn1Set UnauthenticatedAttributes
		{
			get
			{
				return null;
			}
		}

		public static SignerInfo GetInstance(object obj)
		{
			return null;
		}

		public SignerInfo(SignerIdentifier sid, AlgorithmIdentifier digAlgorithm, Asn1Set authenticatedAttributes, AlgorithmIdentifier digEncryptionAlgorithm, Asn1OctetString encryptedDigest, Asn1Set unauthenticatedAttributes)
		{
		}

		public SignerInfo(SignerIdentifier sid, AlgorithmIdentifier digAlgorithm, Attributes authenticatedAttributes, AlgorithmIdentifier digEncryptionAlgorithm, Asn1OctetString encryptedDigest, Attributes unauthenticatedAttributes)
		{
		}

		public SignerInfo(Asn1Sequence seq)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
