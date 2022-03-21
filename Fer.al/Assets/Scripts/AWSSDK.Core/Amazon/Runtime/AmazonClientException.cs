using System;
using System.Runtime.Serialization;

namespace Amazon.Runtime
{
	[Serializable]
	public class AmazonClientException : Exception
	{
		public AmazonClientException(string message)
		{
		}

		public AmazonClientException(string message, Exception innerException)
		{
		}

		protected AmazonClientException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
