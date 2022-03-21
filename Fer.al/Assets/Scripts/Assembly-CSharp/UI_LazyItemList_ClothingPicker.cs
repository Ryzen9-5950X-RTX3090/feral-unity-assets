using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_ClothingPicker : UI_LazyItemList<ActorClothingDefComponent>
{
	[SerializeField]
	private UI_LazyListItem_ClothingPicker _itemPrefabReference;

	private List<ActorClothingDefComponent> _dataItems;

	private void OnDisable()
	{
	}

	protected override void Setup()
	{
	}

	protected override List<ActorClothingDefComponent> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<ActorClothingDefComponent> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<ActorClothingDefComponent> GetListItemPrefab()
	{
		return null;
	}

	protected override bool ItemMatchesSearch(LazyListItem inItem)
	{
		return default(bool);
	}

	protected override string GetDataItemName(ActorClothingDefComponent inData)
	{
		return null;
	}

	protected override List<string> GetDataItemFilters(ActorClothingDefComponent inData)
	{
		return null;
	}

	protected override List<string> GetDataItemTags(ActorClothingDefComponent inData)
	{
		return null;
	}

	protected override int GetDataItemRarity(ActorClothingDefComponent inData)
	{
		return default(int);
	}

	protected override void SortData()
	{
	}
}
