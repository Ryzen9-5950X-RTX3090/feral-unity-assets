using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItemDetailPanel_CraftableItem_Shop : UI_LazyListItemDetailPanel<BaseDef>
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
	private WWButton _craftBtn;

	[SerializeField]
	private FeralAudioInfo _craftSound;

	private List<UI_ItemCraftRequirement> _requirementItems;

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

	public override void Setup(UI_LazyListItem<BaseDef> inDataSrc)
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

	private void OnInventoryUpdated(InventoryListResponse inMessage)
	{
	}

	private void OnInventoryItemsRemoved(InventoryListRemovedResponse inMessage)
	{
	}

	private void RefreshCraftButton()
	{
	}
}
