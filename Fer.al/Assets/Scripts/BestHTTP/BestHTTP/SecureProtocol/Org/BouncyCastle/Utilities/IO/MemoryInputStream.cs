using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
{
	public class MemoryInputStream : MemoryStream
	{
		public sealed override bool CanWrite
		{
			get
			{
				return default(bool);
			}
		}

		public MemoryInputStream(byte[] buffer)
		{
		}
	}
}
