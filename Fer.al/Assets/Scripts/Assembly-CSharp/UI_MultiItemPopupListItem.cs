using TMPro;
using UnityEngine;

public class UI_MultiItemPopupListItem : MonoBehaviour
{
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
	private UI_ItemImage _currencyItemImage;

	public void Setup(BaseDef inItemDef, int inQuantity)
	{
	}
}
