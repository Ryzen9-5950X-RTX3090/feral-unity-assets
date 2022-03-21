using System.Collections.Generic;

namespace Backtrace.Unity.Services
{
	public class ReportLimitWatcher
	{
		internal readonly Queue<long> _reportQueue;

		internal readonly object _object;

		private readonly long _queueReportTime;

		private bool _watcherEnable;

		private int _reportPerMin;

		private bool _displayMessage;

		private bool _limitHit;

		internal ReportLimitWatcher(uint reportPerMin)
		{
		}

		internal void SetClientReportLimit(uint reportPerMin)
		{
		}

		public bool WatchReport(long timestamp, bool displayMessageOnLimitHit = true)
		{
			return default(bool);
		}

		internal bool ShouldDisplayMessage()
		{
			return default(bool);
		}

		private void DisplayReportLimitHitMessage()
		{
		}

		private void Clear()
		{
		}
	}
}
