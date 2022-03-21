using System;
using System.Net;
using System.Runtime.Serialization;
using Amazon.Runtime;

namespace Amazon.KinesisFirehose.Model
{
	[Serializable]
	public class ServiceUnavailableException : AmazonKinesisFirehoseException
	{
		public ServiceUnavailableException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		protected ServiceUnavailableException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
