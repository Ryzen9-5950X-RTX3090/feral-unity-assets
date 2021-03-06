using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
	public class X509KeyUsage : Asn1Encodable
	{
		public const int DigitalSignature = 128;

		public const int NonRepudiation = 64;

		public const int KeyEncipherment = 32;

		public const int DataEncipherment = 16;

		public const int KeyAgreement = 8;

		public const int KeyCertSign = 4;

		public const int CrlSign = 2;

		public const int EncipherOnly = 1;

		public const int DecipherOnly = 32768;

		private readonly int usage;

		public X509KeyUsage(int usage)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
