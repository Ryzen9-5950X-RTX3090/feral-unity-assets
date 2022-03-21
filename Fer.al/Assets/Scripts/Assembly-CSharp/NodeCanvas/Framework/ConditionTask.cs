using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NodeCanvas.Framework
{
	public abstract class ConditionTask : Task
	{
		[SerializeField]
		private bool _invert;

		private int yieldReturn;

		private int yields;

		private bool isRuntimeEnabled;

		public bool invert
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void Enable(Component agent, IBlackboard bb)
		{
		}

		public void Disable()
		{
		}

		[Obsolete]
		public bool CheckCondition(Component agent, IBlackboard blackboard)
		{
			return default(bool);
		}

		public bool Check(Component agent, IBlackboard blackboard)
		{
			return default(bool);
		}

		public bool CheckOnce(Component agent, IBlackboard blackboard)
		{
			return default(bool);
		}

		protected void YieldReturn(bool value)
		{
		}

		[IteratorStateMachine(typeof(<Flip>d__13))]
		private IEnumerator Flip()
		{
			return null;
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual bool OnCheck()
		{
			return default(bool);
		}
	}
}
