using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
{
	public class MemoryOutputStream : MemoryStream
	{
		public sealed override bool CanRead
		{
			get
			{
				return default(bool);
			}
		}
	}
}
