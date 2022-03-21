using System;

namespace Amazon.Runtime
{
	public interface IExceptionHandler<T> : IExceptionHandler where T : Exception
	{
		bool HandleException(IExecutionContext executionContext, T exception);
	}
}
