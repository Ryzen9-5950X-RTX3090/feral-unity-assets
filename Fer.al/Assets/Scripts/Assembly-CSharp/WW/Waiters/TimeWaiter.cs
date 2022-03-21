using System;

namespace WW.Waiters
{
	public class TimeWaiter : Waiter
	{
		private float _timeToWait;

		private float _remainingTime;

		public TimeWaiter(float inTimeToWait, Action inOnCompleteAction)
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
