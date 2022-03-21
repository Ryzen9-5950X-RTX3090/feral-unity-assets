using System;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
	public class AttributeCertificateIssuer : IX509Selector, ICloneable
	{
		internal readonly Asn1Encodable form;

		public AttributeCertificateIssuer(AttCertIssuer issuer)
		{
		}

		public AttributeCertificateIssuer(X509Name principal)
		{
		}

		private object[] GetNames()
		{
			return null;
		}

		public X509Name[] GetPrincipals()
		{
			return null;
		}

		private bool MatchesDN(X509Name subject, GeneralNames targets)
		{
			return default(bool);
		}

		public object Clone()
		{
			return null;
		}

		public bool Match(X509Certificate x509Cert)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public bool Match(object obj)
		{
			return default(bool);
		}
	}
}
