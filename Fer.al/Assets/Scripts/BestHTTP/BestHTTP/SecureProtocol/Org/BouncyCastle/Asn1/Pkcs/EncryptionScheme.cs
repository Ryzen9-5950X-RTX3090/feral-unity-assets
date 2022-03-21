using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
{
	public class EncryptionScheme : AlgorithmIdentifier
	{
		public Asn1Object Asn1Object
		{
			get
			{
				return null;
			}
		}

		public EncryptionScheme(DerObjectIdentifier objectID)
		{
		}

		public EncryptionScheme(DerObjectIdentifier objectID, Asn1Encodable parameters)
		{
		}

		internal EncryptionScheme(Asn1Sequence seq)
		{
		}

		public new static EncryptionScheme GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
