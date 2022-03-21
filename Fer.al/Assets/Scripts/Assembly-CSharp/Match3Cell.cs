using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[SelectionBase]
public class Match3Cell : MonoBehaviour
{
	public Vector2Int cellPos;

	public List<GameObject> gridMarkers;

	private Dictionary<Match3CellConnection, List<Match3Cell>> _connections;

	public Match3Tile Tile
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Match3TileType TileType
	{
		get
		{
			return null;
		}
	}

	public Match3Cell North
	{
		get
		{
			return null;
		}
	}

	public Match3Cell East
	{
		get
		{
			return null;
		}
	}

	public Match3Cell South
	{
		get
		{
			return null;
		}
	}

	public Match3Cell West
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public List<Match3Cell> GetCellConnection(Match3CellConnection inConnection)
	{
		return null;
	}

	private void SetCellConnection(Match3CellConnection inConnection, List<Match3Cell> connectedList)
	{
	}

	private void SetupCellConnectionWithGrid(Match3CellConnection inConnection, Match3Grid inGrid)
	{
	}

	public void SetupAllCellConnections(Match3Grid inGrid)
	{
	}

	public bool CanBeSwapped()
	{
		return default(bool);
	}

	public bool CanMatch(bool ignoreCellTileDistance = false)
	{
		return default(bool);
	}

	public void OnCellMatched(bool attackNeighbors = true, bool clearedByPeacock = false)
	{
	}

	public void OnCellAttacked()
	{
	}

	public void SetCellPos(int x, int y)
	{
	}

	private void SetupGridMarkings()
	{
	}
}
