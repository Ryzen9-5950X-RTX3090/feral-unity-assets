using System;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Internal
{
	public class AsyncRequestContext : RequestContext, IAsyncRequestContext, IRequestContext
	{
		public AsyncCallback Callback
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public object State
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public AsyncOptions AsyncOptions
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> Action
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public AsyncRequestContext(bool enableMetrics, AbstractAWSSigner clientSigner)
		{
		}
	}
}
