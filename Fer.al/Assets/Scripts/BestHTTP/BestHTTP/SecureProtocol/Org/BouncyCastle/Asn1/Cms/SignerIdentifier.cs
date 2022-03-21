namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
	public class SignerIdentifier : Asn1Encodable, IAsn1Choice
	{
		private Asn1Encodable id;

		public bool IsTagged
		{
			get
			{
				return default(bool);
			}
		}

		public Asn1Encodable ID
		{
			get
			{
				return null;
			}
		}

		public SignerIdentifier(IssuerAndSerialNumber id)
		{
		}

		public SignerIdentifier(Asn1OctetString id)
		{
		}

		public SignerIdentifier(Asn1Object id)
		{
		}

		public static SignerIdentifier GetInstance(object o)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
