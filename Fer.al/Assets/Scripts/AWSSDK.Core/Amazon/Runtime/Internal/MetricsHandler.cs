using System;

namespace Amazon.Runtime.Internal
{
	public class MetricsHandler : PipelineHandler
	{
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
		{
			return null;
		}

		protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
		{
		}
	}
}
