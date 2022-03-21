using System.Collections.Generic;
using Services.Chat;
using UnityEngine;

public class UI_LazyItemList_ChatConversation : UI_LazyItemList<ChatConversationData>
{
	[SerializeField]
	private UI_LazyListItem_ChatConversation _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_ChatConversation _detailPanelReference;

	private List<ChatConversationData> _dataItems;

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void RecalculateLayout()
	{
	}

	public void ManualSetup()
	{
	}

	protected override void Setup()
	{
	}

	protected override List<ChatConversationData> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<ChatConversationData> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<ChatConversationData> GetListItemPrefab()
	{
		return null;
	}

	protected override void SortData()
	{
	}

	private void OnConversationAdded(CachedConversationAddedMessage inMessage)
	{
	}

	private void OnConversationRemoved(CachedConversationRemovedMessage inMessage)
	{
	}
}
