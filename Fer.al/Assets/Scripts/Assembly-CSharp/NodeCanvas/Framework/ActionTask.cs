using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NodeCanvas.Framework
{
	public abstract class ActionTask : Task
	{
		private Status status;

		private float timeStarted;

		private bool latch;

		public float elapsedTime
		{
			get
			{
				return default(float);
			}
		}

		public bool isRunning
		{
			get
			{
				return default(bool);
			}
		}

		public bool isPaused
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void ExecuteIndependent(Component agent, IBlackboard blackboard, Action<Status> callback)
		{
		}

		[IteratorStateMachine(typeof(<IndependentActionUpdater>d__12))]
		private IEnumerator IndependentActionUpdater(Component agent, IBlackboard blackboard, Action<Status> callback)
		{
			return null;
		}

		[Obsolete]
		public Status ExecuteAction(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		public Status Execute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		public void EndAction()
		{
		}

		public void EndAction(bool success)
		{
		}

		public void EndAction(bool? success)
		{
		}

		public void Pause()
		{
		}

		protected virtual void OnExecute()
		{
		}

		protected virtual void OnUpdate()
		{
		}

		protected virtual void OnStop(bool interrupted)
		{
		}

		protected virtual void OnStop()
		{
		}

		protected virtual void OnPause()
		{
		}

		protected virtual void OnResume()
		{
		}
	}
}
