namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
{
	public sealed class PolicyQualifierID : DerObjectIdentifier
	{
		private const string IdQt = "1.3.6.1.5.5.7.2";

		public static readonly PolicyQualifierID IdQtCps;

		public static readonly PolicyQualifierID IdQtUnotice;

		private PolicyQualifierID(string id)
		{
		}
	}
}
