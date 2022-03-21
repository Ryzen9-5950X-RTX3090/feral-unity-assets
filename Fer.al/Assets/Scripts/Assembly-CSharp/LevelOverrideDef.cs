using System;
using System.Collections.Generic;

[Serializable]
public class LevelOverrideDef : BundledDef
{
	public bool isAdditive;

	public string unityLevelName;

	public string musicTrackID;

	public List<string> calendarRefs;

	public int priority;

	[NonSerialized]
	public List<AvailabilityDefComponent> _calendarDefs;

	public bool IsAvailable
	{
		get
		{
			return default(bool);
		}
	}

	public override void LoadEntry()
	{
	}
}
