using System;
using System.Net;
using System.Runtime.Serialization;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	[Serializable]
	public class IDPCommunicationErrorException : AmazonSecurityTokenServiceException
	{
		public IDPCommunicationErrorException(string message)
		{
		}

		public IDPCommunicationErrorException(string message, Exception innerException)
		{
		}

		public IDPCommunicationErrorException(Exception innerException)
		{
		}

		public IDPCommunicationErrorException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public IDPCommunicationErrorException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		protected IDPCommunicationErrorException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
