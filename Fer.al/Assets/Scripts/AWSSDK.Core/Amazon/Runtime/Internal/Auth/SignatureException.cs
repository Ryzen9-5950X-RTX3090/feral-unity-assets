using System;
using System.Runtime.Serialization;

namespace Amazon.Runtime.Internal.Auth
{
	[Serializable]
	public class SignatureException : Exception
	{
		public SignatureException(string message)
		{
		}

		public SignatureException(string message, Exception innerException)
		{
		}

		protected SignatureException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
