using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_Quests : UI_LazyItemList<ILinearQuestData>
{
	[SerializeField]
	private UI_LazyListItem_Quests _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_Quests _detailPanelReference;

	[SerializeField]
	private bool _includeCompletedQuests;

	[SerializeField]
	private bool _includeIncompleteQuests;

	private List<ILinearQuestData> _dataItems;

	protected override void Setup()
	{
	}

	private void OnDisable()
	{
	}

	protected override List<ILinearQuestData> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<ILinearQuestData> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<ILinearQuestData> GetListItemPrefab()
	{
		return null;
	}

	private void OnQuestCompleted(LinearQuestCompleteMessage inMessage)
	{
	}
}
