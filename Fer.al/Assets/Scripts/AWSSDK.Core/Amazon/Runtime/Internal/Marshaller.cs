using System;

namespace Amazon.Runtime.Internal
{
	public class Marshaller : PipelineHandler
	{
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
		{
			return null;
		}

		protected static void PreInvoke(IExecutionContext executionContext)
		{
		}
	}
}
