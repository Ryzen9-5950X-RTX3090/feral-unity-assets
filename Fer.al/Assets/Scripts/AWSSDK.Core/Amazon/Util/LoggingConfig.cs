using System.Runtime.CompilerServices;
using Amazon.Runtime;

namespace Amazon.Util
{
	public class LoggingConfig
	{
		public static readonly int DefaultLogResponsesSizeLimit;

		private LoggingOptions _logTo;

		public LoggingOptions LogTo
		{
			get
			{
				return default(LoggingOptions);
			}
			set
			{
			}
		}

		public ResponseLoggingOption LogResponses
		{
			[CompilerGenerated]
			get
			{
				return default(ResponseLoggingOption);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int LogResponsesSizeLimit
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool LogMetrics
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public LogMetricsFormatOption LogMetricsFormat
		{
			[CompilerGenerated]
			get
			{
				return default(LogMetricsFormatOption);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IMetricsFormatter LogMetricsCustomFormatter
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

		internal LoggingConfig()
		{
		}

		internal void Configure(LoggingSection section)
		{
		}
	}
}
