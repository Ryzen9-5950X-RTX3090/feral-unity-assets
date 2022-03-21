using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Util
{
	public class MetricError
	{
		public Metric Metric
		{
			[CompilerGenerated]
			get
			{
				return default(Metric);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Message
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

		public Exception Exception
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

		public DateTime Time
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

		public MetricError(Metric metric, string messageFormat, object[] args)
		{
		}

		public MetricError(Metric metric, Exception exception, string messageFormat, object[] args)
		{
		}
	}
}
