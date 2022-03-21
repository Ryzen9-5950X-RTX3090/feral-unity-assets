using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItemDetailPanel_ItemInventory : UI_LazyListItemDetailPanel_Item
{
	[SerializeField]
	private WWTextMeshProUGUI _descriptionText;

	[SerializeField]
	private GameObject _dyeBtn;

	[SerializeField]
	private FeralButton _tradeBtn;

	[SerializeField]
	private GameObject _harvestPointGroup;

	[SerializeField]
	private RawImage _harvestPointImage;

	private ActorInfo _actorInfo;

	private bool _isEquipped;

	private TradableItemComponent _tradeableItemComponent;

	private Item _item;

	private bool _harvestPointIconAssigned;

	public override void Setup(UI_LazyListItem<Item> inDataSrc)
	{
	}

	public override void Refresh()
	{
	}

	protected override void OnEnable()
	{
	}

	public void BtnClicked_Equip()
	{
	}

	public void BtnClicked_Edit()
	{
	}

	public void ToggleBtnClicked_TradeList(bool inIsOn)
	{
	}

	private void ClothingSetup(ActorClothingDefComponent inClothingDefComponent)
	{
	}

	private void OnClothingItemEquip(ActorInfoClothingItem inInfo, bool inIsEquipped)
	{
	}

	private void SetupEquipped(bool inIsEquipped)
	{
	}

	private void SetupIngredient()
	{
	}

	private void SetupTradeable()
	{
	}

	private void RefreshTradeable()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnInventoryUpdated(InventoryListResponse inMessage)
	{
	}

	private void OnItemAddedOrRemovedFromTradeList(ItemAddedOrRemovedFromTradeList inMessage)
	{
	}
}
