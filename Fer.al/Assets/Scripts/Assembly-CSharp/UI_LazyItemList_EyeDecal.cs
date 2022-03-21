using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_EyeDecal : UI_LazyItemList<BaseDef>
{
	private enum EyeDecalType
	{
		Eye = 1,
		Pupil
	}

	[SerializeField]
	private UI_LazyListItem_EyeDecal _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_EyeDecal _detailPanelReference;

	[SerializeField]
	private EyeDecalType _eyeDecalType;

	private List<BaseDef> _dataItems;

	private ActorInfo ActorInfo
	{
		get
		{
			return null;
		}
	}

	private bool DesignerMode
	{
		get
		{
			return default(bool);
		}
	}

	private void OnDisable()
	{
	}

	protected override void Setup()
	{
	}

	private void OnDecalSelected(BaseDef inDecal)
	{
	}

	protected override List<BaseDef> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<BaseDef> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<BaseDef> GetListItemPrefab()
	{
		return null;
	}

	protected override void SortData()
	{
	}
}
