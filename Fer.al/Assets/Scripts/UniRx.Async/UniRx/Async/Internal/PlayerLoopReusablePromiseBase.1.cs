using System.Threading;

namespace UniRx.Async.Internal
{
	public abstract class PlayerLoopReusablePromiseBase<T> : ReusablePromise<T>, IPlayerLoopItem
	{
		private readonly PlayerLoopTiming timing;

		protected readonly CancellationToken cancellationToken;

		private bool isRunning;

		public override bool IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		public PlayerLoopReusablePromiseBase(PlayerLoopTiming timing, CancellationToken cancellationToken, int skipTrackFrameCountAdditive)
		{
		}

		protected abstract void OnRunningStart();

		protected void Complete()
		{
		}

		public abstract bool MoveNext();
	}
}
