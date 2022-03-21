namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class DtlsTransport : DatagramTransport, TlsCloseable
	{
		private readonly DtlsRecordLayer mRecordLayer;

		internal DtlsTransport(DtlsRecordLayer recordLayer)
		{
		}

		public virtual int GetReceiveLimit()
		{
			return default(int);
		}

		public virtual int GetSendLimit()
		{
			return default(int);
		}

		public virtual int Receive(byte[] buf, int off, int len, int waitMillis)
		{
			return default(int);
		}

		public virtual void Send(byte[] buf, int off, int len)
		{
		}

		public virtual void Close()
		{
		}
	}
}
