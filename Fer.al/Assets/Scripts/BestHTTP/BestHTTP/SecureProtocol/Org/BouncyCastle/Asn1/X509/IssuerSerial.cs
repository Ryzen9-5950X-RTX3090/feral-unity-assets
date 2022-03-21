namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
{
	public class IssuerSerial : Asn1Encodable
	{
		internal readonly GeneralNames issuer;

		internal readonly DerInteger serial;

		internal readonly DerBitString issuerUid;

		public GeneralNames Issuer
		{
			get
			{
				return null;
			}
		}

		public DerInteger Serial
		{
			get
			{
				return null;
			}
		}

		public DerBitString IssuerUid
		{
			get
			{
				return null;
			}
		}

		public static IssuerSerial GetInstance(object obj)
		{
			return null;
		}

		public static IssuerSerial GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		private IssuerSerial(Asn1Sequence seq)
		{
		}

		public IssuerSerial(GeneralNames issuer, DerInteger serial)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
