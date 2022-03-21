using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[ChartComponent("Level")]
public class LevelDefComponent : DefComponent
{
	[Serializable]
	public class WorldMapInfo
	{
		[ChartDef("Level", new string[] { })]
		public string level;

		[ChartString]
		public string uniqueMapId;

		[ChartEnum]
		public MinimapManager.EBlipType worldBlipType;

		[ChartDef("Localization", new string[] { })]
		public string localization;

		[ChartVector2]
		public Vector2 worldMapPosition;

		[ChartVector3]
		public Vector3 scenePosition;

		[ChartVector3]
		public Vector3 sceneRotation;
	}

	[ChartBool]
	public bool topLevel;

	[ChartBool]
	public bool isSecretArea;

	[ChartBool]
	public bool disabled;

	[ChartList]
	[ChartDef("LevelOverride", new string[] { })]
	public ChartDefList levelOverrides;

	[ChartList]
	[ChartDef("NetworkedObjects", new string[] { })]
	public ChartDefList networkedObjects;

	[ChartList]
	public List<WorldMapInfo> worldMapInfos;

	[ChartString]
	public string _unityLevelName;

	[ChartEnum]
	public ELevelType levelType;

	[ChartEnum]
	public SocialExpanseArea _socialExpanseArea;

	[ChartDef("BundleID", new string[] { })]
	public string tempImageBundleID;

	[ChartDef("Localization", new string[] { })]
	public string localizedNameID;

	[ChartDef("Calendar", new string[] { })]
	public string calendarDefID;

	private AvailabilityDefComponent _calendarDef;

	[ChartDef("BundleID", new string[] { })]
	public string minimapBundleIdRef;

	public string UnityLevelName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string FullUnityLevelName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<string> AdditiveUnityLevelNames
	{
		get
		{
			return null;
		}
	}

	public List<string> AdditiveBundleIDs
	{
		get
		{
			return null;
		}
	}

	public AvailabilityDefComponent CalendarDef
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

	public List<LevelOverrideDefComponent> CurrentOverrideDefs
	{
		get
		{
			return null;
		}
	}
}
