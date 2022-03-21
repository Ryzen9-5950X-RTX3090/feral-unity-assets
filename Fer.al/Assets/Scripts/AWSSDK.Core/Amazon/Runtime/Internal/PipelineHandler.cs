using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public abstract class PipelineHandler : IPipelineHandler
	{
		public virtual ILogger Logger
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

		public IPipelineHandler InnerHandler
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

		public IPipelineHandler OuterHandler
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

		public virtual void InvokeSync(IExecutionContext executionContext)
		{
		}

		[DebuggerHidden]
		public virtual IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
		{
			return null;
		}

		[DebuggerHidden]
		public void AsyncCallback(IAsyncExecutionContext executionContext)
		{
		}

		[DebuggerHidden]
		protected virtual void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
		{
		}

		protected void LogMetrics(IExecutionContext executionContext)
		{
		}
	}
}
