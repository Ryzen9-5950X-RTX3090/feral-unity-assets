using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_SettingsControl_GraphicsQuality : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _qualityLevelText;

	private DeviceQualityLevel _qualityLevel;

	private List<DeviceQualityLevel> _qualityLevels;

	private Dictionary<DeviceQualityLevel, string> _qualityLevelNames;

	public DeviceQualityLevel QualityLevel
	{
		get
		{
			return default(DeviceQualityLevel);
		}
		private set
		{
		}
	}

	private void Start()
	{
	}

	public void BtnClicked_Next()
	{
	}

	public void BtnClicked_Prev()
	{
	}

	private void RefreshQualityText()
	{
	}
}
