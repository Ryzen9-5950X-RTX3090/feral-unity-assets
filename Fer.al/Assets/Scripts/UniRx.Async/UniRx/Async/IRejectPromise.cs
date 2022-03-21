using System;

namespace UniRx.Async
{
	public interface IRejectPromise
	{
		bool TrySetException(Exception exception);
	}
}
