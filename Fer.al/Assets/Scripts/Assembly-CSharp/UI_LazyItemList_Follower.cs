using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_Follower : UI_LazyItemList<RelationshipManager.Follower>
{
	[SerializeField]
	private UI_LazyListItem_Follower _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_Follower _detailPanelReference;

	private List<RelationshipManager.Follower> _dataItems;

	private float _lastVerticalNormalizedPosition;

	public void ClearData()
	{
	}

	protected override void Setup()
	{
	}

	private void OnScrollRectMoved(Vector2 inContentPosition)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	protected override long GetDataItemAge(RelationshipManager.Follower inData)
	{
		return default(long);
	}

	protected override bool GetDataItemFav(RelationshipManager.Follower inData)
	{
		return default(bool);
	}

	protected override string GetDataItemName(RelationshipManager.Follower inData)
	{
		return null;
	}

	protected override int GetDataItemRarity(RelationshipManager.Follower inData)
	{
		return default(int);
	}

	protected override List<RelationshipManager.Follower> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<RelationshipManager.Follower> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<RelationshipManager.Follower> GetListItemPrefab()
	{
		return null;
	}

	protected override bool ItemMatchesCategory(LazyListItem inItem)
	{
		return default(bool);
	}

	private void OnFollowersAdded(FollowersAddedMessage inMessage)
	{
	}
}
