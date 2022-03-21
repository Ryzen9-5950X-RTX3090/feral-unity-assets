using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Amazon.Runtime
{
	[Serializable]
	public class AmazonUnmarshallingException : AmazonServiceException
	{
		public string LastKnownLocation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string ResponseBody
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override string Message
		{
			get
			{
				return null;
			}
		}

		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, Exception innerException)
		{
		}

		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, Exception innerException)
		{
		}

		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string message, Exception innerException)
		{
		}

		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, Exception innerException, HttpStatusCode statusCode)
		{
		}

		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, Exception innerException, HttpStatusCode statusCode)
		{
		}

		private static void AppendFormat(StringBuilder sb, string format, string value)
		{
		}

		protected AmazonUnmarshallingException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
