using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public class AmazonServiceResult<TRequest, TResponse> where TRequest : AmazonWebServiceRequest where TResponse : AmazonWebServiceResponse
	{
		public TRequest Request
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public TResponse Response
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public object state
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public AmazonServiceResult(TRequest request, TResponse response, Exception exception, object state)
		{
		}
	}
}
