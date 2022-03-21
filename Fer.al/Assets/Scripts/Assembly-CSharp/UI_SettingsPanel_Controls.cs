using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_SettingsPanel_Controls : MonoBehaviour
{
	[SerializeField]
	[Header("Sensitivity")]
	private Slider _sensitivitySlider;

	[SerializeField]
	private WWTextMeshProUGUI _sensitivityValueText;

	[SerializeField]
	[Header("Invert Camera")]
	private FeralButton _invertCameraToggleBtn;

	[SerializeField]
	private WWTextMeshProUGUI _invertCameraValueText;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void BtnClicked_Hotkeys()
	{
	}

	private void SliderValueChanged_CameraSensitivity(float inSensitivity)
	{
	}

	private void BtnClicked_InvertCameraToggle(bool inIsOn)
	{
	}
}
