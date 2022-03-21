using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public class RetryableDetails
	{
		public bool Throttling
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RetryableDetails(bool throttling)
		{
		}
	}
}
