using System;
using System.Collections.Generic;

[Serializable]
[ChartComponent("SocialExpanse")]
public class SocialExpanseDefComponent : DefComponent
{
	[ChartDef("LevelOverride", new string[] { })]
	public string linearQuestLevelOverrideDefId;

	[ChartDef("LevelOverride", new string[] { })]
	public string linearQuestAudioLevelOverrideDefId;

	[ChartDef("LevelOverride", new string[] { })]
	public string baselevelRemoveLevelOverrideDefId;

	[ChartBool]
	public bool alwaysActive;

	[ChartEnum]
	public SocialExpanseArea socialExpanseArea;

	public string questGiverNameDefId;

	[ChartDef("Image", new string[] { })]
	public string questGiverIconDefId;

	[ChartList]
	public List<QuestDefObjective> primaryObjectives;

	[ChartList]
	[ChartDef("CraftableItem", new string[] { })]
	public ChartDefList requiredAvatarDefIds;

	public virtual string QuestGiverName
	{
		get
		{
			return null;
		}
	}

	public ImageDefComponent QuestGiverIconImageDef
	{
		get
		{
			return null;
		}
	}
}
