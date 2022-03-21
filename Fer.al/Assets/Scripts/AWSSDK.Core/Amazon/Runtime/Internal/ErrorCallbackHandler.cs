using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	public class ErrorCallbackHandler : PipelineHandler
	{
		public Action<IExecutionContext, Exception> OnError
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

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
		{
		}

		protected void HandleException(IExecutionContext executionContext, Exception exception)
		{
		}
	}
}
