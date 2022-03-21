using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using UnityEngine;

public class Interaction : Interactable
{
	[RootSelector("Downloadable Dialog List DefId", "ListChartData", false, false)]
	public string dialogListDefId;

	[Header("Interaction")]
	public BehaviourTreeOwner behaviourTreeOwner;

	public DialogueTreeController dialogueTreeController;

	public override void Interact()
	{
	}

	public override void MStartAfterLocal()
	{
	}
}
