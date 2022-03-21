using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_SeasonPassTier : UI_LazyListItem<ISeasonPassTier>
{
	[SerializeField]
	private WWTextMeshProUGUI _tierNumberText;

	[SerializeField]
	[Header("Reward")]
	private UI_ItemImage _rewardItemImage;

	[SerializeField]
	private GameObject _rewardCountGroup;

	[SerializeField]
	private WWTextMeshProUGUI _rewardCountText;

	[SerializeField]
	private WWTextMeshProUGUI _rewardName;

	[SerializeField]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	[Header("Completion Status")]
	private GameObject _statusActiveGroup;

	[SerializeField]
	private GameObject _statusCompleteGroup;

	[SerializeField]
	private GameObject _statusUnearnedCheckGroup;

	[SerializeField]
	private GameObject _statusLockGroup;

	[SerializeField]
	[Header("Free")]
	private GameObject _freeGroup;

	[SerializeField]
	[Header("Progress")]
	private WWTextMeshProUGUI _progressText;

	[SerializeField]
	private Color _progressColorIncomplete;

	[SerializeField]
	private Color _progressColorComplete;

	[SerializeField]
	[Header("Vertical Position Effect")]
	private Transform _offsetTarget;

	[SerializeField]
	private float _maxYPos;

	[SerializeField]
	private float _minYPos;

	private LazyLayoutElement _layoutElement;

	private bool _visible;

	public override void Setup(Action<UI_LazyListItem<ISeasonPassTier>> inOnClicked, Action<UI_LazyListItem<ISeasonPassTier>> inOnSelected, ISeasonPassTier inData, UI_LazyItemList<ISeasonPassTier> inItemList)
	{
	}

	public override void Refresh()
	{
	}

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnTierCompleted(SeasonPassTierCompletedMessage inMessage)
	{
	}

	private void OnInventoryChanged(InventoryItemChangedEvent inMessage)
	{
	}

	private void OnSeasonPassPurchased(SeasonPassPurchasedMessage inMessage)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	protected override void OnClicked()
	{
	}

	private void Update()
	{
	}
}
