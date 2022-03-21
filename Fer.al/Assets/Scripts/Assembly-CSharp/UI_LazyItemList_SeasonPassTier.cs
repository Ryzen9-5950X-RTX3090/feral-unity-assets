using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_SeasonPassTier : UI_LazyItemList<ISeasonPassTier>
{
	[SerializeField]
	private UI_LazyListItem_SeasonPassTier _itemPrefabReference;

	[SerializeField]
	private bool _scrollToCurrentTier;

	[SerializeField]
	private float _scrollToOffset;

	private List<ISeasonPassTier> _dataItems;

	public void Setup(List<ISeasonPassTier> inTiers)
	{
	}

	protected override void Setup()
	{
	}

	protected override List<ISeasonPassTier> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<ISeasonPassTier> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<ISeasonPassTier> GetListItemPrefab()
	{
		return null;
	}

	protected override void SortData()
	{
	}
}
