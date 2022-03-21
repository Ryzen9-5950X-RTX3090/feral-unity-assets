using System;

namespace Amazon.Runtime.Internal
{
	public class EndpointResolver : PipelineHandler
	{
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
		{
			return null;
		}

		protected void PreInvoke(IExecutionContext executionContext)
		{
		}

		public virtual Uri DetermineEndpoint(IRequestContext requestContext)
		{
			return null;
		}

		public static Uri DetermineEndpoint(IClientConfig config, IRequest request)
		{
			return null;
		}

		private static Uri InjectHostPrefix(IClientConfig config, IRequest request, Uri endpoint)
		{
			return null;
		}
	}
}
