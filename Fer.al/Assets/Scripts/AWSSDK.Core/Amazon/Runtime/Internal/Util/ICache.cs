using System;

namespace Amazon.Runtime.Internal.Util
{
	public interface ICache
	{
		TimeSpan MaximumItemLifespan { get; set; }

		TimeSpan CacheClearPeriod { get; set; }

		int ItemCount { get; }

		void Clear();
	}
}
