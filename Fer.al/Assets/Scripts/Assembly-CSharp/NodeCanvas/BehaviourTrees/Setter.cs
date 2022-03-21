using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("Override Agent", 0)]
	[Category("Decorators")]
	[Description("Set another Agent for the rest of the Tree dynamicaly from this point and on. All nodes under this will be executed for the new agent. You can also use this decorator to revert back to the original graph agent, which is useful to use after another OverrideAgent decorator for example.")]
	[Icon("Agent", false, "")]
	public class Setter : BTDecorator
	{
		public bool revertToOriginal;

		[ShowIf("revertToOriginal", 0)]
		public BBParameter<GameObject> newAgent;

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}
	}
}
