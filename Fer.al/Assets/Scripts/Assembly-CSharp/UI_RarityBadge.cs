using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_RarityBadge : MonoBehaviour
{
	[SerializeField]
	private GameObject _contentGroup;

	[SerializeField]
	private Graphic _bg;

	[SerializeField]
	private TextMeshProUGUI _text;

	[SerializeField]
	[Header("Uncommon")]
	[RootSelector("Uncommon Color", "ColorChartData", false, false)]
	private string _uncommonColorDefId;

	[SerializeField]
	[RootSelector("Uncommon Text", "LocalizationChartData", false, false)]
	private string _uncommonLocalizationDefId;

	[SerializeField]
	[Header("Rare")]
	[RootSelector("Rare Color", "ColorChartData", false, false)]
	private string _rareColorDefId;

	[SerializeField]
	[RootSelector("Rare Text", "LocalizationChartData", false, false)]
	private string _rareLocalizationDefId;

	[SerializeField]
	[Header("Epic")]
	[RootSelector("Epic Color", "ColorChartData", false, false)]
	private string _epicColorDefId;

	[SerializeField]
	[RootSelector("Epic Text", "LocalizationChartData", false, false)]
	private string _epicLocalizationDefId;

	public void Setup(Rarity inRarity)
	{
	}
}
