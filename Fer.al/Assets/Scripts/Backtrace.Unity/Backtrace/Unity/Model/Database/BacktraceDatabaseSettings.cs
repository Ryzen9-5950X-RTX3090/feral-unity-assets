using System.Runtime.CompilerServices;
using Backtrace.Unity.Types;

namespace Backtrace.Unity.Model.Database
{
	public class BacktraceDatabaseSettings
	{
		private readonly BacktraceConfiguration _configuration;

		public string DatabasePath
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

		public uint MaxRecordCount
		{
			get
			{
				return default(uint);
			}
		}

		public long MaxDatabaseSize
		{
			get
			{
				return default(long);
			}
		}

		public bool AutoSendMode
		{
			get
			{
				return default(bool);
			}
		}

		public uint RetryInterval
		{
			get
			{
				return default(uint);
			}
		}

		public uint RetryLimit
		{
			get
			{
				return default(uint);
			}
		}

		public DeduplicationStrategy DeduplicationStrategy
		{
			get
			{
				return default(DeduplicationStrategy);
			}
		}

		public bool GenerateScreenshotOnException
		{
			get
			{
				return default(bool);
			}
		}

		public bool AddUnityLogToReport
		{
			get
			{
				return default(bool);
			}
		}

		public RetryOrder RetryOrder
		{
			get
			{
				return default(RetryOrder);
			}
		}

		public MiniDumpType MinidumpType
		{
			get
			{
				return default(MiniDumpType);
			}
		}

		public BacktraceDatabaseSettings(string databasePath, BacktraceConfiguration configuration)
		{
		}
	}
}
