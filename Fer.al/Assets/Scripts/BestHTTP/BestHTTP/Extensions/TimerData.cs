using System;
using System.Runtime.CompilerServices;

namespace BestHTTP.Extensions
{
	[IsReadOnly]
	public struct TimerData
	{
		public readonly DateTime Created;

		public readonly TimeSpan Interval;

		public readonly object Context;

		public readonly Func<DateTime, object, bool> OnTimer;

		public bool IsOnTime(DateTime now)
		{
			return default(bool);
		}

		public TimerData(TimeSpan interval, object context, Func<DateTime, object, bool> onTimer)
		{
		}

		public TimerData CreateNew()
		{
			return default(TimerData);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
