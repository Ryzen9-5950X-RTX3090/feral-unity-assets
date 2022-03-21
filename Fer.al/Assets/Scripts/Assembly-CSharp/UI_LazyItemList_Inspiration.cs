using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_Inspiration : UI_LazyItemList<InspirationItemComponent>
{
	[SerializeField]
	private UI_LazyListItem_Inspiration _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_Inspiration _detailPanelReference;

	private List<InspirationItemComponent> _dataItems;

	protected override void Setup()
	{
	}

	protected override List<InspirationItemComponent> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<InspirationItemComponent> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<InspirationItemComponent> GetListItemPrefab()
	{
		return null;
	}

	protected override string GetDataItemName(InspirationItemComponent inData)
	{
		return null;
	}

	protected override List<string> GetDataItemFilters(InspirationItemComponent inData)
	{
		return null;
	}

	protected override List<string> GetDataItemTags(InspirationItemComponent inData)
	{
		return null;
	}

	protected override void SortData()
	{
	}
}
