using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using WW.Debug;

public class UI_Window_Shop_Clothing : UI_Window_Shop_CraftableItem
{
	[SerializeField]
	[Header("Clothing Shop")]
	private UI_AvatarPositioner _avatarPositioner;

	private UI_Stage_Avatar _avatarStage;

	private List<ActorInfoClothingItem> _removedItems;

	private ActorInfoClothingItem _attachedItem;

	[DebugButton("Open Clothing Shop", "Shop", true, true)]
	public static void OpenWindow()
	{
	}

	public new static void OpenWindow(ShopContentDefComponent inShopDef)
	{
	}

	public new static void QueueWindow([Optional] ShopContentDefComponent inShopDef)
	{
	}

	public new static void CloseWindow()
	{
	}

	public override void Setup([Optional] ShopContentDefComponent inShopDef)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnAvatarStageLoaded(UIAvatarStageLoadedMessage inMessage)
	{
	}

	private void OnAvatarStageInitialized(UIAvatarStageInitializedMessage inMessage)
	{
	}

	private void OnClothingItemSelected(BaseDef inDef)
	{
	}
}
