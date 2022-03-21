using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Amazon.Runtime.Internal.Util
{
	public class RequestMetrics : IRequestMetrics
	{
		private object metricsLock;

		private Stopwatch stopWatch;

		private Dictionary<Metric, Timing> inFlightTimings;

		private List<MetricError> errors;

		private long CurrentTime
		{
			get
			{
				return default(long);
			}
		}

		public Dictionary<Metric, List<object>> Properties
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Dictionary<Metric, List<IMetricsTiming>> Timings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Dictionary<Metric, long> Counters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsEnabled
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		private void LogError_Locked(Metric metric, string messageFormat, object[] args)
		{
		}

		private static void Log(StringBuilder builder, Metric metric, object metricValue)
		{
		}

		private static void Log(StringBuilder builder, Metric metric, List<object> metricValues)
		{
		}

		private static void LogHelper(StringBuilder builder, Metric metric, object[] metricValues)
		{
		}

		private static string ObjectToString(object data)
		{
			return null;
		}

		public TimingEvent StartEvent(Metric metric)
		{
			return null;
		}

		public Timing StopEvent(Metric metric)
		{
			return null;
		}

		public void AddProperty(Metric metric, object property)
		{
		}

		public void SetCounter(Metric metric, long value)
		{
		}

		public void IncrementCounter(Metric metric)
		{
		}

		public string GetErrors()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToJSON()
		{
			return null;
		}
	}
}
