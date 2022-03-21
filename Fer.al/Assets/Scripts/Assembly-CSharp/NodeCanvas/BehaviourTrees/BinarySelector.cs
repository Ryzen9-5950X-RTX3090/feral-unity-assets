using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Category("Composites")]
	[Description("Quick way to execute the left, or the right child node based on a Condition Task evaluation.")]
	[Icon("Condition", false, "")]
	[Color("b3ff7f")]
	public class BinarySelector : BTNode, ITaskAssignable<ConditionTask>, ITaskAssignable, IGraphElement
	{
		public bool dynamic;

		[SerializeField]
		private ConditionTask _condition;

		private int succeedIndex;

		public override int maxOutConnections
		{
			get
			{
				return default(int);
			}
		}

		public override Alignment2x2 commentsAlignment
		{
			get
			{
				return default(Alignment2x2);
			}
		}

		public override string name
		{
			get
			{
				return null;
			}
		}

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

		private ConditionTask condition
		{
			get
			{
				return null;
			}
			set
			{
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
