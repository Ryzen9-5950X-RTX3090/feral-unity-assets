using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
{
	public class PushbackStream : FilterStream
	{
		private int buf;

		public PushbackStream(Stream s)
		{
		}

		public override int ReadByte()
		{
			return default(int);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		public virtual void Unread(int b)
		{
		}
	}
}
