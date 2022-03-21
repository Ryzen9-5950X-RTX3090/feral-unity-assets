using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
	public class X509CertificatePair
	{
		private readonly X509Certificate forward;

		private readonly X509Certificate reverse;

		public X509Certificate Forward
		{
			get
			{
				return null;
			}
		}

		public X509Certificate Reverse
		{
			get
			{
				return null;
			}
		}

		public X509CertificatePair(X509Certificate forward, X509Certificate reverse)
		{
		}

		public X509CertificatePair(CertificatePair pair)
		{
		}

		public byte[] GetEncoded()
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
	}
}
