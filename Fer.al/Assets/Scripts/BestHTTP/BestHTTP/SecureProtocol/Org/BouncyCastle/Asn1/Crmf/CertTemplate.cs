using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
{
	public class CertTemplate : Asn1Encodable
	{
		private readonly Asn1Sequence seq;

		private readonly DerInteger version;

		private readonly DerInteger serialNumber;

		private readonly AlgorithmIdentifier signingAlg;

		private readonly X509Name issuer;

		private readonly OptionalValidity validity;

		private readonly X509Name subject;

		private readonly SubjectPublicKeyInfo publicKey;

		private readonly DerBitString issuerUID;

		private readonly DerBitString subjectUID;

		private readonly X509Extensions extensions;

		public virtual int Version
		{
			get
			{
				return default(int);
			}
		}

		public virtual DerInteger SerialNumber
		{
			get
			{
				return null;
			}
		}

		public virtual AlgorithmIdentifier SigningAlg
		{
			get
			{
				return null;
			}
		}

		public virtual X509Name Issuer
		{
			get
			{
				return null;
			}
		}

		public virtual OptionalValidity Validity
		{
			get
			{
				return null;
			}
		}

		public virtual X509Name Subject
		{
			get
			{
				return null;
			}
		}

		public virtual SubjectPublicKeyInfo PublicKey
		{
			get
			{
				return null;
			}
		}

		public virtual DerBitString IssuerUID
		{
			get
			{
				return null;
			}
		}

		public virtual DerBitString SubjectUID
		{
			get
			{
				return null;
			}
		}

		public virtual X509Extensions Extensions
		{
			get
			{
				return null;
			}
		}

		private CertTemplate(Asn1Sequence seq)
		{
		}

		public static CertTemplate GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
