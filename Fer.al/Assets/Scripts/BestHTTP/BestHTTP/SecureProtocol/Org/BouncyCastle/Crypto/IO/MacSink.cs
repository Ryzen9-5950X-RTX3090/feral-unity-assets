using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
{
	public class MacSink : BaseOutputStream
	{
		private readonly IMac mMac;

		public virtual IMac Mac
		{
			get
			{
				return null;
			}
		}

		public MacSink(IMac mac)
		{
		}

		public override void WriteByte(byte b)
		{
		}

		public override void Write(byte[] buf, int off, int len)
		{
		}
	}
}
