using System.Runtime.CompilerServices;

namespace NatSuite.Recorders.Clocks
{
	public sealed class FixedIntervalClock : IClock
	{
		private readonly bool autoTick;

		private int ticks;

		public double interval
		{
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public long timestamp
		{
			get
			{
				return default(long);
			}
		}

		public FixedIntervalClock(int framerate, bool autoTick = true)
		{
		}

		public FixedIntervalClock(double interval, bool autoTick = true)
		{
		}

		public void Tick()
		{
		}
	}
}
