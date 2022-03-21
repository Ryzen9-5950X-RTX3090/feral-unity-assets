using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("Repeat", 0)]
	[Category("Decorators")]
	[Description("Repeat the child either x times or until it returns the specified status, or forever")]
	[Icon("Repeat", false, "")]
	public class Repeater : BTDecorator
	{
		public enum RepeaterMode
		{
			RepeatTimes,
			RepeatUntil,
			RepeatForever
		}

		public enum RepeatUntilStatus
		{
			Failure,
			Success
		}

		public RepeaterMode repeaterMode;

		[ShowIf("repeaterMode", 0)]
		public BBParameter<int> repeatTimes;

		[ShowIf("repeaterMode", 1)]
		public RepeatUntilStatus repeatUntilStatus;

		private int currentIteration;

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected override void OnReset()
		{
		}
	}
}
