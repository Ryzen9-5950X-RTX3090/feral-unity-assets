using System.Collections.Generic;
using System.IO;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model.Database;

namespace Backtrace.Unity.Services
{
	internal class BacktraceDatabaseFileContext : IBacktraceDatabaseFileContext
	{
		private string[] _possibleDatabaseExtension;

		private readonly long _maxDatabaseSize;

		private readonly uint _maxRecordNumber;

		private readonly DirectoryInfo _databaseDirectoryInfo;

		public BacktraceDatabaseFileContext(string databasePath, long maxDatabaseSize, uint maxRecordNumber)
		{
		}

		public IEnumerable<FileInfo> GetAll()
		{
			return null;
		}

		public IEnumerable<FileInfo> GetRecords()
		{
			return null;
		}

		public void RemoveOrphaned(IEnumerable<BacktraceDatabaseRecord> existingRecords)
		{
		}

		public bool ValidFileConsistency()
		{
			return default(bool);
		}

		public void Clear()
		{
		}
	}
}
