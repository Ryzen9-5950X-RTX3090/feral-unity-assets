using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class HttpErrorResponseExceptionHandler : ExceptionHandler<HttpErrorResponseException>
	{
		public HttpErrorResponseExceptionHandler(ILogger logger)
		{
		}

		public override bool HandleException(IExecutionContext executionContext, HttpErrorResponseException exception)
		{
			return default(bool);
		}

		private bool HandleSuppressed404(IExecutionContext executionContext, IWebResponseData httpErrorResponse)
		{
			return default(bool);
		}
	}
}
