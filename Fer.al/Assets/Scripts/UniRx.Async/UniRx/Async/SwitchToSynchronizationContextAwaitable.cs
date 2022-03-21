using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace UniRx.Async
{
	public struct SwitchToSynchronizationContextAwaitable
	{
		public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private static readonly SendOrPostCallback switchToCallback;

			private readonly SynchronizationContext synchronizationContext;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public Awaiter(SynchronizationContext synchronizationContext)
			{
			}

			public void GetResult()
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}

			private static void Callback(object state)
			{
			}
		}

		private readonly SynchronizationContext synchronizationContext;

		public SwitchToSynchronizationContextAwaitable(SynchronizationContext synchronizationContext)
		{
		}

		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}
	}
}
