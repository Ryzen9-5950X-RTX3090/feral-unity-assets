using System;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
	public class X509CrlEntry : X509ExtensionBase
	{
		private CrlEntry c;

		private bool isIndirect;

		private X509Name previousCertificateIssuer;

		private X509Name certificateIssuer;

		private bool hashValueSet;

		private int hashValue;

		public BigInteger SerialNumber
		{
			get
			{
				return null;
			}
		}

		public DateTime RevocationDate
		{
			get
			{
				return default(DateTime);
			}
		}

		public bool HasExtensions
		{
			get
			{
				return default(bool);
			}
		}

		public X509CrlEntry(CrlEntry c)
		{
		}

		public X509CrlEntry(CrlEntry c, bool isIndirect, X509Name previousCertificateIssuer)
		{
		}

		private X509Name loadCertificateIssuer()
		{
			return null;
		}

		public X509Name GetCertificateIssuer()
		{
			return null;
		}

		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}

		public byte[] GetEncoded()
		{
			return null;
		}

		public override bool Equals(object other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
