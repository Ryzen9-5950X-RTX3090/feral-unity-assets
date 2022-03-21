using System;
using System.Net;
using System.Runtime.Serialization;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	[Serializable]
	public class IDPRejectedClaimException : AmazonSecurityTokenServiceException
	{
		public IDPRejectedClaimException(string message)
		{
		}

		public IDPRejectedClaimException(string message, Exception innerException)
		{
		}

		public IDPRejectedClaimException(Exception innerException)
		{
		}

		public IDPRejectedClaimException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public IDPRejectedClaimException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		protected IDPRejectedClaimException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
