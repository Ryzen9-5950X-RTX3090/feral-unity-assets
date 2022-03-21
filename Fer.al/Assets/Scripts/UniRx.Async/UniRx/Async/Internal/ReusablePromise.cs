using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace UniRx.Async.Internal
{
	public abstract class ReusablePromise : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
	{
		private ExceptionDispatchInfo exception;

		private object continuation;

		private AwaiterStatus status;

		public UniTask Task
		{
			get
			{
				return default(UniTask);
			}
		}

		public virtual bool IsCompleted
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

		public virtual void GetResult()
		{
		}

		void IAwaiter.GetResult()
		{
		}

		public void ResetStatus(bool forceReset)
		{
		}

		public virtual bool TrySetCanceled()
		{
			return default(bool);
		}

		public virtual bool TrySetException(Exception ex)
		{
			return default(bool);
		}

		public virtual bool TrySetResult()
		{
			return default(bool);
		}

		private void TryInvokeContinuation()
		{
		}

		public void OnCompleted(Action action)
		{
		}

		public void UnsafeOnCompleted(Action action)
		{
		}
	}
}
