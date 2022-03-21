using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("Parallel", 8)]
	[Category("Composites")]
	[Description("Execute all child nodes once but simultaneously and return Success or Failure depending on the selected ParallelPolicy.\nIf set to Repeat, child nodes are repeated until the Policy set is met, or until all children have had a chance to complete at least once.")]
	[Icon("Parallel", false, "")]
	[Color("ff64cb")]
	public class Parallel : BTComposite
	{
		public enum ParallelPolicy
		{
			FirstFailure,
			FirstSuccess,
			FirstSuccessOrFailure
		}

		public ParallelPolicy policy;

		[Name("Repeat", 0)]
		public bool dynamic;

		private readonly List<Connection> finishedConnections;

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected override void OnReset()
		{
		}

		private void ResetRunning()
		{
		}
	}
}
