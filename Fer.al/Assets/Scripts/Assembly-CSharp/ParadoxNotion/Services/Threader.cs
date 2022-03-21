using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace ParadoxNotion.Services
{
	public static class Threader
	{
		public static bool applicationIsPlaying
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static bool isMainThread
		{
			get
			{
				return default(bool);
			}
		}

		static Threader()
		{
		}

		public static Thread StartAction(Thread thread, Action function, [Optional] Action callback)
		{
			return null;
		}

		public static Thread StartAction<T1>(Thread thread, Action<T1> function, T1 parameter1, [Optional] Action callback)
		{
			return null;
		}

		public static Thread StartAction<T1, T2>(Thread thread, Action<T1, T2> function, T1 parameter1, T2 parameter2, [Optional] Action callback)
		{
			return null;
		}

		public static Thread StartAction<T1, T2, T3>(Thread thread, Action<T1, T2, T3> function, T1 parameter1, T2 parameter2, T3 parameter3, [Optional] Action callback)
		{
			return null;
		}

		public static Thread StartFunction<TResult>(Thread thread, Func<TResult> function, [Optional] Action<TResult> callback)
		{
			return null;
		}

		public static Thread StartFunction<T1, TResult>(Thread thread, Func<T1, TResult> function, T1 parameter1, [Optional] Action<TResult> callback)
		{
			return null;
		}

		public static Thread StartFunction<T1, T2, TResult>(Thread thread, Func<T1, T2, TResult> function, T1 parameter1, T2 parameter2, [Optional] Action<TResult> callback)
		{
			return null;
		}

		public static Thread StartFunction<T1, T2, T3, TResult>(Thread thread, Func<T1, T2, T3, TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, [Optional] Action<TResult> callback)
		{
			return null;
		}

		private static void Begin(Thread thread, Action callback)
		{
		}

		[IteratorStateMachine(typeof(<ThreadMonitor>d__16))]
		private static IEnumerator ThreadMonitor(Thread thread, Action callback)
		{
			return null;
		}
	}
}
