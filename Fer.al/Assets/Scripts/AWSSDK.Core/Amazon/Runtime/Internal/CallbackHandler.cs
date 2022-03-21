using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	public class CallbackHandler : PipelineHandler
	{
		public Action<IExecutionContext> OnPreInvoke
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

		public Action<IExecutionContext> OnPostInvoke
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

		public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
		{
			return null;
		}

		protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
		{
		}

		protected void PreInvoke(IExecutionContext executionContext)
		{
		}

		protected void PostInvoke(IExecutionContext executionContext)
		{
		}

		private void RaiseOnPreInvoke(IExecutionContext context)
		{
		}

		private void RaiseOnPostInvoke(IExecutionContext context)
		{
		}
	}
}
