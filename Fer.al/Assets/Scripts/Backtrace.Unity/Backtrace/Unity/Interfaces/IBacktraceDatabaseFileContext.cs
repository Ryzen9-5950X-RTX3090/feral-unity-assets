using System.Collections.Generic;
using System.IO;
using Backtrace.Unity.Model.Database;

namespace Backtrace.Unity.Interfaces
{
	internal interface IBacktraceDatabaseFileContext
	{
		IEnumerable<FileInfo> GetRecords();

		bool ValidFileConsistency();

		void RemoveOrphaned(IEnumerable<BacktraceDatabaseRecord> existingRecords);

		void Clear();
	}
}
