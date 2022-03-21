using System;
using System.Threading;

namespace UniRx.Async.Internal
{
	internal class ContinuationQueue
	{
		private const int MaxArrayLength = 2146435071;

		private const int InitialSize = 16;

		private SpinLock gate;

		private bool dequing;

		private int actionListCount;

		private Action[] actionList;

		private int waitingListCount;

		private Action[] waitingList;

		public void Enqueue(Action continuation)
		{
		}

		public void Run()
		{
		}
	}
}
