using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async
{
	public static class UniTaskScheduler
	{
		public static bool PropagateOperationCanceledException;

		public static LogType UnobservedExceptionWriteLogType;

		public static bool DispatchUnityMainThread;

		private static readonly SendOrPostCallback handleExceptionInvoke;

		public static event Action<Exception> UnobservedTaskException
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal static void PublishUnobservedTaskException(Exception ex)
		{
		}

		private static void InvokeUnobservedTaskException(object state)
		{
		}
	}
}
