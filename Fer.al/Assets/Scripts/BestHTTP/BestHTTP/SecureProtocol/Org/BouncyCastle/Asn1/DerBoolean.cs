namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class DerBoolean : Asn1Object
	{
		private readonly byte value;

		public static readonly DerBoolean False;

		public static readonly DerBoolean True;

		public bool IsTrue
		{
			get
			{
				return default(bool);
			}
		}

		public static DerBoolean GetInstance(object obj)
		{
			return null;
		}

		public static DerBoolean GetInstance(bool value)
		{
			return null;
		}

		public static DerBoolean GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		public DerBoolean(byte[] val)
		{
		}

		private DerBoolean(bool value)
		{
		}

		internal override void Encode(DerOutputStream derOut)
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

		public override string ToString()
		{
			return null;
		}

		internal static DerBoolean FromOctetString(byte[] value)
		{
			return null;
		}
	}
}
