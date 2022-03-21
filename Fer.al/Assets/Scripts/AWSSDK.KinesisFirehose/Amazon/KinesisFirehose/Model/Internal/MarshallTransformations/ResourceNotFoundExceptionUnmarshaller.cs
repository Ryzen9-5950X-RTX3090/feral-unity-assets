using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
	public class ResourceNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>
	{
		private static ResourceNotFoundExceptionUnmarshaller _instance;

		public static ResourceNotFoundExceptionUnmarshaller Instance
		{
			get
			{
				return null;
			}
		}

		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
