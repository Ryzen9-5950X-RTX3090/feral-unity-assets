using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BuildersFollyData
{
	public enum EGridSizes
	{
		None,
		_6X4,
		_6X8,
		_8X4,
		_10X8,
		_12X8,
		_8X8,
		_14X8,
		_6X6,
		_8X6
	}

	public enum EGridData
	{
		None,
		PathOnly,
		Path,
		Block,
		Deliver,
		Resource,
		Station
	}

	public enum ETileTypes
	{
		None,
		FixedBlock1,
		FixedBlock2,
		FixedDeliver,
		FixedResource,
		PathStraight,
		PathCorner,
		StationBuild,
		StationKiln,
		StationCut,
		StationSew,
		StationDye,
		FixedBlock3,
		FixedStar,
		PathTool,
		FixedSawTrap2,
		FixedSawTrap3,
		FixedSawTrap4
	}

	public enum EStationType
	{
		None,
		Resource,
		Cut,
		Sew,
		Build,
		Kiln,
		Dye,
		Deliver
	}

	public enum ETileGridPlacement
	{
		Center,
		Corner,
		Side
	}

	public enum ELevelCategory
	{
		Furniture,
		Ornaments,
		SpecialAssignments,
		Holidays
	}

	internal class BuildersFollyPath
	{
		internal class PathPart
		{
			internal List<BuildersFollyGridSpot> pathGridSpots;
		}

		internal List<Vector3> path;

		internal List<BuildersFollyGridSpot> gridSpots;

		internal List<Station> stations;

		internal List<PathPart> pathParts;

		internal BuildersFollyPath()
		{
		}
	}

	internal class Station
	{
		internal enum EPortState
		{
			Empty,
			TwiggleWaiting
		}

		internal EPortState outputState;

		internal EPortState[] inputState;

		internal EStationType stationType;

		internal Station[] inputStations;

		internal Station outputStation;

		internal BuildersFollyTwiggle outputTwiggle;

		internal BuildersFollyTwiggle[] inputTwiggle;

		internal BuildersFollyTile buildersFollyTile;

		public Station()
		{
		}

		public Station(BuildersFollyTile inBuildersFollyResourceTile)
		{
		}

		public Station(BuildersFollyResource inGoalResource, [Optional] Station inOutputStation)
		{
		}
	}

	[Serializable]
	public class BuildersFollyStationData
	{
		public EStationType stationType;

		public Sprite stationIcon;

		public BuildersFollyResource[] resources;
	}

	[Serializable]
	public class BuildersFollyCameraData
	{
		public EGridSizes gridSize;

		public Vector3 positionOverride;

		public Vector3 rotationOverride;

		public float worldCratesXoverride;
	}
}
