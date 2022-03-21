using UnityEngine;

public class UI_Stage_UncraftingShop : UI_Stage_3DItem
{
	[SerializeField]
	private ActorNPCSpawner _shopkeep;

	[SerializeField]
	private Animator _centrifugeAnimator;

	protected override void SendLoadedMessage()
	{
	}

	protected override void SendInitializedMessage()
	{
	}

	public void SetIsCrafting(bool inIsCrafting)
	{
	}
}
