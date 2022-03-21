using System;

namespace UniRx.Async.Internal
{
	internal class DisposedObserver<T> : IObserver<T>
	{
		public static readonly DisposedObserver<T> Instance;

		private DisposedObserver()
		{
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
	}
}
