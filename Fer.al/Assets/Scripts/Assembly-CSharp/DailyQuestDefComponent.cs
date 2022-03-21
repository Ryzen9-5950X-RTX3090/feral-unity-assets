using System;

[Serializable]
[ChartComponent("DailyQuest")]
public class DailyQuestDefComponent : DefComponent
{
	[ChartDef("Localization", new string[] { })]
	public string locTitleDefID;

	private LocalizationDef _locTitleDef;

	[ChartString]
	public string dailyQuestUUID;

	public LocalizationDef LocTitle
	{
		get
		{
			return null;
		}
	}
}
