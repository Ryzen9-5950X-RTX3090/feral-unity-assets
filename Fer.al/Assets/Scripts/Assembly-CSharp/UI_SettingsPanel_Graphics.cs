using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_SettingsPanel_Graphics : MonoBehaviour
{
	[SerializeField]
	private UI_SettingsControl_ScreenMode _screenModeControl;

	[SerializeField]
	private UI_SettingsControl_GraphicsQuality _graphicsQualityControl;

	[SerializeField]
	private WWTextMeshProUGUI _resolutionText;

	[SerializeField]
	private FeralButton _resolutionDownBtn;

	[SerializeField]
	private FeralButton _resolutionUpBtn;

	private Resolution _resolution;

	public static UI_SettingsPanel_Graphics instance;

	public UI_SettingsControl_ScreenMode ScreenModeControl
	{
		get
		{
			return null;
		}
	}

	public UI_SettingsControl_GraphicsQuality GraphicsQualityControl
	{
		get
		{
			return null;
		}
	}

	public Resolution SelectedResolution
	{
		get
		{
			return default(Resolution);
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void RefreshResolutionText()
	{
	}

	public void BtnClicked_ResolutionDown()
	{
	}

	public void BtnClicked_ResolutionUp()
	{
	}
}
