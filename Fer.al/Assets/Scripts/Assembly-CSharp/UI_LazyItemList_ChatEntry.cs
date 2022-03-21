using System.Collections.Generic;
using Services.Chat;
using TMPro;
using UnityEngine;

public class UI_LazyItemList_ChatEntry : UI_LazyItemList<ChatEntry>
{
	[SerializeField]
	private UI_LazyListItem_ChatEntry _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_ChatEntry _detailPanelReference;

	[SerializeField]
	private WWTextMeshProUGUI _sizeCalculationTarget;

	private List<ChatEntry> _dataItems;

	public void Setup(List<ChatEntry> inChatItems)
	{
	}

	protected override void OnEnable()
	{
	}

	public void SetTextSize(int inTextSize)
	{
	}

	public void RefreshItemSizes()
	{
	}

	protected override void Setup()
	{
	}

	protected override List<ChatEntry> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<ChatEntry> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<ChatEntry> GetListItemPrefab()
	{
		return null;
	}

	protected override LazyLayoutInfo CreateLayoutInfo(ChatEntry inItem)
	{
		return null;
	}

	private Vector2 GetItemSize(ChatEntry inItem)
	{
		return default(Vector2);
	}

	protected override void SortData()
	{
	}
}
