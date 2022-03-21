using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.Timings
{
	public sealed class TimingCollector
	{
		public DateTime Start
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<TimingEvent> Events
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Add(string name)
		{
		}

		public void Add(string name, TimeSpan duration)
		{
		}

		public TimingEvent FindFirst(string name)
		{
			return default(TimingEvent);
		}

		public TimingEvent FindLast(string name)
		{
			return default(TimingEvent);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
