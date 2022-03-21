using TMPro;
using UnityEngine;

public class UI_Window_ConfirmGraphicsSettings : UI_Window
{
	[SerializeField]
	protected WWTextMeshProUGUI _timeText;

	private bool _isSetup;

	private bool _coreReset;

	private float _remainingTime;

	private int _prevRemaningSeconds;

	private Resolution _originalResolution;

	private bool _originalFullscreen;

	private DeviceQualityLevel _originalQuality;

	public static void OpenWindow(Resolution inOriginalResolution, bool inOriginalFullscreen, DeviceQualityLevel inOriginalQuality)
	{
	}

	public static void QueueWindow(Resolution inOriginalResolution, bool inOriginalFullscreen, DeviceQualityLevel inOriginalQuality)
	{
	}

	public static void CloseWindow()
	{
	}

	public void BtnClicked_Confirm()
	{
	}

	public void BtnClicked_Cancel()
	{
	}

	private void Setup(Resolution inOriginalResolution, bool inOriginalFullscreen, DeviceQualityLevel inOriginalQuality)
	{
	}

	private void RefreshTimeText()
	{
	}

	public override void MUpdate()
	{
	}
}
