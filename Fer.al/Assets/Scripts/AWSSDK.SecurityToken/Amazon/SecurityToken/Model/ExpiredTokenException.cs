using System;
using System.Net;
using System.Runtime.Serialization;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	[Serializable]
	public class ExpiredTokenException : AmazonSecurityTokenServiceException
	{
		public ExpiredTokenException(string message)
		{
		}

		public ExpiredTokenException(string message, Exception innerException)
		{
		}

		public ExpiredTokenException(Exception innerException)
		{
		}

		public ExpiredTokenException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public ExpiredTokenException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		protected ExpiredTokenException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
