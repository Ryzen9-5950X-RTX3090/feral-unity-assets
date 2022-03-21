using System.Collections.Generic;
using UnityEngine;

public class BuildersFollyGridManager : MonoBehaviour
{
	public BuildersFollyGridSpot gridSpot;

	internal float gridStart_X;

	internal float gridStart_Z;

	internal float gridSize;

	internal BuildersFollyGridSpot[,] gridSpots_center;

	internal BuildersFollyGridSpot[,] gridSpots_corner;

	internal BuildersFollyGridSpot[,] gridSpots_vSide;

	internal BuildersFollyGridSpot[,] gridSpots_hSide;

	private float _currentRowPos;

	private float _currentColPos;

	private float _gridPosZ_row;

	private float _gridPosX_col;

	private List<GameObject> _buildersFollyGridSpots;

	private BuildersFollyLevel_Scriptable _currentLevelData;

	private BuildersFollyTileManager _tileManager;

	private BuildersFollyGame _game;

	private void Start()
	{
	}

	public void SetupGrid()
	{
	}

	internal void SetupGrids()
	{
	}

	private void AdjustMats(List<BuildersFollyFixedTile> inTiles)
	{
	}

	private void EdgeChq(BuildersFollyFixedTile inTile)
	{
	}

	private BuildersFollyInputManager.EDir GetDir(BuildersFollyGridSpot inSpot1, BuildersFollyGridSpot inSpot2)
	{
		return default(BuildersFollyInputManager.EDir);
	}

	internal void SetTileGridSpots(BuildersFollyTile inSelectedTile)
	{
	}

	internal void ClearGrid()
	{
	}

	internal void ResetGrid(BuildersFollyLevel_Scriptable inLevelData)
	{
	}
}
