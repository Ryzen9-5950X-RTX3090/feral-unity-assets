using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Amazon.Runtime
{
	[Serializable]
	public class AmazonDateTimeUnmarshallingException : AmazonUnmarshallingException
	{
		public string InvalidDateTimeToken
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

		public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string invalidDateTimeToken, Exception innerException)
		{
		}

		public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string invalidDateTimeToken, Exception innerException)
		{
		}

		public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string invalidDateTimeToken, string message, Exception innerException)
		{
		}

		protected AmazonDateTimeUnmarshallingException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
