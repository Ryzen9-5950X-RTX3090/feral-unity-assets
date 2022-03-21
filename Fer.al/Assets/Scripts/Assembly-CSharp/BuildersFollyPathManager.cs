using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BuildersFollyPathManager
{
	internal List<BuildersFollyData.BuildersFollyPath> paths;

	private BuildersFollyTile _lastTile;

	private Vector3 _lastPathPoint;

	private Transform[] _chqPathPoints;

	private float _halfGridDist;

	private BuildersFollyTileManager _tileManager;

	private List<BuildersFollyTile> _allTiles;

	internal void SetupPaths(BuildersFollyTileManager inTileManager)
	{
	}

	internal void MakePaths()
	{
	}

	private List<BuildersFollyTile> GetSurroundingPathTiles(BuildersFollyResourceTile inBuildersFollyResourceTile)
	{
		return null;
	}

	internal bool IsPointClose(Vector3 inPoint1, Vector3 inPoint2)
	{
		return default(bool);
	}

	private void MakePath(ref BuildersFollyData.BuildersFollyPath refPath, ref BuildersFollyData.BuildersFollyPath.PathPart refPathPart, [Optional] BuildersFollyTile inFirstPathTile)
	{
	}

	private BuildersFollyGridSpot AddGridSpot(Vector3 inLastPathPoint, BuildersFollyGridSpot[] inGridSpots)
	{
		return null;
	}

	private void SynchPaths()
	{
	}
}
