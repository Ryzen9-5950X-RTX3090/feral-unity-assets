using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class HeartbeatExtension
	{
		protected readonly byte mMode;

		public virtual byte Mode
		{
			get
			{
				return default(byte);
			}
		}

		public HeartbeatExtension(byte mode)
		{
		}

		public virtual void Encode(Stream output)
		{
		}

		public static HeartbeatExtension Parse(Stream input)
		{
			return null;
		}
	}
}
