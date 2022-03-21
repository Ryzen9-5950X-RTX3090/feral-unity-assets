using System;
using Backtrace.Unity.Types;

namespace Backtrace.Unity.Model
{
	[Serializable]
	public class BacktraceDatabaseConfiguration : BacktraceClientConfiguration
	{
		public bool Enabled;

		public string DatabasePath;

		public bool AutoSendMode;

		public bool CreateDatabase;

		public bool GenerateScreenshotOnException;

		public DeduplicationStrategy DeduplicationStrategy;

		public int MaxRecordCount;

		public long MaxDatabaseSize;

		public int RetryInterval;

		public int RetryLimit;

		public RetryOrder RetryOrder;

		public bool ValidDatabasePath()
		{
			return default(bool);
		}
	}
}
