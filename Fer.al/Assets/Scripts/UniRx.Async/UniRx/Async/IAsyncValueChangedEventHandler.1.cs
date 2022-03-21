using System;

namespace UniRx.Async
{
	public interface IAsyncValueChangedEventHandler<T> : IDisposable
	{
		UniTask<T> OnValueChangedAsync();

		UniTask<ValueTuple<bool, T>> OnValueChangedAsyncSuppressCancellationThrow();
	}
}
