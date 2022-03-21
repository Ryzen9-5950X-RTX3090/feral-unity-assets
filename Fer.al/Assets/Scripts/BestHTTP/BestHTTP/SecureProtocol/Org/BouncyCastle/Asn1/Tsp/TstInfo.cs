using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
{
	public class TstInfo : Asn1Encodable
	{
		private readonly DerInteger version;

		private readonly DerObjectIdentifier tsaPolicyId;

		private readonly MessageImprint messageImprint;

		private readonly DerInteger serialNumber;

		private readonly DerGeneralizedTime genTime;

		private readonly Accuracy accuracy;

		private readonly DerBoolean ordering;

		private readonly DerInteger nonce;

		private readonly GeneralName tsa;

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

		public DerObjectIdentifier Policy
		{
			get
			{
				return null;
			}
		}

		public DerInteger SerialNumber
		{
			get
			{
				return null;
			}
		}

		public Accuracy Accuracy
		{
			get
			{
				return null;
			}
		}

		public DerGeneralizedTime GenTime
		{
			get
			{
				return null;
			}
		}

		public DerBoolean Ordering
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

		public GeneralName Tsa
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

		public static TstInfo GetInstance(object obj)
		{
			return null;
		}

		private TstInfo(Asn1Sequence seq)
		{
		}

		public TstInfo(DerObjectIdentifier tsaPolicyId, MessageImprint messageImprint, DerInteger serialNumber, DerGeneralizedTime genTime, Accuracy accuracy, DerBoolean ordering, DerInteger nonce, GeneralName tsa, X509Extensions extensions)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
