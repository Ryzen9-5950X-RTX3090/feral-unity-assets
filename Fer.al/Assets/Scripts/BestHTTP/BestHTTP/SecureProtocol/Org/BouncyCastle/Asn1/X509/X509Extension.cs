namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
{
	public class X509Extension
	{
		internal bool critical;

		internal Asn1OctetString value;

		public bool IsCritical
		{
			get
			{
				return default(bool);
			}
		}

		public Asn1OctetString Value
		{
			get
			{
				return null;
			}
		}

		public X509Extension(DerBoolean critical, Asn1OctetString value)
		{
		}

		public X509Extension(bool critical, Asn1OctetString value)
		{
		}

		public Asn1Encodable GetParsedValue()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public static Asn1Object ConvertValueToObject(X509Extension ext)
		{
			return null;
		}
	}
}
