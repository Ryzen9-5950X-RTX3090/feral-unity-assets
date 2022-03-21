using System;
using System.Net;
using System.Runtime.Serialization;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	[Serializable]
	public class RegionDisabledException : AmazonSecurityTokenServiceException
	{
		public RegionDisabledException(string message)
		{
		}

		public RegionDisabledException(string message, Exception innerException)
		{
		}

		public RegionDisabledException(Exception innerException)
		{
		}

		public RegionDisabledException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public RegionDisabledException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		protected RegionDisabledException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
