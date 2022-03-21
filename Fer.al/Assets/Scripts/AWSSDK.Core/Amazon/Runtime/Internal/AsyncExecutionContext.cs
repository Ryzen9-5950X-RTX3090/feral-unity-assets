using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Internal
{
	public class AsyncExecutionContext : IAsyncExecutionContext
	{
		public IAsyncResponseContext ResponseContext
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

		public IAsyncRequestContext RequestContext
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

		public object RuntimeState
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

		public AsyncExecutionContext(bool enableMetrics, AbstractAWSSigner clientSigner)
		{
		}

		public AsyncExecutionContext(IAsyncRequestContext requestContext, IAsyncResponseContext responseContext)
		{
		}
	}
}
