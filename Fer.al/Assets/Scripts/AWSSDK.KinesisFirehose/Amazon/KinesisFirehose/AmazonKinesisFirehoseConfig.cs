using Amazon.Runtime;

namespace Amazon.KinesisFirehose
{
	public class AmazonKinesisFirehoseConfig : ClientConfig
	{
		private static readonly string UserAgentString;

		private string _userAgent;

		public override string RegionEndpointServiceName
		{
			get
			{
				return null;
			}
		}

		public override string ServiceVersion
		{
			get
			{
				return null;
			}
		}

		public override string UserAgent
		{
			get
			{
				return null;
			}
		}
	}
}
