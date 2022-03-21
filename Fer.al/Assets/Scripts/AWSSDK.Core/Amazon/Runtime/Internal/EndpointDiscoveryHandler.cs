using System;
using System.Collections.Generic;

namespace Amazon.Runtime.Internal
{
	public class EndpointDiscoveryHandler : PipelineHandler
	{
		private const int INVALID_ENDPOINT_EXCEPTION_STATUSCODE = 421;

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
		{
		}

		protected static void PreInvoke(IExecutionContext executionContext)
		{
		}

		public static void EvictCacheKeyForRequest(IRequestContext requestContext, Uri regionalEndpoint)
		{
		}

		public static void DiscoverEndpoints(IRequestContext requestContext, bool evictCacheKey)
		{
		}

		private static IEnumerable<DiscoveryEndpointBase> ProcessEndpointDiscovery(IRequestContext requestContext, bool evictCacheKey, Uri evictUri)
		{
			return null;
		}

		private static string OperationNameFromRequestName(string requestName)
		{
			return null;
		}

		private static bool IsInvalidEndpointException(Exception exception)
		{
			return default(bool);
		}
	}
}
