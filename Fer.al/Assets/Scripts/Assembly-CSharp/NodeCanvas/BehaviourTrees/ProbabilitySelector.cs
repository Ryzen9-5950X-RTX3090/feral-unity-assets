using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Category("Composites")]
	[Description("Select a child to execute based on it's chance to be selected and return Success if it returns Success, otherwise pick another.\nReturns Failure if no child returns Success or a direct 'Failure Chance' is introduced")]
	[Icon("ProbabilitySelector", false, "")]
	[Color("b3ff7f")]
	public class ProbabilitySelector : BTComposite
	{
		[AutoSortWithChildrenConnections]
		public List<BBParameter<float>> childWeights;

		public BBParameter<float> failChance;

		private float probability;

		private float currentProbability;

		private List<int> failedIndeces;

		public override void OnChildConnected(int index)
		{
		}

		public override void OnChildDisconnected(int index)
		{
		}

		public override void OnGraphStarted()
		{
		}

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected override void OnReset()
		{
		}

		private float GetTotal()
		{
			return default(float);
		}
	}
}
