namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public abstract class Asn1TaggedObject : Asn1Object, Asn1TaggedObjectParser, IAsn1Convertible
	{
		internal int tagNo;

		internal bool explicitly;

		internal Asn1Encodable obj;

		public int TagNo
		{
			get
			{
				return default(int);
			}
		}

		internal static bool IsConstructed(bool isExplicit, Asn1Object obj)
		{
			return default(bool);
		}

		public static Asn1TaggedObject GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		public static Asn1TaggedObject GetInstance(object obj)
		{
			return null;
		}

		protected Asn1TaggedObject(int tagNo, Asn1Encodable obj)
		{
		}

		protected Asn1TaggedObject(bool explicitly, int tagNo, Asn1Encodable obj)
		{
		}

		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		protected override int Asn1GetHashCode()
		{
			return default(int);
		}

		public bool IsExplicit()
		{
			return default(bool);
		}

		public bool IsEmpty()
		{
			return default(bool);
		}

		public Asn1Object GetObject()
		{
			return null;
		}

		public IAsn1Convertible GetObjectParser(int tag, bool isExplicit)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
