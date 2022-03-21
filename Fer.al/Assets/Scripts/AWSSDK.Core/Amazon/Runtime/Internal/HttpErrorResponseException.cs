using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Runtime.Internal
{
	[Serializable]
	public class HttpErrorResponseException : Exception
	{
		public IWebResponseData Response
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

		public HttpErrorResponseException(IWebResponseData response)
		{
		}

		public HttpErrorResponseException(string message, IWebResponseData response)
		{
		}

		public HttpErrorResponseException(string message, Exception innerException, IWebResponseData response)
		{
		}

		protected HttpErrorResponseException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
