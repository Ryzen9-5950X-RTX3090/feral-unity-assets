using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace CielaSpike
{
	public class Task : IEnumerator
	{
		private enum RunningState
		{
			Init,
			RunningAsync,
			PendingYield,
			ToBackground,
			RunningSync,
			CancellationRequested,
			Done,
			Error
		}

		private readonly IEnumerator _innerRoutine;

		private RunningState _state;

		private RunningState _previousState;

		private object _pendingCurrent;

		public object Current
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TaskState State
		{
			get
			{
				return default(TaskState);
			}
		}

		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool MoveNext()
		{
			return default(bool);
		}

		public void Reset()
		{
		}

		public Task(IEnumerator routine)
		{
		}

		public void Cancel()
		{
		}

		[IteratorStateMachine(typeof(<Wait>d__19))]
		public IEnumerator Wait()
		{
			return null;
		}

		private void GotoState(RunningState state)
		{
		}

		private void SetPendingCurrentObject(object current)
		{
		}

		private bool OnMoveNext()
		{
			return default(bool);
		}

		private void MoveNextAsync()
		{
		}

		private void BackgroundRunner(object state)
		{
		}

		private void MoveNextUnity()
		{
		}
	}
}
