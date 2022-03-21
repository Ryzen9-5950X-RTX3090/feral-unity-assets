using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Events;

namespace UniRx.Async
{
	public class AsyncUnityEventHandler : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IDisposable, IAsyncClickEventHandler
	{
		private static Action<object> cancellationCallback;

		private readonly UnityAction action;

		private readonly UnityEvent unityEvent;

		private Action continuation;

		private CancellationTokenRegistration registration;

		private bool isDisposed;

		private bool callOnce;

		private UniTask<bool>? suppressCancellationThrowTask;

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

		public AsyncUnityEventHandler(UnityEvent unityEvent, CancellationToken cancellationToken, bool callOnce)
		{
		}

		public UniTask OnInvokeAsync()
		{
			return default(UniTask);
		}

		public UniTask<bool> OnInvokeAsyncSuppressCancellationThrow()
		{
			return default(UniTask<bool>);
		}

		private void Invoke()
		{
		}

		private static void CancellationCallback(object state)
		{
		}

		public void Dispose()
		{
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

		UniTask IAsyncClickEventHandler.OnClickAsync()
		{
			return default(UniTask);
		}

		UniTask<bool> IAsyncClickEventHandler.OnClickAsyncSuppressCancellationThrow()
		{
			return default(UniTask<bool>);
		}
	}
}
