namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500
{
	public class AttributeTypeAndValue : Asn1Encodable
	{
		private readonly DerObjectIdentifier type;

		private readonly Asn1Encodable value;

		public virtual DerObjectIdentifier Type
		{
			get
			{
				return null;
			}
		}

		public virtual Asn1Encodable Value
		{
			get
			{
				return null;
			}
		}

		private AttributeTypeAndValue(Asn1Sequence seq)
		{
		}

		public static AttributeTypeAndValue GetInstance(object obj)
		{
			return null;
		}

		public AttributeTypeAndValue(DerObjectIdentifier type, Asn1Encodable value)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
