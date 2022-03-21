using System;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class TlsFatalAlert : TlsException
	{
		private readonly byte alertDescription;

		public virtual byte AlertDescription
		{
			get
			{
				return default(byte);
			}
		}

		public TlsFatalAlert(byte alertDescription)
		{
		}

		public TlsFatalAlert(byte alertDescription, Exception alertCause)
		{
		}
	}
}
