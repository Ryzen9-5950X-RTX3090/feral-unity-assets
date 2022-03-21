using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_SanctuaryExpansionRoomControlPanel : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private GameObject _groupNotUnderConstruction;

	[SerializeField]
	private GameObject _groupUnderConstruction;

	[SerializeField]
	[Header("Edit")]
	private WWTextMeshProUGUI _editHeaderText;

	[SerializeField]
	private GameObject _groupEdit;

	[SerializeField]
	private GameObject _groupRoom;

	[SerializeField]
	private GameObject _groupExpansion;

	[SerializeField]
	private FeralButton _roomToggle;

	[SerializeField]
	private WWTextMeshProUGUI _roomValueText;

	[SerializeField]
	private FeralButton _expansionToggle;

	[SerializeField]
	private WWTextMeshProUGUI _expansionValueText;

	[SerializeField]
	[Header("Build")]
	private GameObject _groupBuild;

	public WWTextMeshProUGUI upgradeDetailsText;

	[RootSelectorCompact("Time Expansion Cost Def Id", "CraftableItemChartData", null, false, false)]
	public string timeCostDefId;

	[RootSelectorCompact("Time Expansion Cost Def Id", "CraftableItemChartData", null, false, false)]
	public string twiggleCostDefId;

	[SerializeField]
	[RootSelectorCompact("Not Enough Color", "ColorChartData", null, false, false)]
	private string _notEnoughColorDefId;

	public WWTextMeshProUGUI timeRequirmentCostLabel;

	public WWTextMeshProUGUI timeRequirmentCostText;

	public WWTextMeshProUGUI twiggleRequirmentCostText;

	public WWTextMeshProUGUI twiggleRequirmentCostLabel;

	[Header("Resources 1")]
	public WWTextMeshProUGUI generalRequirementCostLabel1;

	public WWTextMeshProUGUI generalRequirementCostText1;

	[Header("Resources 2")]
	public WWTextMeshProUGUI generalRequirementCostLabel2;

	public WWTextMeshProUGUI generalRequirementCostText2;

	[Header("Resources 3")]
	public WWTextMeshProUGUI generalRequirementCostLabel3;

	public WWTextMeshProUGUI generalRequirementCostText3;

	public FeralButton addRoomButton;

	public FeralButton expandRoomButton;

	private UI_SanctuaryExpansionRoomButton _roomButton;

	private int _roomIndex;

	private PurchaseableDefComponent _currentRoomUpgradeCost;

	public PurchaseableDefComponent CurrentRoomUpgradeCost
	{
		get
		{
			return null;
		}
	}

	public void Setup(int inRoomIndex, UI_SanctuaryExpansionRoomButton inRoomButton)
	{
	}

	public void BtnClicked_RoomToggle(bool inIsOn)
	{
	}

	public void BtnClicked_ExpansionToggle(bool inIsOn)
	{
	}

	public void BtnClicked_PurchaseRoomToggle(bool inIsOn)
	{
	}

	public void BtnClicked_PurchaseExpansionToggle(bool inIsOn)
	{
	}

	private bool SetRoomCosts(PurchaseableDefComponent inUpgradeCost)
	{
		return default(bool);
	}

	private string GetTimeUnitString(int value, string valueName, bool leadingWhitespace)
	{
		return null;
	}
}
