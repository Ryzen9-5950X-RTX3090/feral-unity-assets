using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UniRx.Async
{
	public class UniTaskCompletionSource : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPromise, IResolvePromise, IRejectPromise, ICancelPromise
	{
		private const int Pending = 0;

		private const int Succeeded = 1;

		private const int Faulted = 2;

		private const int Canceled = 3;

		private int state;

		private bool handled;

		private ExceptionHolder exception;

		private object continuation;

		AwaiterStatus IAwaiter.Status
		{
			get
			{
				return default(AwaiterStatus);
			}
		}

		bool IAwaiter.IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		public UniTask Task
		{
			get
			{
				return default(UniTask);
			}
		}

		[Conditional("UNITY_EDITOR")]
		internal void MarkHandled()
		{
		}

		void IAwaiter.GetResult()
		{
		}

		void ICriticalNotifyCompletion.UnsafeOnCompleted(Action action)
		{
		}

		private void TryInvokeContinuation()
		{
		}

		public bool TrySetResult()
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

		void INotifyCompletion.OnCompleted(Action continuation)
		{
		}
	}
}
