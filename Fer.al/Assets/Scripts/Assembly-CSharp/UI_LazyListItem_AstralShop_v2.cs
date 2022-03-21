using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItem_AstralShop_v2 : UI_LazyListItem<BaseDef>
{
	[SerializeField]
	private WWTextMeshProUGUI _costText;

	[SerializeField]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	private UI_TimeRemainingBadge _timeRemainingBadge;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private WWTextMeshProUGUI _descriptionText;

	[SerializeField]
	private UI_ItemImage _itemImage;

	[SerializeField]
	private GameObject _countGroup;

	[SerializeField]
	private WWTextMeshProUGUI _countLabel;

	[SerializeField]
	[Header("Background")]
	private WWImage _backgroundImage;

	[SerializeField]
	private Sprite _backgroundSpriteRegular;

	[SerializeField]
	private Sprite _backgroundSpriteSeasonPass;

	private BundlePackDefComponent _bundlePack;

	private PurchaseableDefComponent _purchaseable;

	private ContentVisitRecord _itemVisitRecord;

	public override void Setup(Action<UI_LazyListItem<BaseDef>> inOnClicked, Action<UI_LazyListItem<BaseDef>> inOnSelected, BaseDef inData, UI_LazyItemList<BaseDef> inItemList)
	{
	}

	private void UpdateNewBadge([Optional] ContentVisitedMessage inMessage)
	{
	}

	private void SetupTimeRemainingBadge()
	{
	}

	protected override void OnClicked()
	{
	}

	public override void ResetData()
	{
	}

	private void OnDestroy()
	{
	}
}
