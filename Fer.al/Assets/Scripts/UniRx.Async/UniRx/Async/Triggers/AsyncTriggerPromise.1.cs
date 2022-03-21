using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async.Internal;

namespace UniRx.Async.Triggers
{
	public class AsyncTriggerPromise<T> : ReusablePromise<T>, IPromise<T>, IResolvePromise<T>, IRejectPromise, ICancelPromise, ICancelablePromise
	{
		public CancellationToken RegisteredCancellationToken
		{
			[CompilerGenerated]
			get
			{
				return default(CancellationToken);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AsyncTriggerPromise()
		{
		}

		public AsyncTriggerPromise(CancellationToken cancellationToken)
		{
		}

		public override T GetResult()
		{
			return (T)null;
		}

		public override bool TrySetResult(T result)
		{
			return default(bool);
		}

		public override bool TrySetCanceled()
		{
			return default(bool);
		}
	}
}
