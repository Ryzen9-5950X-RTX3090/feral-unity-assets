using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_ItemInventory : UI_LazyListItem<Item>
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private UI_ItemImage _itemImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	[Header("Member")]
	private GameObject _memberGroup;

	[SerializeField]
	[Header("Rarity")]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	[Header("Stackable")]
	private GameObject _ownedCountBadge;

	[SerializeField]
	private WWTextMeshProUGUI _ownedCount;

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
	[Header("Audio")]
	private FeralAudioInfo _selectedAudioInfo;

	[SerializeField]
	private FeralAudioInfo _deselectedAudioInfo;

	private ActorInfo _actorInfo;

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	public override void Refresh()
	{
	}

	public void RefreshQuantity()
	{
	}

	public void RefreshUnread()
	{
	}

	private void OnEnable()
	{
	}

	private void CraftableItemSetup(BaseDef inDef)
	{
	}

	private void ClothingSetup(ActorClothingDefComponent inClothingDefComponent)
	{
	}

	private void OnClothingItemEquip(ActorInfoClothingItem inItem, bool inIsEquipped)
	{
	}

	private void SetupEquipped(bool inIsEquipped)
	{
	}

	private void OnItemChanged(InventoryItemChangedEvent inMessage)
	{
	}
}
