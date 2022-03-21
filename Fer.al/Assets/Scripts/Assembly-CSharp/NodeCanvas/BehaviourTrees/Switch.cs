using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Category("Composites")]
	[Description("Executes one child based on the provided int or enum and return it's status. If set to Dynamic and 'case' change while a child is running, that child will be interrupted before the new child is executed.")]
	[Icon("IndexSwitcher", false, "")]
	[Color("b3ff7f")]
	public class Switch : BTComposite
	{
		public enum CaseSelectionMode
		{
			IndexBased,
			EnumBased
		}

		public enum OutOfRangeMode
		{
			ReturnFailure,
			LoopIndex
		}

		public bool dynamic;

		public CaseSelectionMode selectionMode;

		[ShowIf("selectionMode", 0)]
		public BBParameter<int> intCase;

		[ShowIf("selectionMode", 0)]
		public OutOfRangeMode outOfRangeMode;

		[BlackboardOnly]
		[ShowIf("selectionMode", 1)]
		public BBObjectParameter enumCase;

		private int current;

		private int runningIndex;

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}
	}
}
