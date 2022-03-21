using System;
using System.Collections.Generic;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Database;
using Backtrace.Unity.Types;

namespace Backtrace.Unity.Interfaces
{
	public interface IBacktraceDatabaseContext : IDisposable
	{
		DeduplicationStrategy DeduplicationStrategy { get; set; }

		BacktraceDatabaseRecord Add(BacktraceData backtraceData);

		BacktraceDatabaseRecord Add(BacktraceDatabaseRecord backtraceDatabaseRecord);

		BacktraceDatabaseRecord FirstOrDefault();

		IEnumerable<BacktraceDatabaseRecord> Get();

		void Delete(BacktraceDatabaseRecord record);

		bool Any();

		int Count();

		void Clear();

		void IncrementBatchRetry();

		long GetSize();

		bool RemoveLastRecord();
	}
}
