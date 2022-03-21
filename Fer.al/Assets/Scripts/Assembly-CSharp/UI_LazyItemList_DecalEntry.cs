using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyItemList_DecalEntry : UI_LazyItemList<ActorInfoDecalEntry>
{
	[SerializeField]
	private UI_LazyListItem_DecalEntry _listItemPrefab;

	[SerializeField]
	private UI_LazyListItemDetailPanel_DecalEntry _detailPanelReference;

	[SerializeField]
	private FeralButton _addDecalBtn;

	[SerializeField]
	private UI_AvatarPositioner _avatarPositioner;

	[SerializeField]
	private UI_CustomizationPageNavigationController _navigationController;

	[SerializeField]
	private UI_CustomizationPageInfo _editDecalPageInfo;

	[SerializeField]
	[Header("Decal Count")]
	private Color _redDecalCountColor;

	[SerializeField]
	private WWTextMeshProUGUI _decalCountText;

	private List<ActorInfoDecalEntry> _dataItems;

	private UI_Window_CreatureCustomization _window;

	public UI_AvatarPositioner AvatarPositioner
	{
		get
		{
			return null;
		}
	}

	public UI_CustomizationPageNavigationController NavigationController
	{
		get
		{
			return null;
		}
	}

	public UI_CustomizationPageInfo EditDecalPageInfo
	{
		get
		{
			return null;
		}
	}

	private ActorInfo ActorInfo
	{
		get
		{
			return null;
		}
	}

	private UI_Window_CreatureCustomization Window
	{
		get
		{
			return null;
		}
	}

	protected override void Setup()
	{
	}

	protected override void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDecalCountChanged(int inDecalCount)
	{
	}

	private void OnDecalSelected(ActorInfoDecalEntry inSelectedDecal)
	{
	}

	private void OnDecalAdded(ActorInfoDecalEntry inDecal)
	{
	}

	private void OnDecalRemoved(ActorInfoDecalEntry inDecal)
	{
	}

	protected override List<ActorInfoDecalEntry> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<ActorInfoDecalEntry> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<ActorInfoDecalEntry> GetListItemPrefab()
	{
		return null;
	}

	protected override void SortData()
	{
	}

	protected override bool ItemMatchesCategory(LazyListItem inItem)
	{
		return default(bool);
	}

	protected override void PostListFilter(int inShownItemsCount, int inNextIndex)
	{
	}

	public void BtnClicked_AddDecal()
	{
	}

	public void BtnClicked_RemoveAllDecals()
	{
	}

	public void ToggleBtnClicked_ShowDefaultDecals(bool inIsOn)
	{
	}
}
