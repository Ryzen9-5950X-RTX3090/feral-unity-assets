using System;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
	public class RevokedStatus : CertificateStatus
	{
		internal readonly RevokedInfo info;

		public DateTime RevocationTime
		{
			get
			{
				return default(DateTime);
			}
		}

		public bool HasRevocationReason
		{
			get
			{
				return default(bool);
			}
		}

		public int RevocationReason
		{
			get
			{
				return default(int);
			}
		}

		public RevokedStatus(RevokedInfo info)
		{
		}

		public RevokedStatus(DateTime revocationDate, int reason)
		{
		}
	}
}
