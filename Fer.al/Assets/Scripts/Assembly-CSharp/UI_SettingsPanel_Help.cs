using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_SettingsPanel_Help : MonoBehaviour
{
	[SerializeField]
	[Header("Help Overlays")]
	private FeralButton _overlaysToggleBtn;

	[SerializeField]
	private WWTextMeshProUGUI _overlaysValueText;

	[SerializeField]
	[Header("Tool Tips")]
	private FeralButton _tooltipsToggleBtn;

	[SerializeField]
	private WWTextMeshProUGUI _tooltipsValueText;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void BtnClicked_OverlaysToggle(bool inIsOn)
	{
	}

	private void BtnClicked_TooltipsToggle(bool inIsOn)
	{
	}
}
