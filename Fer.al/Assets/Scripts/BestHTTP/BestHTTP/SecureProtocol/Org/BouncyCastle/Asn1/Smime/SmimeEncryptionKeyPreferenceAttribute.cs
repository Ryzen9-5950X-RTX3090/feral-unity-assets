using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Smime
{
	public class SmimeEncryptionKeyPreferenceAttribute : AttributeX509
	{
		public SmimeEncryptionKeyPreferenceAttribute(IssuerAndSerialNumber issAndSer)
		{
		}

		public SmimeEncryptionKeyPreferenceAttribute(RecipientKeyIdentifier rKeyID)
		{
		}

		public SmimeEncryptionKeyPreferenceAttribute(Asn1OctetString sKeyID)
		{
		}
	}
}
