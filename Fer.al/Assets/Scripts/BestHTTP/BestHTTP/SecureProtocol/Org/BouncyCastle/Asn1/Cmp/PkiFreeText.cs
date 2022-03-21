namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
{
	public class PkiFreeText : Asn1Encodable
	{
		internal Asn1Sequence strings;

		public int Size
		{
			get
			{
				return default(int);
			}
		}

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public DerUtf8String this[int index]
		{
			get
			{
				return null;
			}
		}

		public static PkiFreeText GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		public static PkiFreeText GetInstance(object obj)
		{
			return null;
		}

		public PkiFreeText(Asn1Sequence seq)
		{
		}

		public PkiFreeText(DerUtf8String p)
		{
		}

		public DerUtf8String GetStringAt(int index)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
