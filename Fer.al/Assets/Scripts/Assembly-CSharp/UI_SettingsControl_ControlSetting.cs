using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_SettingsControl_ControlSetting : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _controlSettingText;

	private int _controlSetting;

	private List<ValueTuple<GameSettingsManager.ControlSetting, string>> _controlSettings;

	public int ControlSetting
	{
		get
		{
			return default(int);
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

	public void BtnClicked_ControlInfo()
	{
	}

	private void RefreshControlSettingText()
	{
	}
}
