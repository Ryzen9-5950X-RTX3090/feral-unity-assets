using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UniRx.Async.Internal
{
	public static class TaskTracker
	{
		private static List<KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>> listPool;

		private static readonly WeakDictionary<IAwaiter, ValueTuple<int, DateTime, string>> tracking;

		private static bool dirty;

		[Conditional("UNITY_EDITOR")]
		public static void TrackActiveTask(IAwaiter task, int skipFrame = 1)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void TrackActiveTask(IAwaiter task, string stackTrace)
		{
		}

		public static string CaptureStackTrace(int skipFrame)
		{
			return null;
		}

		[Conditional("UNITY_EDITOR")]
		public static void RemoveTracking(IAwaiter task)
		{
		}

		public static bool CheckAndResetDirty()
		{
			return default(bool);
		}

		public static void ForEachActiveTask(Action<int, string, AwaiterStatus, DateTime, string> action)
		{
		}
	}
}
