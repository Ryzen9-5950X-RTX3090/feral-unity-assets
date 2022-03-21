using System.IO;

namespace Amazon.Runtime.Internal.Util
{
	public class HashStream<T> : HashStream where T : IHashingWrapper, new()
	{
		public HashStream(Stream baseStream, byte[] expectedHash, long expectedLength)
		{
		}
	}
}
