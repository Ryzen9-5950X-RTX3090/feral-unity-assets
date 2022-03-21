using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_AvatarLook : UI_LazyItemList<AvatarLookItemComponent>
{
	[SerializeField]
	private UI_LazyListItem_AvatarLook _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_AvatarLook _detailPanelReference;

	private List<AvatarLookItemComponent> _dataItems;

	private ActorInfo ActorInfo
	{
		get
		{
			return null;
		}
	}

	protected override void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected override void Setup()
	{
	}

	protected override List<AvatarLookItemComponent> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<AvatarLookItemComponent> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<AvatarLookItemComponent> GetListItemPrefab()
	{
		return null;
	}

	protected override string GetDataItemName(AvatarLookItemComponent inData)
	{
		return null;
	}

	protected override void SortData()
	{
	}

	private void ItemSelected(AvatarLookItemComponent inLookItem)
	{
	}

	public void BtnClicked_BuyLook()
	{
	}

	private void OnInventoryItemAdded(InventoryItemAddedEvent obj)
	{
	}
}
