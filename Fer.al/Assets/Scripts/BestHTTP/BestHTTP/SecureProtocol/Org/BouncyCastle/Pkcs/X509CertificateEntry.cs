using System;
using System.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
{
	public class X509CertificateEntry : Pkcs12Entry
	{
		private readonly X509Certificate cert;

		public X509Certificate Certificate
		{
			get
			{
				return null;
			}
		}

		public X509CertificateEntry(X509Certificate cert)
		{
		}

		[Obsolete]
		public X509CertificateEntry(X509Certificate cert, Hashtable attributes)
		{
		}

		public X509CertificateEntry(X509Certificate cert, IDictionary attributes)
		{
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
