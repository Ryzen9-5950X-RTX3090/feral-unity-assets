using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Category("Composites")]
	[Description("Used for Utility AI, the Priority Selector executes the child with the highest priority weight. If it fails, the Priority Selector will continue with the next highest priority child until one Succeeds, or until all Fail (similar to how a normal Selector does).")]
	[Icon("Priority", false, "")]
	[Color("b3ff7f")]
	public class PrioritySelector : BTComposite
	{
		[AutoSortWithChildrenConnections]
		public List<BBParameter<float>> priorities;

		private Connection[] orderedConnections;

		private int current;

		public override void OnChildConnected(int index)
		{
		}

		public override void OnChildDisconnected(int index)
		{
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
