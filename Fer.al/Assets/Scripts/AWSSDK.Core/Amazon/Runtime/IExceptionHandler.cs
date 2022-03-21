using System;

namespace Amazon.Runtime
{
	public interface IExceptionHandler
	{
		bool Handle(IExecutionContext executionContext, Exception exception);
	}
}
