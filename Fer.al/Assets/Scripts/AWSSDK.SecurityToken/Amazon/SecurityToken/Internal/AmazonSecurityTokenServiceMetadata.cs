using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Internal
{
	public class AmazonSecurityTokenServiceMetadata : IServiceMetadata
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
