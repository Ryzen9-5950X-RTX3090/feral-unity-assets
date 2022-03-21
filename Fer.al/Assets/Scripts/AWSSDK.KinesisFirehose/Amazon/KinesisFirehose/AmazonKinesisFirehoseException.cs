using System;
using System.Net;
using System.Runtime.Serialization;
using Amazon.Runtime;

namespace Amazon.KinesisFirehose
{
	[Serializable]
	public class AmazonKinesisFirehoseException : AmazonServiceException
	{
		public AmazonKinesisFirehoseException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		protected AmazonKinesisFirehoseException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
