using System;

namespace WW.Waiters
{
	public class FrameWaiter : Waiter
	{
		private int _framesToWait;

		private int _remainingFrames;

		public FrameWaiter(int inFramesToWait, Action inOnCompleteAction)
		{
		}

		protected override void RestartForLoop()
		{
		}

		protected override bool CheckForCompletion(float inDeltaTime)
		{
			return default(bool);
		}
	}
}
