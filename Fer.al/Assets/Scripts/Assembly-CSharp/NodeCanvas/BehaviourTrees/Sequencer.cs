using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("Sequencer", 10)]
	[Category("Composites")]
	[Description("Execute the child nodes in order or randomly and return Success if all children return Success, else return Failure\nIf is Dynamic, higher priority child status is revaluated. If a child returns Failure the Sequencer will bail out immediately in Failure too.")]
	[Icon("Sequencer", false, "")]
	[Color("bf7fff")]
	public class Sequencer : BTComposite
	{
		public bool dynamic;

		public bool random;

		private int lastRunningNodeIndex;

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected override void OnReset()
		{
		}

		public override void OnChildDisconnected(int index)
		{
		}

		public override void OnGraphStarted()
		{
		}
	}
}
