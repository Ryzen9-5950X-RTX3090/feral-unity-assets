using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Util
{
	public class ThreadPoolThrottler<T>
	{
		public class ThreadPoolOptions<Q>
		{
			public Action<Q> Callback
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Action<Exception, Q> ErrorCallback
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Q State
			{
				[CompilerGenerated]
				get
				{
					return (Q)null;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private static object _queueLock;

		private int _requestCount;

		private Queue<ThreadPoolOptions<T>> _queuedRequests;

		public int MaxConcurentRequest
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int RequestCount
		{
			get
			{
				return default(int);
			}
		}

		public ThreadPoolThrottler(int maxConcurrentRequests)
		{
		}

		public void Enqueue(T executionContext, Action<T> callback, Action<Exception, T> errorCallback)
		{
		}

		private void Callback(object state)
		{
		}

		private void SignalCompletion()
		{
		}
	}
}
