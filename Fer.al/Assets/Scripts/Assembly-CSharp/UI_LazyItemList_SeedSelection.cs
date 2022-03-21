using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_SeedSelection : UI_LazyItemList<Item>
{
	[SerializeField]
	private UI_LazyListItem_SeedSelection _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_SeedSelection _detailPanelReference;

	private List<Item> _dataItems;

	private List<string> _pendingPlantedSeeds;

	private Dictionary<string, int> _countOffsets;

	public void Setup(List<string> inPendingPlantedSeeds)
	{
	}

	public void ClearList()
	{
	}

	protected override void Setup()
	{
	}

	protected override List<Item> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<Item> GetListItemPrefab()
	{
		return null;
	}

	protected override bool ItemMatchesSearch(LazyListItem inItem)
	{
		return default(bool);
	}

	protected override void SortData()
	{
	}

	public int GetAdjustedItemCount(Item inItem)
	{
		return default(int);
	}
}
