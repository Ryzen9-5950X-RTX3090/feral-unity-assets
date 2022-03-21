using System;
using System.Collections.Generic;

[Serializable]
public class QuestDefObjective
{
	[ChartDef("Localization", new string[] { })]
	public string localizedTitleDefID;

	private LocalizationDef _localizedTitleDef;

	[ChartList]
	public List<QuestDefTask> tasks;

	[ChartBool]
	public bool isFinalObjective;

	public LocalizationDef LocalizedTitle
	{
		get
		{
			return null;
		}
	}
}
