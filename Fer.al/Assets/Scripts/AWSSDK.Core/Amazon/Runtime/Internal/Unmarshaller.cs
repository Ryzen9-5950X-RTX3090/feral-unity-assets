using Amazon.Runtime.Internal.Transform;

namespace Amazon.Runtime.Internal
{
	public class Unmarshaller : PipelineHandler
	{
		private bool _supportsResponseLogging;

		public Unmarshaller(bool supportsResponseLogging)
		{
		}

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
		{
		}

		private void Unmarshall(IExecutionContext executionContext)
		{
		}

		private AmazonWebServiceResponse UnmarshallResponse(UnmarshallerContext context, IRequestContext requestContext)
		{
			return null;
		}

		private static bool ShouldLogResponseBody(bool supportsResponseLogging, IRequestContext requestContext)
		{
			return default(bool);
		}
	}
}
