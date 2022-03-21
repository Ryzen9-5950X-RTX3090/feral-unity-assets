using System;

namespace UniRx.Async
{
	public interface IAsyncClickEventHandler : IDisposable
	{
		UniTask OnClickAsync();

		UniTask<bool> OnClickAsyncSuppressCancellationThrow();
	}
}
