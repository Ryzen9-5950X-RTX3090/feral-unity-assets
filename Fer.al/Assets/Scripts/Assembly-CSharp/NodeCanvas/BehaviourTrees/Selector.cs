using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("Selector", 9)]
	[Category("Composites")]
	[Description("Execute the child nodes in order or randomly until the first that returns Success and return Success as well. If none returns Success, then returns Failure.\nIf is Dynamic, then higher priority children Status are revaluated and if one returns Success the Selector will select that one and bail out immediately in Success too")]
	[Icon("Selector", false, "")]
	[Color("b3ff7f")]
	public class Selector : BTComposite
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
