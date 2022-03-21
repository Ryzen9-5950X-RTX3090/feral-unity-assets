using System;
using System.Net;

namespace Amazon.Runtime
{
	[Serializable]
	public class AmazonWebServiceResponse
	{
		private ResponseMetadata responseMetadataField;

		private long contentLength;

		private HttpStatusCode httpStatusCode;

		public ResponseMetadata ResponseMetadata
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long ContentLength
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public HttpStatusCode HttpStatusCode
		{
			get
			{
				return default(HttpStatusCode);
			}
			set
			{
			}
		}
	}
}
