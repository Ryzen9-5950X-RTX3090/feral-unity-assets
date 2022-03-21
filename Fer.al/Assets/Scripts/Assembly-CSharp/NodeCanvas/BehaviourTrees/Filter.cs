using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("Filter", 0)]
	[Category("Decorators")]
	[Description("Filters the access of it's child node either a specific number of times, or every specific amount of time. By default the node is 'Treated as Inactive' to it's parent when child is Filtered. Unchecking this option will instead return Failure when Filtered.")]
	[Icon("Filter", false, "")]
	public class Filter : BTDecorator
	{
		public enum FilterMode
		{
			LimitNumberOfTimes,
			CoolDown
		}

		public enum Policy
		{
			SuccessOrFailure,
			SuccessOnly,
			FailureOnly
		}

		public FilterMode filterMode;

		[ShowIf("filterMode", 0)]
		[Name("Max Times", 0)]
		public BBParameter<int> maxCount;

		[ShowIf("filterMode", 0)]
		[Name("Increase Count When", 0)]
		public Policy policy;

		[ShowIf("filterMode", 1)]
		public BBParameter<float> coolDownTime;

		public bool inactiveWhenLimited;

		private int executedCount;

		private float currentTime;

		public override void OnGraphStoped()
		{
		}

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		[IteratorStateMachine(typeof(<Cooldown>d__11))]
		private IEnumerator Cooldown()
		{
			return null;
		}
	}
}
