using System.Diagnostics;

namespace NatSuite.Recorders.Clocks
{
	public sealed class RealtimeClock : IClock
	{
		private readonly Stopwatch stopwatch;

		public long timestamp
		{
			get
			{
				return default(long);
			}
		}

		public bool paused
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
	}
}
