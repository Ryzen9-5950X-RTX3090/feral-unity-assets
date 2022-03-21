using System;
using System.Collections.Generic;

[Serializable]
[ChartComponent("QueensQuestEvent")]
public class QueensQuestEventDefComponent : DefComponent
{
	[ChartDef("CraftableItem", new string[] { })]
	public string cachedUserVarDefId;

	private BaseDef _craftableItemDef;

	[ChartDef("Localization", new string[] { })]
	public string locTitleDefID;

	private LocalizationDef _locTitleDef;

	[ChartDef("Localization", new string[] { })]
	public string locDescriptionDefID;

	private LocalizationDef _locDescriptionDef;

	[ChartDef("Image", new string[] { })]
	public string gameImageDefId;

	private ImageDefComponent _gameImageDef;

	[ChartList]
	public List<QuestDefObjective> primaryObjectives;

	public BaseDef CraftableItemDef
	{
		get
		{
			return null;
		}
	}

	public LocalizationDef LocTitle
	{
		get
		{
			return null;
		}
	}

	public LocalizationDef LocDescription
	{
		get
		{
			return null;
		}
	}

	public ImageDefComponent GameImage
	{
		get
		{
			return null;
		}
	}
}
