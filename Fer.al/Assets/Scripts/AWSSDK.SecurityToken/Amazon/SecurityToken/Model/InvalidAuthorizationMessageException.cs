using System;
using System.Net;
using System.Runtime.Serialization;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	[Serializable]
	public class InvalidAuthorizationMessageException : AmazonSecurityTokenServiceException
	{
		public InvalidAuthorizationMessageException(string message)
		{
		}

		public InvalidAuthorizationMessageException(string message, Exception innerException)
		{
		}

		public InvalidAuthorizationMessageException(Exception innerException)
		{
		}

		public InvalidAuthorizationMessageException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public InvalidAuthorizationMessageException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		protected InvalidAuthorizationMessageException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
