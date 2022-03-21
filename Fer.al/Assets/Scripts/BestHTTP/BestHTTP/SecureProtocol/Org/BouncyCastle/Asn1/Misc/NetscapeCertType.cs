namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Misc
{
	public class NetscapeCertType : DerBitString
	{
		public const int SslClient = 128;

		public const int SslServer = 64;

		public const int Smime = 32;

		public const int ObjectSigning = 16;

		public const int Reserved = 8;

		public const int SslCA = 4;

		public const int SmimeCA = 2;

		public const int ObjectSigningCA = 1;

		public NetscapeCertType(int usage)
		{
		}

		public NetscapeCertType(DerBitString usage)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
