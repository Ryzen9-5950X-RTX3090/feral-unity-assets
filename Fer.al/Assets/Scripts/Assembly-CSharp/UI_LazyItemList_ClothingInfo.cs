using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_ClothingInfo : UI_LazyItemList<ColorableItemComponent>
{
	[SerializeField]
	private UI_AvatarPositioner _avatarPositioner;

	[SerializeField]
	private UI_LazyListItemDetailPanel_ClothingInfo _detailPanel;

	[SerializeField]
	private UI_LazyListItem_ClothingInfo _itemPrefab;

	[SerializeField]
	[RootSelector("Clothing Group", "ActorAttachNodeGroupChartData", false, false)]
	private string _actorAttachNodeGroupDefId;

	private List<ColorableItemComponent> _dataItems;

	private Dictionary<string, int> _attachNodeDefIdMap;

	private bool _isDesignerMode;

	private string _equippedCategory;

	private ActorInfo ActorInfo
	{
		get
		{
			return null;
		}
	}

	private string EquippedCategory
	{
		get
		{
			return null;
		}
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

	protected override UI_LazyListItemDetailPanel<ColorableItemComponent> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<ColorableItemComponent> GetListItemPrefab()
	{
		return null;
	}

	protected override List<ColorableItemComponent> GetDataItems()
	{
		return null;
	}

	protected override bool ItemMatchesSearch(LazyListItem inItem)
	{
		return default(bool);
	}

	protected override bool ItemMatchesCategory(LazyListItem inItem)
	{
		return default(bool);
	}

	protected override bool ItemMatchesFilter(LazyListItem inItem, string inFilterCategory)
	{
		return default(bool);
	}

	protected override void SortData()
	{
	}

	protected override void SortNewToOld()
	{
	}

	protected override string GetDataItemName(ColorableItemComponent inData)
	{
		return null;
	}

	protected override List<string> GetDataItemFilters(ColorableItemComponent inData)
	{
		return null;
	}

	protected override List<string> GetDataItemTags(ColorableItemComponent inData)
	{
		return null;
	}

	protected override int GetDataItemRarity(ColorableItemComponent inData)
	{
		return default(int);
	}

	protected override bool GetDataItemFav(ColorableItemComponent inData)
	{
		return default(bool);
	}

	protected override long GetDataItemAge(ColorableItemComponent inData)
	{
		return default(long);
	}

	public void BtnClicked_ClearAll()
	{
	}

	public void BtnClicked_GoToShop()
	{
	}
}
