using System;
using UnityEngine;

public class UI_SettingsControl_Privacy : MonoBehaviour
{
	[SerializeField]
	private UI_TabGroup _tabGroup;

	private Action<PrivacySetting.PrivacyLevel> _setter;

	private Func<PrivacySetting.PrivacyLevel> _getter;

	public void Setup(Action<PrivacySetting.PrivacyLevel> inSetter, Func<PrivacySetting.PrivacyLevel> inGetter)
	{
	}

	private void OnSettingChosen(int inChosenSetting)
	{
	}
}
