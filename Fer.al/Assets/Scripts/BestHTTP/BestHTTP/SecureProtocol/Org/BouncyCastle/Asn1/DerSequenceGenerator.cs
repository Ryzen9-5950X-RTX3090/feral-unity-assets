using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class DerSequenceGenerator : DerGenerator
	{
		private readonly MemoryStream _bOut;

		public DerSequenceGenerator(Stream outStream)
		{
		}

		public DerSequenceGenerator(Stream outStream, int tagNo, bool isExplicit)
		{
		}

		public override void AddObject(Asn1Encodable obj)
		{
		}

		public override Stream GetRawOutputStream()
		{
			return null;
		}

		public override void Close()
		{
		}
	}
}
