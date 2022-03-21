using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
	public class TimeStampAndCrl : Asn1Encodable
	{
		private ContentInfo timeStamp;

		private CertificateList crl;

		public virtual ContentInfo TimeStampToken
		{
			get
			{
				return null;
			}
		}

		public virtual CertificateList Crl
		{
			get
			{
				return null;
			}
		}

		public TimeStampAndCrl(ContentInfo timeStamp)
		{
		}

		private TimeStampAndCrl(Asn1Sequence seq)
		{
		}

		public static TimeStampAndCrl GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
