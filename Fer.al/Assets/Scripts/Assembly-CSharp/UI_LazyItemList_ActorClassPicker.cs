using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_ActorClassPicker : UI_LazyItemList<ActorClassDefComponent>
{
	[SerializeField]
	private UI_LazyListItem_ActorClassPicker _itemPrefabReference;

	private List<ActorClassDefComponent> _dataItems;

	private void OnDisable()
	{
	}

	protected override void Setup()
	{
	}

	protected override List<ActorClassDefComponent> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<ActorClassDefComponent> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<ActorClassDefComponent> GetListItemPrefab()
	{
		return null;
	}

	protected override bool ItemMatchesSearch(LazyListItem inItem)
	{
		return default(bool);
	}

	protected override string GetDataItemName(ActorClassDefComponent inData)
	{
		return null;
	}

	protected override List<string> GetDataItemFilters(ActorClassDefComponent inData)
	{
		return null;
	}

	protected override List<string> GetDataItemTags(ActorClassDefComponent inData)
	{
		return null;
	}
}
