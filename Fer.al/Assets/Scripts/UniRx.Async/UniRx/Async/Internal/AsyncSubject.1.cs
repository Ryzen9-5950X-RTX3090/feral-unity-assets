using System;

namespace UniRx.Async.Internal
{
	internal sealed class AsyncSubject<T> : IObservable<T>, IObserver<T>
	{
		private class Subscription : IDisposable
		{
			private readonly object gate;

			private AsyncSubject<T> parent;

			private IObserver<T> unsubscribeTarget;

			public Subscription(AsyncSubject<T> parent, IObserver<T> unsubscribeTarget)
			{
			}

			public void Dispose()
			{
			}
		}

		private object observerLock;

		private T lastValue;

		private bool hasValue;

		private bool isStopped;

		private bool isDisposed;

		private Exception lastError;

		private IObserver<T> outObserver;

		public T Value
		{
			get
			{
				return (T)null;
			}
		}

		public bool HasObservers
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(T value)
		{
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			return null;
		}

		public void Dispose()
		{
		}

		private void ThrowIfDisposed()
		{
		}
	}
}
