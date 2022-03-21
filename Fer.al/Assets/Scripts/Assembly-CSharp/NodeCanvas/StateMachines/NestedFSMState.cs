using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	[Name("Sub FSM", 0)]
	[Description("Execute a nested FSM OnEnter and Stop that FSM OnExit. This state is Finished when the nested FSM is finished as well")]
	[DropReferenceType(typeof(FSM))]
	public class NestedFSMState : FSMStateNested<FSM>
	{
		public enum FSMExitMode
		{
			StopAndRestart,
			PauseAndResume
		}

		[SerializeField]
		[ExposeField]
		[Name("Sub FSM", 0)]
		protected BBParameter<FSM> _nestedFSM;

		public FSMExitMode exitMode;

		public override FSM subGraph
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

		protected override void OnExit()
		{
		}
	}
}
