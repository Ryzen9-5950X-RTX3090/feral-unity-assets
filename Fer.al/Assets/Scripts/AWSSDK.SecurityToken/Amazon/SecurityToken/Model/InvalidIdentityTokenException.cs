using System;
using System.Net;
using System.Runtime.Serialization;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	[Serializable]
	public class InvalidIdentityTokenException : AmazonSecurityTokenServiceException
	{
		public InvalidIdentityTokenException(string message)
		{
		}

		public InvalidIdentityTokenException(string message, Exception innerException)
		{
		}

		public InvalidIdentityTokenException(Exception innerException)
		{
		}

		public InvalidIdentityTokenException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public InvalidIdentityTokenException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		protected InvalidIdentityTokenException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
