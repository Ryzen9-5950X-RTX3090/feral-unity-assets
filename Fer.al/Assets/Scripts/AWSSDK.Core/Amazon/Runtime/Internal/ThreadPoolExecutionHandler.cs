using System;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class ThreadPoolExecutionHandler : PipelineHandler
	{
		private static ThreadPoolThrottler<IAsyncExecutionContext> _throttler;

		private static object _lock;

		public ThreadPoolExecutionHandler(int concurrentRequests)
		{
		}

		public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
		{
			return null;
		}

		private void InvokeAsyncHelper(IAsyncExecutionContext executionContext)
		{
		}

		private void ErrorCallback(Exception exception, IAsyncExecutionContext executionContext)
		{
		}
	}
}
