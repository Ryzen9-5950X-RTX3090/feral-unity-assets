using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("Condition", 0)]
	[Description("Check a condition and return Success or Failure")]
	[Icon("Condition", false, "")]
	public class ConditionNode : BTNode, ITaskAssignable<ConditionTask>, ITaskAssignable, IGraphElement
	{
		[SerializeField]
		private ConditionTask _condition;

		public Task task
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ConditionTask condition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string name
		{
			get
			{
				return null;
			}
		}

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected override void OnReset()
		{
		}
	}
}
