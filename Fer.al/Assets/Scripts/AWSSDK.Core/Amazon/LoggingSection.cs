using System;
using System.Runtime.CompilerServices;

namespace Amazon
{
	internal class LoggingSection
	{
		public const string logToKey = "logTo";

		public const string logResponsesKey = "logResponses";

		public const string logMetricsKey = "logMetrics";

		public const string logMetricsFormatKey = "logMetricsFormat";

		public const string logMetricsCustomFormatterKey = "logMetricsCustomFormatter";

		public const string logResponsesSizeLimitKey = "logResponsesSizeLimit";

		public LoggingOptions LogTo
		{
			[CompilerGenerated]
			get
			{
				return default(LoggingOptions);
			}
			[CompilerGenerated]
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

		public int? LogResponsesSizeLimit
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

		public bool? LogMetrics
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

		public Type LogMetricsCustomFormatter
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
	}
}
