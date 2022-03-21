using System;
using System.Collections.Generic;

[Serializable]
[ChartComponent("LevelOverride")]
public class LevelOverrideDefComponent : DefComponent
{
	[ChartBool]
	public bool isAdditive;

	[ChartString]
	public string unityLevelName;

	[ChartString]
	public string musicTrackID;

	[ChartDef("Quest", new string[] { })]
	public string socialExpanseDefId;

	[ChartList]
	[ChartString]
	public List<string> calendarRefs;

	[ChartList]
	[ChartDef("NetworkedObjects", new string[] { })]
	public ChartDefList networkedObjects;

	[NonSerialized]
	public List<AvailabilityDefComponent> _calendarDefComponents;

	public string FullUnityLevelName
	{
		get
		{
			return null;
		}
	}

	public bool IsAvailable
	{
		get
		{
			return default(bool);
		}
	}
}
