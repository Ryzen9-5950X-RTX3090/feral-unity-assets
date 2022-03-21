using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace UniRx.Async.Internal
{
	public abstract class ReusablePromise<T> : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
	{
		private T result;

		private ExceptionDispatchInfo exception;

		private object continuation;

		private AwaiterStatus status;

		public UniTask<T> Task
		{
			get
			{
				return default(UniTask<T>);
			}
		}

		public virtual bool IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		protected T RawResult
		{
			get
			{
				return (T)null;
			}
		}

		public AwaiterStatus Status
		{
			get
			{
				return default(AwaiterStatus);
			}
		}

		protected void ForceSetResult(T result)
		{
		}

		public virtual T GetResult()
		{
			return (T)null;
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

		public virtual bool TrySetResult(T result)
		{
			return default(bool);
		}

		protected void TryInvokeContinuation()
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
