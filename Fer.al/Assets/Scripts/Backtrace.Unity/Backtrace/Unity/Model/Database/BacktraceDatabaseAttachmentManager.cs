using System.Collections.Generic;

namespace Backtrace.Unity.Model.Database
{
	internal class BacktraceDatabaseAttachmentManager
	{
		private readonly BacktraceDatabaseSettings _settings;

		private float _lastScreenTime;

		private string _lastScreenPath;

		private readonly object _lock;

		public BacktraceDatabaseAttachmentManager(BacktraceDatabaseSettings settings)
		{
		}

		public IEnumerable<string> GetReportAttachments(BacktraceData data)
		{
			return null;
		}

		private void AddIfPathIsNotEmpty(List<string> source, string attachmentPath)
		{
		}

		private string GetMinidumpPath(BacktraceData backtraceData, string dataPrefix)
		{
			return null;
		}

		private string GetScreenshotPath(string dataPrefix)
		{
			return null;
		}

		private string GetUnityPlayerLogFile(BacktraceData backtraceData, string dataPrefix)
		{
			return null;
		}
	}
}
