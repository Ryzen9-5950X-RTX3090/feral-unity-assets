using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_House : UI_LazyItemList<SanctuaryLookItemComponent>
{
	[SerializeField]
	private UI_LazyListItem_House _itemPrefabReference;

	private List<SanctuaryLookItemComponent> _dataItems;

	public void ManualSetup()
	{
	}

	public void RefreshAll()
	{
	}

	protected override void Setup()
	{
	}

	protected override List<SanctuaryLookItemComponent> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItem<SanctuaryLookItemComponent> GetListItemPrefab()
	{
		return null;
	}

	protected override void SortData()
	{
	}

	protected override UI_LazyListItemDetailPanel<SanctuaryLookItemComponent> GetDetailPanelReference()
	{
		return null;
	}
}
