using System;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class RetryHandler : PipelineHandler
	{
		private ILogger _logger;

		public override ILogger Logger
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RetryPolicy RetryPolicy
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

		public RetryHandler(RetryPolicy retryPolicy)
		{
		}

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
		{
		}

		internal static void PrepareForRetry(IRequestContext requestContext)
		{
		}

		private void LogForRetry(IRequestContext requestContext, Exception exception)
		{
		}

		private void LogForError(IRequestContext requestContext, Exception exception)
		{
		}
	}
}
