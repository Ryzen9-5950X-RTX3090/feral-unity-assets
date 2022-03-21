using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
{
	public class RevAnnContent : Asn1Encodable
	{
		private readonly PkiStatusEncodable status;

		private readonly CertId certId;

		private readonly DerGeneralizedTime willBeRevokedAt;

		private readonly DerGeneralizedTime badSinceDate;

		private readonly X509Extensions crlDetails;

		public virtual PkiStatusEncodable Status
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

		public virtual DerGeneralizedTime WillBeRevokedAt
		{
			get
			{
				return null;
			}
		}

		public virtual DerGeneralizedTime BadSinceDate
		{
			get
			{
				return null;
			}
		}

		public virtual X509Extensions CrlDetails
		{
			get
			{
				return null;
			}
		}

		private RevAnnContent(Asn1Sequence seq)
		{
		}

		public static RevAnnContent GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
