using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Tar
{
	[Serializable]
	public class TarException : SharpZipBaseException
	{
		protected TarException(SerializationInfo info, StreamingContext context)
		{
		}

		public TarException()
		{
		}

		public TarException(string message)
		{
		}

		public TarException(string message, Exception exception)
		{
		}
	}
}
