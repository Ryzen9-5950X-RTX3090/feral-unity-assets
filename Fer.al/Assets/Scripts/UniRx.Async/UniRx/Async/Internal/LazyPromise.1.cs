using System;
using System.Runtime.CompilerServices;

namespace UniRx.Async.Internal
{
	internal sealed class LazyPromise<T> : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
	{
		private Func<UniTask<T>> factory;

		private UniTask<T> value;

		public bool IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		public AwaiterStatus Status
		{
			get
			{
				return default(AwaiterStatus);
			}
		}

		public LazyPromise(Func<UniTask<T>> factory)
		{
		}

		private void Create()
		{
		}

		public T GetResult()
		{
			return (T)null;
		}

		void IAwaiter.GetResult()
		{
		}

		public void UnsafeOnCompleted(Action continuation)
		{
		}

		public void OnCompleted(Action continuation)
		{
		}
	}
}
