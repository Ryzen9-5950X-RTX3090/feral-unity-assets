using System;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Security.Certificates
{
	[Serializable]
	public class CertificateNotYetValidException : CertificateException
	{
		public CertificateNotYetValidException()
		{
		}

		public CertificateNotYetValidException(string message)
		{
		}

		public CertificateNotYetValidException(string message, Exception exception)
		{
		}
	}
}
