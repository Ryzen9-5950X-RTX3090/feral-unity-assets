using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
{
	public class TimeStampReq : Asn1Encodable
	{
		private readonly DerInteger version;

		private readonly MessageImprint messageImprint;

		private readonly DerObjectIdentifier tsaPolicy;

		private readonly DerInteger nonce;

		private readonly DerBoolean certReq;

		private readonly X509Extensions extensions;

		public DerInteger Version
		{
			get
			{
				return null;
			}
		}

		public MessageImprint MessageImprint
		{
			get
			{
				return null;
			}
		}

		public DerObjectIdentifier ReqPolicy
		{
			get
			{
				return null;
			}
		}

		public DerInteger Nonce
		{
			get
			{
				return null;
			}
		}

		public DerBoolean CertReq
		{
			get
			{
				return null;
			}
		}

		public X509Extensions Extensions
		{
			get
			{
				return null;
			}
		}

		public static TimeStampReq GetInstance(object obj)
		{
			return null;
		}

		private TimeStampReq(Asn1Sequence seq)
		{
		}

		public TimeStampReq(MessageImprint messageImprint, DerObjectIdentifier tsaPolicy, DerInteger nonce, DerBoolean certReq, X509Extensions extensions)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
