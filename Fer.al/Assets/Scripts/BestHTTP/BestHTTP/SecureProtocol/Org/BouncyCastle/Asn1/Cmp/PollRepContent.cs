namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
{
	public class PollRepContent : Asn1Encodable
	{
		private readonly DerInteger certReqId;

		private readonly DerInteger checkAfter;

		private readonly PkiFreeText reason;

		public virtual DerInteger CertReqID
		{
			get
			{
				return null;
			}
		}

		public virtual DerInteger CheckAfter
		{
			get
			{
				return null;
			}
		}

		public virtual PkiFreeText Reason
		{
			get
			{
				return null;
			}
		}

		private PollRepContent(Asn1Sequence seq)
		{
		}

		public static PollRepContent GetInstance(object obj)
		{
			return null;
		}

		public PollRepContent(DerInteger certReqId, DerInteger checkAfter)
		{
		}

		public PollRepContent(DerInteger certReqId, DerInteger checkAfter, PkiFreeText reason)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
