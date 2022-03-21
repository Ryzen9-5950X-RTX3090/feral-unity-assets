using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	internal class LazyDerSet : DerSet
	{
		private byte[] encoded;

		public override Asn1Encodable this[int index]
		{
			get
			{
				return null;
			}
		}

		public override int Count
		{
			get
			{
				return default(int);
			}
		}

		internal LazyDerSet(byte[] encoded)
		{
		}

		private void Parse()
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		internal override void Encode(DerOutputStream derOut)
		{
		}
	}
}
