using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Internal
{
	public class AmazonKinesisFirehoseMetadata : IServiceMetadata
	{
		public string ServiceId
		{
			get
			{
				return null;
			}
		}

		public IDictionary<string, string> OperationNameMapping
		{
			get
			{
				return null;
			}
		}
	}
}
