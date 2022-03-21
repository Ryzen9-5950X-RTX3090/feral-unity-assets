using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
{
	public class CertificationRequestInfo : Asn1Encodable
	{
		internal DerInteger version;

		internal X509Name subject;

		internal SubjectPublicKeyInfo subjectPKInfo;

		internal Asn1Set attributes;

		public DerInteger Version
		{
			get
			{
				return null;
			}
		}

		public X509Name Subject
		{
			get
			{
				return null;
			}
		}

		public SubjectPublicKeyInfo SubjectPublicKeyInfo
		{
			get
			{
				return null;
			}
		}

		public Asn1Set Attributes
		{
			get
			{
				return null;
			}
		}

		public static CertificationRequestInfo GetInstance(object obj)
		{
			return null;
		}

		public CertificationRequestInfo(X509Name subject, SubjectPublicKeyInfo pkInfo, Asn1Set attributes)
		{
		}

		private CertificationRequestInfo(Asn1Sequence seq)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		private static void ValidateAttributes(Asn1Set attributes)
		{
		}
	}
}
