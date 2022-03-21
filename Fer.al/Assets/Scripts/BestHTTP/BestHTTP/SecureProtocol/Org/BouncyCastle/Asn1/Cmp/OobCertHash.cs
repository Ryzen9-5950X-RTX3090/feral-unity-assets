using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
{
	public class OobCertHash : Asn1Encodable
	{
		private readonly AlgorithmIdentifier hashAlg;

		private readonly CertId certId;

		private readonly DerBitString hashVal;

		public virtual AlgorithmIdentifier HashAlg
		{
			get
			{
				return null;
			}
		}

		public virtual CertId CertID
		{
			get
			{
				return null;
			}
		}

		private OobCertHash(Asn1Sequence seq)
		{
		}

		public static OobCertHash GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
