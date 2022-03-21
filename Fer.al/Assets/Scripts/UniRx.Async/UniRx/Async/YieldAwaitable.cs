using System;
using System.Runtime.CompilerServices;

namespace UniRx.Async
{
	public struct YieldAwaitable
	{
		public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly PlayerLoopTiming timing;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public Awaiter(PlayerLoopTiming timing)
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
		}

		private readonly PlayerLoopTiming timing;

		public YieldAwaitable(PlayerLoopTiming timing)
		{
		}

		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}

		public UniTask ToUniTask()
		{
			return default(UniTask);
		}
	}
}
