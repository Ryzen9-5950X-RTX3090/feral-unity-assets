using System;

namespace UniRx.Async.Internal
{
	internal sealed class PlayerLoopRunner
	{
		private const int InitialSize = 16;

		private readonly object runningAndQueueLock;

		private readonly object arrayLock;

		private readonly Action<Exception> unhandledExceptionCallback;

		private int tail;

		private bool running;

		private IPlayerLoopItem[] loopItems;

		private MinimumQueue<IPlayerLoopItem> waitQueue;

		public void AddAction(IPlayerLoopItem item)
		{
		}

		public void Run()
		{
		}
	}
}
