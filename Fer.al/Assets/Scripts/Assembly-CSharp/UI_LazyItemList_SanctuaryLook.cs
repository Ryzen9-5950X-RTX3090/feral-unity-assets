using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_SanctuaryLook : UI_LazyItemList<SanctuaryLookItemComponent>
{
	[SerializeField]
	private UI_LazyListItem_SanctuaryLook _itemPrefabReference;

	private List<SanctuaryLookItemComponent> _dataItems;

	private SanctuaryLookItemComponent CurrentPrimaryLook
	{
		get
		{
			return null;
		}
	}

	protected override void Setup()
	{
	}

	private void OnDisable()
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

	private void ItemSelected(SanctuaryLookItemComponent inLookItem)
	{
	}
}
