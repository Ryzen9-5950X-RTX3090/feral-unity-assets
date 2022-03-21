namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
{
	public class CertRequest : Asn1Encodable
	{
		private readonly DerInteger certReqId;

		private readonly CertTemplate certTemplate;

		private readonly Controls controls;

		public virtual DerInteger CertReqID
		{
			get
			{
				return null;
			}
		}

		public virtual CertTemplate CertTemplate
		{
			get
			{
				return null;
			}
		}

		public virtual Controls Controls
		{
			get
			{
				return null;
			}
		}

		private CertRequest(Asn1Sequence seq)
		{
		}

		public static CertRequest GetInstance(object obj)
		{
			return null;
		}

		public CertRequest(int certReqId, CertTemplate certTemplate, Controls controls)
		{
		}

		public CertRequest(DerInteger certReqId, CertTemplate certTemplate, Controls controls)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
