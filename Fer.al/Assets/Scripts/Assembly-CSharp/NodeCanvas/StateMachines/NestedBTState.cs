using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	[Name("Sub BehaviourTree", 0)]
	[Description("Execute a Behaviour Tree OnEnter. OnExit that Behavior Tree will be stoped or paused based on the relevant specified setting. You can optionaly specify a Success Event and a Failure Event which will be sent when the BT's root node status returns either of the two. If so, use alongside with a CheckEvent on a transition.")]
	[DropReferenceType(typeof(BehaviourTree))]
	public class NestedBTState : FSMStateNested<BehaviourTree>
	{
		public enum BTExecutionMode
		{
			Once,
			Repeat
		}

		public enum BTExitMode
		{
			StopAndRestart,
			PauseAndResume
		}

		[SerializeField]
		[ExposeField]
		[Name("Sub Tree", 0)]
		private BBParameter<BehaviourTree> _nestedBT;

		public BTExitMode exitMode;

		public BTExecutionMode executionMode;

		[DimIfDefault]
		public string successEvent;

		[DimIfDefault]
		public string failureEvent;

		public override BehaviourTree subGraph
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override BBParameter subGraphParameter
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void OnFinish(bool success)
		{
		}

		protected override void OnExit()
		{
		}
	}
}
