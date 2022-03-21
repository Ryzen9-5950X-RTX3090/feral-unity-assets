using System.Collections.Concurrent;

namespace Backtrace.Unity.Model
{
	internal class BacktraceLogManager
	{
		internal readonly ConcurrentQueue<string> LogQueue;

		private readonly object lockObject;

		private readonly uint _limit;

		public bool Disabled
		{
			get
			{
				return default(bool);
			}
		}

		public BacktraceLogManager(uint numberOfLogs)
		{
		}

		public bool Enqueue(BacktraceReport report)
		{
			return default(bool);
		}

		public bool Enqueue(BacktraceUnityMessage unityMessage)
		{
			return default(bool);
		}

		public string ToSourceCode()
		{
			return null;
		}
	}
}
