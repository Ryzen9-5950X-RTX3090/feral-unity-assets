namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class TlsFatalAlertReceived : TlsException
	{
		private readonly byte alertDescription;

		public virtual byte AlertDescription
		{
			get
			{
				return default(byte);
			}
		}

		public TlsFatalAlertReceived(byte alertDescription)
		{
		}
	}
}
