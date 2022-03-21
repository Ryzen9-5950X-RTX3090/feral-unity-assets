using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class DerSetGenerator : DerGenerator
	{
		private readonly MemoryStream _bOut;

		public DerSetGenerator(Stream outStream)
		{
		}

		public DerSetGenerator(Stream outStream, int tagNo, bool isExplicit)
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
