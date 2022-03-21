using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class CertificateStatusRequest
	{
		protected readonly byte mStatusType;

		protected readonly object mRequest;

		public virtual byte StatusType
		{
			get
			{
				return default(byte);
			}
		}

		public virtual object Request
		{
			get
			{
				return null;
			}
		}

		public CertificateStatusRequest(byte statusType, object request)
		{
		}

		public virtual OcspStatusRequest GetOcspStatusRequest()
		{
			return null;
		}

		public virtual void Encode(Stream output)
		{
		}

		public static CertificateStatusRequest Parse(Stream input)
		{
			return null;
		}

		protected static bool IsCorrectType(byte statusType, object request)
		{
			return default(bool);
		}
	}
}
