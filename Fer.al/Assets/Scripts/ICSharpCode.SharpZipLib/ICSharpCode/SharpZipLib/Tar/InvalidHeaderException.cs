using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Tar
{
	[Serializable]
	public class InvalidHeaderException : TarException
	{
		protected InvalidHeaderException(SerializationInfo information, StreamingContext context)
		{
		}

		public InvalidHeaderException()
		{
		}

		public InvalidHeaderException(string message)
		{
		}
	}
}
