using System;

namespace Amazon.Runtime.Internal
{
	public class Signer : PipelineHandler
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

		private static bool ShouldSign(IRequestContext requestContext)
		{
			return default(bool);
		}

		public static void SignRequest(IRequestContext requestContext)
		{
		}
	}
}
