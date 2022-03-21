using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_SanctuaryLight : UI_LazyItemList<SanctuaryLightDefComponent>
{
	[SerializeField]
	private UI_LazyListItem_SanctuaryLight _itemPrefabReference;

	private List<SanctuaryLightDefComponent> _dataItems;

	protected override void Setup()
	{
	}

	private void OnDisable()
	{
	}

	protected override List<SanctuaryLightDefComponent> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<SanctuaryLightDefComponent> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<SanctuaryLightDefComponent> GetListItemPrefab()
	{
		return null;
	}

	private void OnLightSelected(SanctuaryLightDefComponent inLight)
	{
	}

	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage)
	{
	}

	protected override void SortData()
	{
	}
}
