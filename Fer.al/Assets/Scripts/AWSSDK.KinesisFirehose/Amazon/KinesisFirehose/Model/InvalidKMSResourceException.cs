using System;
using System.Net;
using System.Runtime.Serialization;
using Amazon.Runtime;

namespace Amazon.KinesisFirehose.Model
{
	[Serializable]
	public class InvalidKMSResourceException : AmazonKinesisFirehoseException
	{
		private string _code;

		public string Code
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InvalidKMSResourceException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		protected InvalidKMSResourceException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
