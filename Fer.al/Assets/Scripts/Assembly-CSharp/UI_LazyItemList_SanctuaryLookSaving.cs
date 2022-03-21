using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_SanctuaryLookSaving : UI_LazyItemList<SanctuaryLookItemComponent>
{
	[SerializeField]
	private UI_LazyListItem_SanctuaryLookSaving _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_SanctuaryLookSaving _detailPanelReference;

	private List<SanctuaryLookItemComponent> _dataItems;

	public void Setup(string inSanctuaryClassDefId)
	{
	}

	protected override List<SanctuaryLookItemComponent> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<SanctuaryLookItemComponent> GetDetailPanelReference()
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
}
