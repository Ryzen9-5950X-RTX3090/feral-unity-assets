using System;
using System.Collections.Generic;

[Serializable]
[ChartComponent("Quest")]
public class QuestDefComponent : DefComponent
{
	[Serializable]
	public class ObjectiveList
	{
		[ChartList]
		public List<QuestDefObjective> objectives;
	}

	[ChartBool]
	public bool disabled;

	[ChartEnum]
	public QuestDifficultyLevel difficultyLevel;

	[ChartBool]
	public bool isPlatformer;

	[ChartBool]
	public bool playAsPet;

	[ChartBool]
	public bool noLobby;

	[ChartDef("Localization", new string[] { })]
	public string locTitleDefID;

	private LocalizationDef _locTitleDef;

	[ChartDef("Localization", new string[] { })]
	public string locDescriptionDefID;

	private LocalizationDef _locDescriptionDef;

	[ChartDef("Localization", new string[] { })]
	public string locLocationDefID;

	private LocalizationDef _locLocationDef;

	[ChartDef("Localization", new string[] { })]
	public string locGiverNameDefID;

	private LocalizationDef _locGiverNameDef;

	[ChartList]
	[ChartDef("Level", new string[] { })]
	public ChartDefList baseRooms;

	[ChartList]
	public List<QuestDefObjective> primaryObjectives;

	[ChartList]
	public List<ObjectiveList> secondaryObjectiveLists;

	[ChartInt]
	public int minPlayers;

	[ChartInt]
	public int maxPlayers;

	[ChartDef("Image", new string[] { })]
	public string iconImageDefId;

	private ImageDefComponent _iconImageDef;

	[ChartDef("Image", new string[] { })]
	public string gameImageDefId;

	private ImageDefComponent _gameImageDef;

	[ChartDef("Image", new string[] { })]
	public string bannerImageDefId;

	private ImageDefComponent _bannerImageDef;

	[ChartDef("Loot", new string[] { })]
	public string allCompleteLootDefId;

	private LootDefComponent _allCompleteLootDef;

	[ChartEnum]
	public ChallengeAffiliation challengeAffiliation;

	[ChartString]
	public string summaryJson;

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

	public LocalizationDef LocLocation
	{
		get
		{
			return null;
		}
	}

	public LocalizationDef LocGiverName
	{
		get
		{
			return null;
		}
	}

	public ImageDefComponent IconImage
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

	public ImageDefComponent BannerImage
	{
		get
		{
			return null;
		}
	}

	public LootDefComponent AllCompleteLoot
	{
		get
		{
			return null;
		}
	}
}
