using System;
using System.Runtime.CompilerServices;

namespace UniRx.Async.Internal
{
	internal sealed class LazyPromise : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
	{
		private Func<UniTask> factory;

		private UniTask value;

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

		public LazyPromise(Func<UniTask> factory)
		{
		}

		private void Create()
		{
		}

		public void GetResult()
		{
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
