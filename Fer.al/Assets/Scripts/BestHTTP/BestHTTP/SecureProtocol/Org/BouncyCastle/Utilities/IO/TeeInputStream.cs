using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
{
	public class TeeInputStream : BaseInputStream
	{
		private readonly Stream input;

		private readonly Stream tee;

		public TeeInputStream(Stream input, Stream tee)
		{
		}

		public override void Close()
		{
		}

		public override int Read(byte[] buf, int off, int len)
		{
			return default(int);
		}

		public override int ReadByte()
		{
			return default(int);
		}
	}
}
