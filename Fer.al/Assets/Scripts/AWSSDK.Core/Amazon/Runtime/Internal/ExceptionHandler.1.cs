using System;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public abstract class ExceptionHandler<T> : IExceptionHandler<T>, IExceptionHandler where T : Exception
	{
		private ILogger _logger;

		protected ILogger Logger
		{
			get
			{
				return null;
			}
		}

		protected ExceptionHandler(ILogger logger)
		{
		}

		public bool Handle(IExecutionContext executionContext, Exception exception)
		{
			return default(bool);
		}

		public abstract bool HandleException(IExecutionContext executionContext, T exception);
	}
}
