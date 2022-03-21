using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("Sub Dialogue", 0)]
	[Description("Will Execute the nested dialogue assigned and return Success or Failure depending on the Dialogue Tree end state. This can be controled by using the 'Finish' Dialogue Node inside the Dialogue Tree. By default a Dialogue Tree ends in Success. The 'Instigator' Actor of the Dialogue Tree will be set to this graph's agent.")]
	[Icon("Dialogue", false, "")]
	[DropReferenceType(typeof(DialogueTree))]
	public class NestedDT : BTNodeNested<DialogueTree>
	{
		[SerializeField]
		[ExposeField]
		[Name("Sub Tree", 0)]
		private BBParameter<DialogueTree> _nestedDialogueTree;

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

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		private void OnDLGFinished(bool success)
		{
		}

		protected override void OnReset()
		{
		}
	}
}
