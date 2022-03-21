using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UniRx.Async
{
	public class UniTaskCompletionSource<T> : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPromise<T>, IResolvePromise<T>, IRejectPromise, ICancelPromise
	{
		private const int Pending = 0;

		private const int Succeeded = 1;

		private const int Faulted = 2;

		private const int Canceled = 3;

		private int state;

		private T value;

		private bool handled;

		private ExceptionHolder exception;

		private object continuation;

		bool IAwaiter.IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		public UniTask<T> Task
		{
			get
			{
				return default(UniTask<T>);
			}
		}

		public UniTask UnitTask
		{
			get
			{
				return default(UniTask);
			}
		}

		AwaiterStatus IAwaiter.Status
		{
			get
			{
				return default(AwaiterStatus);
			}
		}

		[Conditional("UNITY_EDITOR")]
		internal void MarkHandled()
		{
		}

		T IAwaiter<T>.GetResult()
		{
			return (T)null;
		}

		void ICriticalNotifyCompletion.UnsafeOnCompleted(Action action)
		{
		}

		private void TryInvokeContinuation()
		{
		}

		public bool TrySetResult(T value)
		{
			return default(bool);
		}

		public bool TrySetException(Exception exception)
		{
			return default(bool);
		}

		public bool TrySetCanceled()
		{
			return default(bool);
		}

		public bool TrySetCanceled(OperationCanceledException exception)
		{
			return default(bool);
		}

		void IAwaiter.GetResult()
		{
		}

		void INotifyCompletion.OnCompleted(Action continuation)
		{
		}
	}
}
