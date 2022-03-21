using System.Collections;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("Iterate", 0)]
	[Category("Decorators")]
	[Description("Iterate any type of list and execute the child node for each element in the list. Keeps iterating until the Termination Condition is met or the whole list is iterated, in which case the last interation's child status is returned.")]
	[Icon("List", false, "")]
	public class Iterator : BTDecorator
	{
		public enum TerminationConditions
		{
			None,
			FirstSuccess,
			FirstFailure
		}

		[RequiredField]
		[BlackboardOnly]
		[Tooltip("The list to iterate")]
		public BBParameter<IList> targetList;

		[BlackboardOnly]
		[Name("Current Element", 0)]
		[Tooltip("Store the current element")]
		public BBObjectParameter current;

		[BlackboardOnly]
		[Name("Current Index", 0)]
		[Tooltip("Store the current index")]
		public BBParameter<int> storeIndex;

		[Tooltip("The maximum count of iterations. Leave at -1 to iterate the whole list")]
		public BBParameter<int> maxIteration;

		[Tooltip("The condition when to terminate the iteration and return status")]
		public TerminationConditions terminationCondition;

		[Tooltip("Should the iteration start from the begining after a node reset?")]
		public bool resetIndex;

		private int currentIndex;

		private IList list
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
