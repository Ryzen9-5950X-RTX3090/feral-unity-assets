namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
{
	public class AttributeX509 : Asn1Encodable
	{
		private readonly DerObjectIdentifier attrType;

		private readonly Asn1Set attrValues;

		public DerObjectIdentifier AttrType
		{
			get
			{
				return null;
			}
		}

		public Asn1Set AttrValues
		{
			get
			{
				return null;
			}
		}

		public static AttributeX509 GetInstance(object obj)
		{
			return null;
		}

		private AttributeX509(Asn1Sequence seq)
		{
		}

		public AttributeX509(DerObjectIdentifier attrType, Asn1Set attrValues)
		{
		}

		public Asn1Encodable[] GetAttributeValues()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
