using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItem_CraftableItem_Shop : UI_LazyListItem<BaseDef>
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private RawImage _iconImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private GameObject _memberGroup;

	[SerializeField]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	private UI_TimeRemainingBadge _timeRemainingBadge;

	[SerializeField]
	[Header("Audio")]
	private FeralAudioInfo _selectedAudioInfo;

	[SerializeField]
	private FeralAudioInfo _deselectedAudioInfo;

	private void OnEnable()
	{
	}

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Setup(Action<UI_LazyListItem<BaseDef>> inOnClicked, Action<UI_LazyListItem<BaseDef>> inOnSelected, BaseDef inData, UI_LazyItemList<BaseDef> inItemList)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	private void RefreshCanBeCrafted()
	{
	}

	private void OnInventoryUpdated(InventoryListResponse inMessage)
	{
	}

	private void OnInventoryItemsRemoved(InventoryListRemovedResponse inMessage)
	{
	}
}
