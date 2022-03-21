using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Database;
using Backtrace.Unity.Types;

namespace Backtrace.Unity.Services
{
	internal class BacktraceDatabaseContext : IBacktraceDatabaseContext, IDisposable
	{
		public Dictionary<int, List<BacktraceDatabaseRecord>> BatchRetry;

		internal long TotalSize;

		internal int TotalRecords;

		private readonly string _path;

		private readonly int _retryNumber;

		private readonly BacktraceDatabaseAttachmentManager _attachmentManager;

		internal RetryOrder RetryOrder
		{
			[CompilerGenerated]
			get
			{
				return default(RetryOrder);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DeduplicationStrategy DeduplicationStrategy
		{
			[CompilerGenerated]
			get
			{
				return default(DeduplicationStrategy);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BacktraceDatabaseContext(BacktraceDatabaseSettings settings)
		{
		}

		private void SetupBatch()
		{
		}

		private string GetHash(BacktraceData backtraceData)
		{
			return null;
		}

		public BacktraceDatabaseRecord Add(BacktraceData backtraceData)
		{
			return null;
		}

		private BacktraceDatabaseRecord GetRecordByHash(string hash)
		{
			return null;
		}

		protected virtual BacktraceDatabaseRecord ConvertToRecord(BacktraceData backtraceData, string hash)
		{
			return null;
		}

		public BacktraceDatabaseRecord Add(BacktraceDatabaseRecord backtraceRecord)
		{
			return null;
		}

		public bool Any()
		{
			return default(bool);
		}

		public void Delete(BacktraceDatabaseRecord record)
		{
		}

		public void IncrementBatchRetry()
		{
		}

		public bool RemoveLastRecord()
		{
			return default(bool);
		}

		private void IncrementBatches()
		{
		}

		private void RemoveMaxRetries()
		{
		}

		public IEnumerable<BacktraceDatabaseRecord> Get()
		{
			return null;
		}

		public int Count()
		{
			return default(int);
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		public BacktraceDatabaseRecord LastOrDefault()
		{
			return null;
		}

		public BacktraceDatabaseRecord FirstOrDefault()
		{
			return null;
		}

		private BacktraceDatabaseRecord GetFirstRecord()
		{
			return null;
		}

		private BacktraceDatabaseRecord GetLastRecord()
		{
			return null;
		}

		public long GetSize()
		{
			return default(long);
		}
	}
}
