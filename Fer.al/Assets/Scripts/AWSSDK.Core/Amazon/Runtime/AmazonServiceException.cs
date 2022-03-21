using System;
using System.Net;
using System.Runtime.Serialization;

namespace Amazon.Runtime
{
	[Serializable]
	public class AmazonServiceException : Exception
	{
		private ErrorType errorType;

		private string errorCode;

		private string requestId;

		private HttpStatusCode statusCode;

		public ErrorType ErrorType
		{
			get
			{
				return default(ErrorType);
			}
			set
			{
			}
		}

		public string ErrorCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string RequestId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HttpStatusCode StatusCode
		{
			get
			{
				return default(HttpStatusCode);
			}
			set
			{
			}
		}

		public virtual RetryableDetails Retryable
		{
			get
			{
				return null;
			}
		}

		public AmazonServiceException()
		{
		}

		public AmazonServiceException(string message)
		{
		}

		public AmazonServiceException(string message, Exception innerException)
		{
		}

		public AmazonServiceException(string message, Exception innerException, HttpStatusCode statusCode)
		{
		}

		public AmazonServiceException(Exception innerException)
		{
		}

		public AmazonServiceException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public AmazonServiceException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		private static string BuildGenericErrorMessage(string errorCode, HttpStatusCode statusCode)
		{
			return null;
		}

		protected AmazonServiceException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
