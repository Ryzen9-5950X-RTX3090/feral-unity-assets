using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_LazyItemList_Follow : UI_LazyItemList<RelationshipManager.Follow>
{
	[SerializeField]
	private UI_LazyListItem_Follow _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_Follow _detailPanelReference;

	[SerializeField]
	private WWTextMeshProUGUI _followCountText;

	private List<RelationshipManager.Follow> _dataItems;

	protected override void Setup()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUserFollowed(UserFollowedMessage inMessage)
	{
	}

	private void OnUserUnfollowed(UserUnfollowedMessage inMessage)
	{
	}

	private void UpdateFollowCountText()
	{
	}

	protected override List<RelationshipManager.Follow> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<RelationshipManager.Follow> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<RelationshipManager.Follow> GetListItemPrefab()
	{
		return null;
	}

	protected override string GetDataItemName(RelationshipManager.Follow inData)
	{
		return null;
	}

	protected override long GetDataItemAge(RelationshipManager.Follow inData)
	{
		return default(long);
	}

	protected override bool GetDataItemFav(RelationshipManager.Follow inData)
	{
		return default(bool);
	}

	protected override void SortData()
	{
	}

	private void SortByDefault()
	{
	}

	public void BtnClicked_FindPlayer()
	{
	}
}
