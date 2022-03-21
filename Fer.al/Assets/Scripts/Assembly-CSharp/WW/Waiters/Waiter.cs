using System;

namespace WW.Waiters
{
	public class Waiter
	{
		protected Action _action;

		protected Func<bool> _completionCheck;

		private RoutineState _routineState;

		private UpdateType _updateType;

		private int _remainingLoops;

		private object _id;

		public RoutineState state
		{
			get
			{
				return default(RoutineState);
			}
		}

		public UpdateType updateType
		{
			get
			{
				return default(UpdateType);
			}
		}

		public bool IsRunning
		{
			get
			{
				return default(bool);
			}
		}

		public object ID
		{
			get
			{
				return null;
			}
		}

		public Waiter()
		{
		}

		public Waiter(Func<bool> inCompletionCheck, Action inOnCompleteAction)
		{
		}

		protected void Init()
		{
		}

		public Waiter SetLoops(int inLoopCount)
		{
			return null;
		}

		public Waiter SetUpdateType(UpdateType inUpdateType)
		{
			return null;
		}

		public Waiter SetID(object inID)
		{
			return null;
		}

		public void Cancel()
		{
		}

		public void Update(float inDeltaTime)
		{
		}

		protected virtual void RestartForLoop()
		{
		}

		protected virtual bool CheckForCompletion(float inDeltaTime)
		{
			return default(bool);
		}
	}
}
