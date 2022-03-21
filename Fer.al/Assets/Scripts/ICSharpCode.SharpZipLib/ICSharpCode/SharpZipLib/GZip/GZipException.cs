using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.GZip
{
	[Serializable]
	public class GZipException : SharpZipBaseException
	{
		protected GZipException(SerializationInfo info, StreamingContext context)
		{
		}

		public GZipException()
		{
		}

		public GZipException(string message)
		{
		}
	}
}
