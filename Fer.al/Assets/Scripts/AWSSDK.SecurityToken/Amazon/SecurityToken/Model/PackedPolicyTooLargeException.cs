using System;
using System.Net;
using System.Runtime.Serialization;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	[Serializable]
	public class PackedPolicyTooLargeException : AmazonSecurityTokenServiceException
	{
		public PackedPolicyTooLargeException(string message)
		{
		}

		public PackedPolicyTooLargeException(string message, Exception innerException)
		{
		}

		public PackedPolicyTooLargeException(Exception innerException)
		{
		}

		public PackedPolicyTooLargeException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public PackedPolicyTooLargeException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		protected PackedPolicyTooLargeException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
