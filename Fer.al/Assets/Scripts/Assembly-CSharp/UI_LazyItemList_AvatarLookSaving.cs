using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_AvatarLookSaving : UI_LazyItemList<AvatarLookItemComponent>
{
	[SerializeField]
	private UI_LazyListItem_AvatarLookSaving _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_AvatarLookSaving _detailPanelReference;

	private List<AvatarLookItemComponent> _dataItems;

	public void Setup(string inActorClassDefId)
	{
	}

	protected override List<AvatarLookItemComponent> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<AvatarLookItemComponent> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<AvatarLookItemComponent> GetListItemPrefab()
	{
		return null;
	}

	protected override void SortData()
	{
	}
}
