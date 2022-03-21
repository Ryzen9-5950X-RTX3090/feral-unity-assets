using System;
using UnityAtoms;
using UnityEngine;

[Serializable]
public class Match3AchievementTypeData
{
	public ObscuredIntReference intReference;

	[SerializeField]
	[RootSelector("Localization", "LocalizationChartData", false, false)]
	private string _localizationDefId;

	private string _localizedString;

	public string LocalizedString
	{
		get
		{
			return null;
		}
	}
}
