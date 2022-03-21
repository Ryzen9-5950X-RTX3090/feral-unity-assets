using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_SeasonPassChallenges : UI_LazyItemList<ISeasonPassChallenge>
{
	[SerializeField]
	private UI_LazyListItem_SeasonPassChallenges _itemPrefabReference;

	private List<ISeasonPassChallenge> _dataItems;

	private List<ISeasonPassChallenge> _availableChallenges;

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	protected override void Setup()
	{
	}

	protected override List<ISeasonPassChallenge> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<ISeasonPassChallenge> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<ISeasonPassChallenge> GetListItemPrefab()
	{
		return null;
	}

	protected override void SortData()
	{
	}

	protected override bool ItemMatchesCategory(LazyListItem inItem)
	{
		return default(bool);
	}

	private void OnChallengeCompleted(SeasonPassChallengeCompleteResponse inMessage)
	{
	}
}
