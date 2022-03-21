using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class ErrorHandler : PipelineHandler
	{
		private IDictionary<Type, IExceptionHandler> _exceptionHandlers;

		public IDictionary<Type, IExceptionHandler> ExceptionHandlers
		{
			get
			{
				return null;
			}
		}

		public ErrorHandler(ILogger logger)
		{
		}

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
		{
		}

		private static void DisposeReponse(IResponseContext responseContext)
		{
		}

		private bool ProcessException(IExecutionContext executionContext, Exception exception)
		{
			return default(bool);
		}
	}
}
