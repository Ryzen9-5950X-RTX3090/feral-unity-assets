namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class DerApplicationSpecific : Asn1Object
	{
		private readonly bool isConstructed;

		private readonly int tag;

		private readonly byte[] octets;

		public int ApplicationTag
		{
			get
			{
				return default(int);
			}
		}

		internal DerApplicationSpecific(bool isConstructed, int tag, byte[] octets)
		{
		}

		public DerApplicationSpecific(int tag, byte[] octets)
		{
		}

		public DerApplicationSpecific(int tag, Asn1Encodable obj)
		{
		}

		public DerApplicationSpecific(bool isExplicit, int tag, Asn1Encodable obj)
		{
		}

		public DerApplicationSpecific(int tagNo, Asn1EncodableVector vec)
		{
		}

		private int GetLengthOfHeader(byte[] data)
		{
			return default(int);
		}

		public bool IsConstructed()
		{
			return default(bool);
		}

		public byte[] GetContents()
		{
			return null;
		}

		public Asn1Object GetObject()
		{
			return null;
		}

		public Asn1Object GetObject(int derTagNo)
		{
			return null;
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

		private byte[] ReplaceTagNumber(int newTag, byte[] input)
		{
			return null;
		}
	}
}
