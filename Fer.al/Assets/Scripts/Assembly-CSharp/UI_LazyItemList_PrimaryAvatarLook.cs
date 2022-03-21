using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_PrimaryAvatarLook : UI_LazyItemList<AvatarLookItemComponent>
{
	[SerializeField]
	private UI_LazyListItem_PrimaryAvatarLook _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_PrimaryAvatarLook _detailPanelReference;

	private List<AvatarLookItemComponent> _dataItems;

	public void RefreshAll()
	{
	}

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	protected override void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected override void Setup()
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

	protected override string GetDataItemName(AvatarLookItemComponent inData)
	{
		return null;
	}

	protected override void SortData()
	{
	}

	private void OnCurrentLookChanged(CreatureCustomizationTarget inTarget)
	{
	}
}
