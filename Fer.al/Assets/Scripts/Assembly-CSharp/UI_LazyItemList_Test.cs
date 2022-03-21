using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_Test : UI_LazyItemList<string>
{
	[SerializeField]
	private UI_LazyListItem_Test _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_Test _detailPanelReference;

	private List<string> _dataItems;

	protected override void Setup()
	{
	}

	protected override List<string> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<string> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<string> GetListItemPrefab()
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
}
