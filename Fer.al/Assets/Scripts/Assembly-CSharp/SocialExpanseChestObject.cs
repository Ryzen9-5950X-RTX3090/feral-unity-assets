using UnityEngine;

public class SocialExpanseChestObject : MonoBehaviour
{
	public Interactable.EItemType itemType;

	public NetworkedObjectInfo chestNetworkObjectInfo;

	public GameObject interactionObject;

	public DOTweenAnimator openTween;

	public DOTweenAnimator closeTween;

	public FeralAudioInfo openChestSfx;

	public FeralAudioInfo closeChestSfx;

	private void InternalOpenChest(bool playSfx)
	{
	}

	private void InternalCloseChest(bool playSfx)
	{
	}

	public void SilentCloseChest()
	{
	}

	public void CloseChest()
	{
	}

	public void OpenChest()
	{
	}
}
