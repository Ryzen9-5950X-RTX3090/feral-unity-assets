using System;
using System.Net;
using System.Runtime.Serialization;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	[Serializable]
	public class MalformedPolicyDocumentException : AmazonSecurityTokenServiceException
	{
		public MalformedPolicyDocumentException(string message)
		{
		}

		public MalformedPolicyDocumentException(string message, Exception innerException)
		{
		}

		public MalformedPolicyDocumentException(Exception innerException)
		{
		}

		public MalformedPolicyDocumentException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public MalformedPolicyDocumentException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		protected MalformedPolicyDocumentException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
