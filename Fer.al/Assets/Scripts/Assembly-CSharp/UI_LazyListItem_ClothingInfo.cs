using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_LazyListItem_ClothingInfo : UI_LazyListItem<ColorableItemComponent>, ISelectHandler, IEventSystemHandler
{
	[SerializeField]
	private UI_ItemImage _itemImage;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private GameObject _equippedBadge;

	[SerializeField]
	[Header("Rarity")]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	[Header("Unread")]
	private GameObject _unreadGroup;

	[SerializeField]
	[Header("Member")]
	private GameObject _memberGroup;

	[SerializeField]
	[Header("Beta")]
	private GameObject _betaGroup;

	[SerializeField]
	[Header("Audio")]
	private FeralAudioInfo _equipAudioInfo;

	[SerializeField]
	private FeralAudioInfo _removeAudioInfo;

	[SerializeField]
	[Header("Design Mode ONLY")]
	private FeralButton _editButton;

	private ActorInfo _actorInfo;

	private bool _isEquipped;

	private UI_Window_CreatureCustomization _window;

	public override void Setup(Action<UI_LazyListItem<ColorableItemComponent>> inOnClicked, Action<UI_LazyListItem<ColorableItemComponent>> inOnSelected, ColorableItemComponent inData, UI_LazyItemList<ColorableItemComponent> inItemList)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClothingItemEquip(ActorInfoClothingItem inInfo, bool inIsEquipped)
	{
	}

	private void RefreshIsEquipped()
	{
	}

	public void RefreshUnread()
	{
	}

	protected override void OnClicked()
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	public void BtnClicked_Designer_EditItem()
	{
	}
}
