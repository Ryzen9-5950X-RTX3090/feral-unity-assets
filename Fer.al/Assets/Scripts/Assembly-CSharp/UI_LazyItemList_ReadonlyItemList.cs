using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_ReadonlyItemList : UI_LazyItemList<Item>
{
	[SerializeField]
	private UI_LazyListItem_ReadonlyItemList _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_ReadonlyItemList _detailPanelReference;

	[SerializeField]
	private float _maxListHeight;

	private List<Item> _dataItems;

	public void Setup(List<Item> inItems, int inCountToUseForSize = -1)
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
}
