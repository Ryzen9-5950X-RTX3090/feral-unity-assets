using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Zip
{
	[Serializable]
	public class ZipException : SharpZipBaseException
	{
		protected ZipException(SerializationInfo info, StreamingContext context)
		{
		}

		public ZipException()
		{
		}

		public ZipException(string message)
		{
		}
	}
}
