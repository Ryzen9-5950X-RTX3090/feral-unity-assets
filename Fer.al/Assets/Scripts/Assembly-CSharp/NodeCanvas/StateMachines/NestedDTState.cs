using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	[Name("Sub Dialogue", 0)]
	[Description("Execute the assigned Dialogue Tree OnEnter and stop it OnExit. Optionaly an event can be send for whether the dialogue ended in Success or Failure. This can be controled by using the 'Finish' Dialogue Node inside the Dialogue Tree. Use a 'CheckEvent' condition to make use of those events. The 'Instigator' Actor of the Dialogue Tree will be set to this graph's agent.")]
	[DropReferenceType(typeof(DialogueTree))]
	public class NestedDTState : FSMStateNested<DialogueTree>
	{
		[SerializeField]
		[ExposeField]
		[Name("Sub Tree", 0)]
		private BBParameter<DialogueTree> _nestedDLG;

		[DimIfDefault]
		public string successEvent;

		[DimIfDefault]
		public string failureEvent;

		public override DialogueTree subGraph
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

		private void OnDialogueFinished(bool success)
		{
		}
	}
}
