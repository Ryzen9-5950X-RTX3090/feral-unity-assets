using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_AstralShop : UI_LazyItemList<BaseDef>
{
	[SerializeField]
	private UI_LazyListItem_AstralShop _itemPrefabReference;

	private List<BaseDef> _dataItems;

	public void Setup(string[] inShopContent)
	{
	}

	protected override void Setup()
	{
	}

	protected override List<BaseDef> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<BaseDef> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<BaseDef> GetListItemPrefab()
	{
		return null;
	}

	protected override void SortData()
	{
	}
}
