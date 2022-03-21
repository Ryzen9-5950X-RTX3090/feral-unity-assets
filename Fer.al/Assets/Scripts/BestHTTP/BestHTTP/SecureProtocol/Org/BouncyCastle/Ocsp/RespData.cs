using System;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
	public class RespData : X509ExtensionBase
	{
		internal readonly ResponseData data;

		public int Version
		{
			get
			{
				return default(int);
			}
		}

		public DateTime ProducedAt
		{
			get
			{
				return default(DateTime);
			}
		}

		public X509Extensions ResponseExtensions
		{
			get
			{
				return null;
			}
		}

		public RespData(ResponseData data)
		{
		}

		public RespID GetResponderId()
		{
			return null;
		}

		public SingleResp[] GetResponses()
		{
			return null;
		}

		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}
	}
}
