using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
{
	public class TrustAnchor
	{
		private readonly AsymmetricKeyParameter pubKey;

		private readonly string caName;

		private readonly X509Name caPrincipal;

		private readonly X509Certificate trustedCert;

		private byte[] ncBytes;

		private NameConstraints nc;

		public X509Certificate TrustedCert
		{
			get
			{
				return null;
			}
		}

		public X509Name CA
		{
			get
			{
				return null;
			}
		}

		public string CAName
		{
			get
			{
				return null;
			}
		}

		public AsymmetricKeyParameter CAPublicKey
		{
			get
			{
				return null;
			}
		}

		public byte[] GetNameConstraints
		{
			get
			{
				return null;
			}
		}

		public TrustAnchor(X509Certificate trustedCert, byte[] nameConstraints)
		{
		}

		public TrustAnchor(X509Name caPrincipal, AsymmetricKeyParameter pubKey, byte[] nameConstraints)
		{
		}

		public TrustAnchor(string caName, AsymmetricKeyParameter pubKey, byte[] nameConstraints)
		{
		}

		private void setNameConstraints(byte[] bytes)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
