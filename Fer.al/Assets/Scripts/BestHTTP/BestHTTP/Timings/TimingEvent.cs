using System;

namespace BestHTTP.Timings
{
	public struct TimingEvent : IEquatable<TimingEvent>
	{
		public static readonly TimingEvent Empty;

		public readonly string Name;

		public readonly TimeSpan Duration;

		public readonly DateTime When;

		public TimingEvent(string name, TimeSpan duration)
		{
		}

		public TimeSpan CalculateDuration(TimingEvent @event)
		{
			return default(TimeSpan);
		}

		public bool Equals(TimingEvent other)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static bool operator ==(TimingEvent lhs, TimingEvent rhs)
		{
			return default(bool);
		}

		public static bool operator !=(TimingEvent lhs, TimingEvent rhs)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
