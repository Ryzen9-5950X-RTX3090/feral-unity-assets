using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class BuildersFollyLevel_Scriptable : ScriptableObject
{
	[Serializable]
	public class BuildersFollyGoal
	{
		public BuildersFollyResource goalResource;

		public int goalPoints;

		public BuildersFollyResource.EResourceColor dyeColor;

		[NonSerialized]
		internal ObscuredInt oldPoints;

		[NonSerialized]
		internal ObscuredInt newpoints;
	}

	[Serializable]
	public class RowInfo
	{
		public int[] columnsInfo;

		public int[] rotationInfo;
	}

	[Serializable]
	public class ResourceInfo
	{
		public BuildersFollyResource resource;

		public int startAmount;

		public int gridXspot;

		public int gridZspot;
	}

	[Serializable]
	public class FixedTileInfo
	{
		public int gridXspot;

		public int gridZspot;

		public bool turnOffTopMat;

		public bool turnOffBottomMat;

		public bool turnOffLeftMat;

		public bool turnOffRightMat;
	}

	[Header("Level Select Info")]
	public string levelName;

	public BuildersFollyData.EGridSizes gridSize;

	[Header("Goals Info")]
	public BuildersFollyGoal[] goals;

	[Header("Available Stations Info")]
	public int numberOfCutStations;

	public int numberOfSewStations;

	public int numberOfBuildStations;

	public int numberOfKilnStations;

	public int numberOfDyeStations;

	[NonSerialized]
	internal int gridXsize;

	internal int gridZsize;

	internal int levelIndex;

	public ResourceInfo[] resourceInfos;

	public FixedTileInfo[] fixedTileInfos;

	[HideInInspector]
	public RowInfo[] RowsInfo_CenterGrid;

	[HideInInspector]
	public RowInfo[] RowsInfo_CornerGrid;

	[HideInInspector]
	public RowInfo[] RowsInfo_vSideGrid;

	[HideInInspector]
	public RowInfo[] RowsInfo_hSideGrid;

	[NonSerialized]
	internal ObscuredInt highScore;

	[NonSerialized]
	internal bool isUnlocked;
}
