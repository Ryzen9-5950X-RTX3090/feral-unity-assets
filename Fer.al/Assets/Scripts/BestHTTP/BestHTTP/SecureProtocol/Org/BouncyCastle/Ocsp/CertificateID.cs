using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
	public class CertificateID
	{
		public const string HashSha1 = "1.3.14.3.2.26";

		private readonly CertID id;

		public string HashAlgOid
		{
			get
			{
				return null;
			}
		}

		public BigInteger SerialNumber
		{
			get
			{
				return null;
			}
		}

		public CertificateID(CertID id)
		{
		}

		public CertificateID(string hashAlgorithm, X509Certificate issuerCert, BigInteger serialNumber)
		{
		}

		public byte[] GetIssuerNameHash()
		{
			return null;
		}

		public byte[] GetIssuerKeyHash()
		{
			return null;
		}

		public bool MatchesIssuer(X509Certificate issuerCert)
		{
			return default(bool);
		}

		public CertID ToAsn1Object()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static CertificateID DeriveCertificateID(CertificateID original, BigInteger newSerialNumber)
		{
			return null;
		}

		private static CertID CreateCertID(AlgorithmIdentifier hashAlg, X509Certificate issuerCert, DerInteger serialNumber)
		{
			return null;
		}
	}
}
