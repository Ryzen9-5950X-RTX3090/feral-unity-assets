namespace Amazon.Runtime.Internal
{
	public class RedirectHandler : PipelineHandler
	{
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
		{
		}

		private bool HandleRedirect(IExecutionContext executionContext)
		{
			return default(bool);
		}

		protected virtual void FinalizeForRedirect(IExecutionContext executionContext, string redirectedLocation)
		{
		}
	}
}
