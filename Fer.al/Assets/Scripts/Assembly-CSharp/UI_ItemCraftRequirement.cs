using TMPro;
using UnityEngine;

public class UI_ItemCraftRequirement : MonoBehaviour
{
	[SerializeField]
	private bool _uncraftingMode;

	[SerializeField]
	[Header("Name")]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	[RootSelector("Common Color", "ColorChartData", false, false)]
	private string _commonColorDefId;

	[SerializeField]
	[RootSelector("Uncommon Color", "ColorChartData", false, false)]
	private string _uncommonColorDefId;

	[SerializeField]
	[RootSelector("Rare Color", "ColorChartData", false, false)]
	private string _rareColorDefId;

	[SerializeField]
	[RootSelector("Epic Color", "ColorChartData", false, false)]
	private string _epicColorDefId;

	[SerializeField]
	[Header("Amount")]
	private WWTextMeshProUGUI _amountText;

	[SerializeField]
	private GameObject _currencyImageGroup;

	[SerializeField]
	[RootSelector("Not Enough Color", "ColorChartData", false, false)]
	private string _notEnoughColorDefId;

	private bool _hasRequirement;

	private BaseDef _itemDef;

	private PurchaseableDefComponent.CostEntry _requirement;

	private int _quantity;

	public bool HasRequirement
	{
		get
		{
			return default(bool);
		}
	}

	public void Setup(PurchaseableDefComponent.CostEntry inItemRequirement, int inQuantity)
	{
	}

	public void Refresh(int inQuantity)
	{
	}
}
