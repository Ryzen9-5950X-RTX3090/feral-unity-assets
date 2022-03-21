using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
{
	public class SingleResponse : Asn1Encodable
	{
		private readonly CertID certID;

		private readonly CertStatus certStatus;

		private readonly DerGeneralizedTime thisUpdate;

		private readonly DerGeneralizedTime nextUpdate;

		private readonly X509Extensions singleExtensions;

		public CertID CertId
		{
			get
			{
				return null;
			}
		}

		public CertStatus CertStatus
		{
			get
			{
				return null;
			}
		}

		public DerGeneralizedTime ThisUpdate
		{
			get
			{
				return null;
			}
		}

		public DerGeneralizedTime NextUpdate
		{
			get
			{
				return null;
			}
		}

		public X509Extensions SingleExtensions
		{
			get
			{
				return null;
			}
		}

		public SingleResponse(CertID certID, CertStatus certStatus, DerGeneralizedTime thisUpdate, DerGeneralizedTime nextUpdate, X509Extensions singleExtensions)
		{
		}

		public SingleResponse(Asn1Sequence seq)
		{
		}

		public static SingleResponse GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		public static SingleResponse GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
