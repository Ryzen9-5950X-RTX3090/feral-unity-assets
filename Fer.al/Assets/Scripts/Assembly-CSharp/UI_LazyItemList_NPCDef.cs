using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_NPCDef : UI_LazyItemList<BaseDef>
{
	[SerializeField]
	private UI_LazyListItem_NPCDef _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_NPCDef _detailPanelReference;

	private List<BaseDef> _dataItems;

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

	protected override string GetDataItemName(BaseDef inData)
	{
		return null;
	}
}
