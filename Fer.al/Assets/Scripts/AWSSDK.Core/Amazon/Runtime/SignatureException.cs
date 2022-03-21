using System;
using System.Runtime.Serialization;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime
{
	[Serializable]
	public class SignatureException : Amazon.Runtime.Internal.Auth.SignatureException
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
