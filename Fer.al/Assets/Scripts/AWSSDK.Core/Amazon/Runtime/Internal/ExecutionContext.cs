using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Internal
{
	public class ExecutionContext : IExecutionContext
	{
		public IRequestContext RequestContext
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

		public IResponseContext ResponseContext
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

		public ExecutionContext(bool enableMetrics, AbstractAWSSigner clientSigner)
		{
		}

		public ExecutionContext(IRequestContext requestContext, IResponseContext responseContext)
		{
		}

		public static IExecutionContext CreateFromAsyncContext(IAsyncExecutionContext asyncContext)
		{
			return null;
		}
	}
}
