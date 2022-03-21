using System.Collections.Generic;
using UnityEngine;

public class BuildersFollyTileManager : MonoBehaviour
{
	public BuildersFollyTile[] tiles;

	internal List<BuildersFollyTile> allTiles;

	internal List<BuildersFollyResourceTile> resourceTiles;

	internal List<BuildersFollyFixedTile> deliveryTiles;

	internal List<BuildersFollyStationTile> stationTiles;

	internal List<BuildersFollySawTrapTile> sawTrapTiles;

	internal List<BuildersFollyStationTile> CheckedForLoopingStations;

	private float _halfGridDist;

	private int _pathsOnlyXmax;

	private int _pathsOnlyZmax;

	private int _checkGridXspot;

	private int _checkGridZspot;

	private BuildersFollyTile _checkTile1;

	private BuildersFollyTile _checkTile2;

	private BuildersFollyLevel_Scriptable _currentLevelData;

	private BuildersFollyStationTile _startStation;

	private BuildersFollyGame _game;

	private void Start()
	{
	}

	internal void AddTile(BuildersFollyTile inTile)
	{
	}

	internal void RemoveTile(BuildersFollyTile inTile, float inWaitTime = 0f)
	{
	}

	public void SetPathOnlyMaxValues(int inXmax, int inZmax)
	{
	}

	public bool CheckTilesPlacement()
	{
		return default(bool);
	}

	private bool MatNearSawTile(BuildersFollyTile inCheckTile)
	{
		return default(bool);
	}

	internal void LayerChq(BuildersFollyTile inTile)
	{
	}

	internal void CanPlayChq()
	{
	}

	internal void RemoveConnectedPathsAmounts(BuildersFollyResourceTile inResourceTile)
	{
	}

	internal void SetPathTrapped(int inGridXspot, int inGridZspot)
	{
	}

	internal bool SawTrapChq(BuildersFollyTwiggle inTwiggle)
	{
		return default(bool);
	}

	internal BuildersFollyTile FindPreviousStation(BuildersFollyStationTile inSelectedStationTile, int inIndex = 0)
	{
		return null;
	}

	internal BuildersFollyTile FindPreviousStationTile(BuildersFollyTile inTile, Vector3 inPos, int inIndex)
	{
		return null;
	}

	internal void UpdateSawsMove()
	{
	}

	internal void UpdateSawUnitMove()
	{
	}

	internal bool PointChq(Vector3 inPoint1, Vector3 inPoint2, float inAdjustment = 1f)
	{
		return default(bool);
	}

	internal void LoadTile(BuildersFollyLevel_Scriptable.RowInfo[] inRowInfo, BuildersFollyGridSpot[,] inGridSpots, int inRow, int inCol)
	{
	}

	internal void RotateTile(BuildersFollyTile inTile, int inRotateTimes)
	{
	}

	internal void FlipTile(BuildersFollyTile inTile, bool inHorizontal)
	{
	}

	internal void ClearTiles(bool inClearAll = true)
	{
	}

	internal void ResetTraps()
	{
	}
}
