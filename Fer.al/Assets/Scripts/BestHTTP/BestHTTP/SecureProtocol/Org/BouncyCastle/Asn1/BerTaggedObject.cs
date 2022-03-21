namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class BerTaggedObject : DerTaggedObject
	{
		public BerTaggedObject(int tagNo, Asn1Encodable obj)
		{
		}

		public BerTaggedObject(bool explicitly, int tagNo, Asn1Encodable obj)
		{
		}

		public BerTaggedObject(int tagNo)
		{
		}

		internal override void Encode(DerOutputStream derOut)
		{
		}
	}
}
