namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
{
	public class AttributeCertificate : Asn1Encodable
	{
		private readonly AttributeCertificateInfo acinfo;

		private readonly AlgorithmIdentifier signatureAlgorithm;

		private readonly DerBitString signatureValue;

		public AttributeCertificateInfo ACInfo
		{
			get
			{
				return null;
			}
		}

		public AlgorithmIdentifier SignatureAlgorithm
		{
			get
			{
				return null;
			}
		}

		public DerBitString SignatureValue
		{
			get
			{
				return null;
			}
		}

		public static AttributeCertificate GetInstance(object obj)
		{
			return null;
		}

		public AttributeCertificate(AttributeCertificateInfo acinfo, AlgorithmIdentifier signatureAlgorithm, DerBitString signatureValue)
		{
		}

		private AttributeCertificate(Asn1Sequence seq)
		{
		}

		public byte[] GetSignatureOctets()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
