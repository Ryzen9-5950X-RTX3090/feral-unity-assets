using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Auth
{
	public class QueryStringSigner : AbstractAWSSigner
	{
		private const string SignatureVersion2 = "2";

		public override ClientProtocol Protocol
		{
			get
			{
				return default(ClientProtocol);
			}
		}

		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}
	}
}
