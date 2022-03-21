using System;

[Serializable]
[ChartComponent("Objective")]
public class ObjectiveDefComponent : DefComponent
{
	[ChartDef("Localization", new string[] { })]
	public string localizedTitleDefID;

	private LocalizationDef _localizedTitleDef;

	[ChartList]
	[ChartDef("Task", new string[] { })]
	public ChartDefList taskDefs;

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
