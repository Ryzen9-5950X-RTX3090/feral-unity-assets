using System;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_SanctuaryDecoration : UI_LazyListItem<Item>
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private UI_ItemImage _itemImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	[Header("Room")]
	private GameObject _roomGroup;

	[SerializeField]
	private UI_Tooltip _roomTooltip;

	[SerializeField]
	[Header("Member")]
	private GameObject _memberGroup;

	[SerializeField]
	[Header("Rarity")]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	[Header("Unread")]
	private GameObject _unreadGroup;

	[SerializeField]
	[Header("Equipped")]
	private GameObject _equippedIcon;

	[SerializeField]
	[Header("Beta")]
	private GameObject _betaGroup;

	[SerializeField]
	private UIEffect _uiEffect;

	[SerializeField]
	private FeralAudioEmitter _equipSound;

	[SerializeField]
	private FeralAudioEmitter _unequipSound;

	private bool _isEquipped;

	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList)
	{
	}

	public override void Refresh()
	{
	}

	public void RefreshUnread()
	{
	}

	public void RefreshInteractable()
	{
	}

	private void OnEnable()
	{
	}

	protected override void OnClicked()
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	private void CraftableItemSetup(BaseDef inDef)
	{
	}

	private void RefreshEquipped()
	{
	}
}
