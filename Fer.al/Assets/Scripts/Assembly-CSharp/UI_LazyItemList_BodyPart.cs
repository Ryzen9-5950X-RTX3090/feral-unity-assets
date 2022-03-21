using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_BodyPart : UI_LazyItemList<ActorBodyPartDefComponent>
{
	[SerializeField]
	private UI_LazyListItem_BodyPart _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_BodyPart _detailPanelReference;

	[SerializeField]
	[RootSelector("BodyPartNode", "ActorBodyPartNodeChartData", false, false)]
	private string _bodyPartNodeDefId;

	private List<ActorBodyPartDefComponent> _dataItems;

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

	private void OnBodyPartSelected(ActorBodyPartDefComponent inBodyPart)
	{
	}

	protected override List<ActorBodyPartDefComponent> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<ActorBodyPartDefComponent> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<ActorBodyPartDefComponent> GetListItemPrefab()
	{
		return null;
	}
}
