using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Database;
using Backtrace.Unity.Services;

namespace Backtrace.Unity.Interfaces
{
	public interface IBacktraceDatabase
	{
		void SetApi(IBacktraceApi backtraceApi);

		void Delete(BacktraceDatabaseRecord record);

		void SetReportWatcher(ReportLimitWatcher reportLimitWatcher);

		void Reload();

		BacktraceDatabaseRecord Add(BacktraceData data, bool @lock = true);

		bool Enabled();
	}
}
