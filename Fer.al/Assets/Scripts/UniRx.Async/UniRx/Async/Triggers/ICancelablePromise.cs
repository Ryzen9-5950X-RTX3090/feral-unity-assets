using System.Threading;

namespace UniRx.Async.Triggers
{
	public interface ICancelablePromise
	{
		CancellationToken RegisteredCancellationToken { get; }

		bool TrySetCanceled();
	}
}
