using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Events;

namespace UniRx.Async
{
	public class AsyncUnityEventHandler<T> : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IDisposable, IAsyncValueChangedEventHandler<T>, IAsyncEndEditEventHandler<T>
	{
		private static Action<object> cancellationCallback;

		private readonly UnityAction<T> action;

		private readonly UnityEvent<T> unityEvent;

		private Action continuation;

		private CancellationTokenRegistration registration;

		private bool isDisposed;

		private T eventValue;

		private bool callOnce;

		private UniTask<ValueTuple<bool, T>>? suppressCancellationThrowTask;

		bool IAwaiter.IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		AwaiterStatus IAwaiter.Status
		{
			get
			{
				return default(AwaiterStatus);
			}
		}

		public AsyncUnityEventHandler(UnityEvent<T> unityEvent, CancellationToken cancellationToken, bool callOnce)
		{
		}

		public UniTask<T> OnInvokeAsync()
		{
			return default(UniTask<T>);
		}

		public UniTask<ValueTuple<bool, T>> OnInvokeAsyncSuppressCancellationThrow()
		{
			return default(UniTask<ValueTuple<bool, T>>);
		}

		private void Invoke(T value)
		{
		}

		private static void CancellationCallback(object state)
		{
		}

		public void Dispose()
		{
		}

		T IAwaiter<T>.GetResult()
		{
			return (T)null;
		}

		void IAwaiter.GetResult()
		{
		}

		void INotifyCompletion.OnCompleted(Action action)
		{
		}

		void ICriticalNotifyCompletion.UnsafeOnCompleted(Action action)
		{
		}

		UniTask<T> IAsyncValueChangedEventHandler<T>.OnValueChangedAsync()
		{
			return default(UniTask<T>);
		}

		UniTask<ValueTuple<bool, T>> IAsyncValueChangedEventHandler<T>.OnValueChangedAsyncSuppressCancellationThrow()
		{
			return default(UniTask<ValueTuple<bool, T>>);
		}

		UniTask<T> IAsyncEndEditEventHandler<T>.OnEndEditAsync()
		{
			return default(UniTask<T>);
		}

		UniTask<ValueTuple<bool, T>> IAsyncEndEditEventHandler<T>.OnEndEditAsyncSuppressCancellationThrow()
		{
			return default(UniTask<ValueTuple<bool, T>>);
		}
	}
}
