using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_LazyListItemDetailPanel_UncraftingShop : UI_LazyListItemDetailPanel<Item>
{
	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private Transform _arrow;

	[SerializeField]
	private UI_ItemCraftRequirement _requirementPrefab;

	[SerializeField]
	private Transform _requirementParent;

	[SerializeField]
	private TMP_InputField _quantityInputField;

	[SerializeField]
	private List<CanvasGroup> _quantityControls;

	[SerializeField]
	private FeralAudioInfo _craftSound;

	private List<UI_ItemCraftRequirement> _requirementItems;

	private int _maxQuantity;

	private int _chosenQuantity;

	private bool _craftingInProgress;

	public int ChosenQuantity
	{
		get
		{
			return default(int);
		}
		private set
		{
		}
	}

	public TMP_InputField QuantityInputField
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void Setup(UI_LazyListItem<Item> inDataSrc)
	{
	}

	public void LongPressProgress_Craft(float inProgress)
	{
	}

	public void LongPressCancel_Craft()
	{
	}

	public void LongPressFinish_Craft()
	{
	}

	public void InputEnded_ChosenQuantity(string inValue)
	{
	}

	public void BtnClicked_IncreaseChosenQuantity()
	{
	}

	public void BtnClicked_DecreaseChosenQuantity()
	{
	}

	protected virtual void OnCraftBegin()
	{
	}

	protected virtual void OnCraftCancel()
	{
	}

	protected virtual void OnCraftFinish()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void SpawnRequirementItems()
	{
	}

	private void RefreshMax()
	{
	}

	private void OnItemChanged(InventoryItemChangedEvent inMessage)
	{
	}
}
