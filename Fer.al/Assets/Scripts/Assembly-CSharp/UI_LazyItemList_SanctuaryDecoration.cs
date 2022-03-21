using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_SanctuaryDecoration : UI_LazyItemList<Item>
{
	[SerializeField]
	private UI_LazyListItem_SanctuaryDecoration _itemPrefab;

	private List<Item> _inventoryItems;

	private string _equippedCategory;

	private string EquippedCategory
	{
		get
		{
			return null;
		}
	}

	public void Setup(List<Item> inItems)
	{
	}

	public void SetupDefault()
	{
	}

	protected override void Setup()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected override List<string> GetDataItemFilters(Item inData)
	{
		return null;
	}

	protected override long GetDataItemAge(Item inData)
	{
		return default(long);
	}

	protected override bool GetDataItemFav(Item inData)
	{
		return default(bool);
	}

	protected override string GetDataItemName(Item inData)
	{
		return null;
	}

	protected override int GetDataItemRarity(Item inData)
	{
		return default(int);
	}

	protected override string GetDataItemId(Item inData)
	{
		return null;
	}

	protected override void SortData()
	{
	}

	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference()
	{
		return null;
	}

	protected override List<Item> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItem<Item> GetListItemPrefab()
	{
		return null;
	}

	protected override bool ItemMatchesCategory(LazyListItem inItem)
	{
		return default(bool);
	}

	protected override bool ItemMatchesFilter(LazyListItem inItem, string inFilterCategory)
	{
		return default(bool);
	}

	private void OnInventoryListRemoved(InventoryListRemovedResponse inMessage)
	{
	}

	private void OnInventoryList(InventoryListResponse inMessage)
	{
	}

	private void ItemSelected(Item inSelectedItem)
	{
	}

	private void RefreshAll()
	{
	}

	private void OnSanctuaryObjectRemoved(SanctuaryObjectBase inSanctuaryObject)
	{
	}

	private void OnSanctuaryObjectAdded(SanctuaryObjectBase inSanctuaryObject)
	{
	}

	private void OnSanctuaryItemAdded(SanctuaryAddMessage inMessage)
	{
	}

	private void OnSanctuaryItemRemoved(SanctuaryRemoveMessage inMessage)
	{
	}

	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage)
	{
	}

	private void OnSanctuaryInteriorExteriorChange(SanctuaryInteriorExteriorChange inMessage)
	{
	}
}
