using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class UI_Window_SecretCraftingItemPopup : UI_Window
{
	[SerializeField]
	[Header("Common Item")]
	private UI_ItemImage _commonItemImage;

	[SerializeField]
	private WWTextMeshProUGUI _commonItemName;

	[SerializeField]
	private WWTextMeshProUGUI _commonItemDescr;

	[SerializeField]
	private UI_RarityBadge _commonItemRarityBadge;

	[SerializeField]
	[Header("Rare Item")]
	private UI_ItemImage _rareItemImage;

	[SerializeField]
	private UI_ItemImage _rareItemOutlineImage;

	[SerializeField]
	private WWTextMeshProUGUI _rareItemName;

	[SerializeField]
	private WWTextMeshProUGUI _rareItemDescr;

	[SerializeField]
	private UI_RarityBadge _rareItemRarityBadge;

	private Action _buttonCallback;

	private BaseDef _commonItem;

	private BaseDef _rareItem;

	public static void OpenWindow(BaseDef inCommonItem, BaseDef inRareItem, [Optional] Action inButtonCallback)
	{
	}

	public static void QueueWindow(BaseDef inCommonItem, BaseDef inRareItem, [Optional] Action inButtonCallback)
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(BaseDef inCommonItem, BaseDef inRareItem, int inCommonItemCount = 1, int inRareItemCount = 1, [Optional] Action inButtonCallback)
	{
	}

	public void BtnClicked_Ok()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}
}
