using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_EditItemPanel_Dyes : MonoBehaviour
{
	private class DyeAssignment
	{
		public UI_ColorChannelTab channelTab;

		public Item dye;

		public DyeAssignment(UI_ColorChannelTab channelTab, Item dye)
		{
		}
	}

	[SerializeField]
	private UI_TabGroup _colorChannelTabGroup;

	[SerializeField]
	private GameObject _notColorableChannelGroup;

	[SerializeField]
	private List<UI_ColorChannelTab> _colorChannelTabs;

	[SerializeField]
	private UI_LazyItemList_EditItemDye _itemList;

	[SerializeField]
	private GameObject _colorableGroup;

	[SerializeField]
	private GameObject _notColorableGroup;

	[SerializeField]
	private FeralButton _applyBtn;

	private List<DyeAssignment> _dyeAssignments;

	private DyeAssignment _selectedColorChannelTab;

	private Item _selectedDyeItem;

	private ColorDefComponent _selectedDye;

	private Item _item;

	private ColorableItemComponent _colorableItemComponent;

	private bool _dyeHasBeenApplied;

	public Item SelectedDyeItem
	{
		get
		{
			return null;
		}
	}

	private List<Renderer> _spawnedItemRenderers
	{
		get
		{
			return null;
		}
	}

	public bool IsColoringAllowed()
	{
		return default(bool);
	}

	public bool SelectedDyeIsPreviewed()
	{
		return default(bool);
	}

	public int GetAvailableDyeCount(Item inDye)
	{
		return default(int);
	}

	public void BtnClicked_Apply()
	{
	}

	public void BtnClicked_ClearColorChannel(int inChannelIndex)
	{
	}

	public void BtnClicked_UndyeColorChannel(int inChannelIndex)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void InitializeColorChannelTabs()
	{
	}

	private void OnChannelSelected(int inSelectedChannel)
	{
	}

	private void OnDyeSelected(Item inSelectedDye)
	{
	}

	private void PreviewSelectedDye(bool inPreview)
	{
	}

	private void ResetItemPreview()
	{
	}

	private void RefreshItemPreview()
	{
	}

	private void OnEditItemWindowClosed(WindowClosedMessage inMessage)
	{
	}
}
