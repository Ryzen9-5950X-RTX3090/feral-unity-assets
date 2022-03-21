using System;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
	public class SingleResp : X509ExtensionBase
	{
		internal readonly SingleResponse resp;

		public DateTime ThisUpdate
		{
			get
			{
				return default(DateTime);
			}
		}

		public DateTimeObject NextUpdate
		{
			get
			{
				return null;
			}
		}

		public X509Extensions SingleExtensions
		{
			get
			{
				return null;
			}
		}

		public SingleResp(SingleResponse resp)
		{
		}

		public CertificateID GetCertID()
		{
			return null;
		}

		public object GetCertStatus()
		{
			return null;
		}

		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}
	}
}
