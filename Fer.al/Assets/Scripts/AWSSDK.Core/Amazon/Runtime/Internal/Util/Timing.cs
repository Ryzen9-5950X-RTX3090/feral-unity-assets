using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Util
{
	public class Timing : IMetricsTiming
	{
		private long startTime;

		private long endTime;

		public bool IsFinished
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

		public long ElapsedTicks
		{
			get
			{
				return default(long);
			}
		}

		public TimeSpan ElapsedTime
		{
			get
			{
				return default(TimeSpan);
			}
		}

		public Timing()
		{
		}

		public Timing(long currentTime)
		{
		}

		public void Stop(long currentTime)
		{
		}
	}
}
