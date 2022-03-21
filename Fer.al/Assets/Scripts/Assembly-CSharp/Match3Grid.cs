using UnityEngine;

public class Match3Grid : MonoBehaviour
{
	public Match3Cell cellPrefab;

	public Match3Tile tilePrefab;

	[Space]
	public Vector2Int gridSize;

	public float cellSpacing;

	private Match3Cell[,] cells;

	private static int _gridId;

	public void BuildGrid()
	{
	}

	public void ClearGrid()
	{
	}

	private void InitializeCells()
	{
	}

	private void SetupCellNeighbors()
	{
	}

	public Match3Cell GetCell(Vector2Int inCellPos)
	{
		return null;
	}

	public Match3Cell GetCell(int x, int y)
	{
		return null;
	}

	public Vector2Int WorldPosToGridPos(Vector3 inWorldPos)
	{
		return default(Vector2Int);
	}

	public Vector3 GridPosToWorldPos(Vector2Int inGridPos)
	{
		return default(Vector3);
	}

	public Vector3 GridPosToLocalPos(Vector2Int inGridPos)
	{
		return default(Vector3);
	}

	public Vector2Int LocalPosToGridPos(Vector3 inLocalPos)
	{
		return default(Vector2Int);
	}

	public Vector3 GetCenterPosition()
	{
		return default(Vector3);
	}
}
