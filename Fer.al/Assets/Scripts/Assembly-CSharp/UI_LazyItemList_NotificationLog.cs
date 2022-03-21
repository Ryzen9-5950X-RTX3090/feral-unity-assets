using System.Collections.Generic;
using UnityEngine;
using WW.Waiters;

public class UI_LazyItemList_NotificationLog : UI_LazyItemList<Notification>
{
	[SerializeField]
	private UI_LazyListItem_NotificationLog _itemPrefabReference;

	[SerializeField]
	private RectTransform _allCaughtUpGroup;

	private LazyLayoutElement _allCaughtUpElement;

	private List<Notification> _dataItems;

	private WW.Waiters.Waiter _refreshWaiter;

	public LazyLayoutElement AllCaughtUpElement
	{
		get
		{
			return null;
		}
	}

	protected override void Setup()
	{
	}

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnNotificationSent(NotificationSentMessage inMessage)
	{
	}

	protected override void PostListFilter(int inShownItemsCount, int inNextIndex)
	{
	}

	private void RefreshAllCaughtUpGroup(int inFrameDelay = 1)
	{
	}

	protected override List<Notification> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<Notification> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<Notification> GetListItemPrefab()
	{
		return null;
	}

	protected override string GetDataItemName(Notification inData)
	{
		return null;
	}

	protected override long GetDataItemAge(Notification inData)
	{
		return default(long);
	}

	protected override void SortData()
	{
	}

	protected override LazyLayoutInfo CreateLayoutInfo(Notification inItem)
	{
		return null;
	}
}
