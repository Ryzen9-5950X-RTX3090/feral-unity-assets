using System;

namespace UniRx.Async
{
	public interface IAsyncEndEditEventHandler<T> : IDisposable
	{
		UniTask<T> OnEndEditAsync();

		UniTask<ValueTuple<bool, T>> OnEndEditAsyncSuppressCancellationThrow();
	}
}
