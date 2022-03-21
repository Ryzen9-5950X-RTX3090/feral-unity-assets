using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("Remap", 0)]
	[Category("Decorators")]
	[Description("Remap the child node's status to another status. Used to either invert the child's return status or to always return a specific status.")]
	[Icon("Remap", false, "")]
	public class Remapper : BTDecorator
	{
		public enum RemapStatus
		{
			Failure,
			Success
		}

		public RemapStatus successRemap;

		public RemapStatus failureRemap;

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}
	}
}
