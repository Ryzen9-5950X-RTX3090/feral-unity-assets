using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
{
	public class EncryptedData : Asn1Encodable
	{
		private readonly Asn1Sequence data;

		public DerObjectIdentifier ContentType
		{
			get
			{
				return null;
			}
		}

		public AlgorithmIdentifier EncryptionAlgorithm
		{
			get
			{
				return null;
			}
		}

		public Asn1OctetString Content
		{
			get
			{
				return null;
			}
		}

		public static EncryptedData GetInstance(object obj)
		{
			return null;
		}

		private EncryptedData(Asn1Sequence seq)
		{
		}

		public EncryptedData(DerObjectIdentifier contentType, AlgorithmIdentifier encryptionAlgorithm, Asn1Encodable content)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
