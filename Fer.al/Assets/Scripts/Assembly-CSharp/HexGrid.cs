using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HexGrid : MonoBehaviour
{
	public enum HexDirection
	{
		NE,
		N,
		NW,
		SW,
		S,
		SE
	}

	public int size;

	public float gridScale;

	private Dictionary<HexCoord, HexTile> tiles;

	private static readonly float SQRT_3;

	private static readonly Vector4 QR_XZ;

	private static readonly Vector4 XZ_QR;

	public static readonly HexCoord[] neighbors;

	public void CreateGrid(HexTile inTilePrefab)
	{
	}

	public void CreateGridWithCoords(HexTile inTilePrefab, List<HexCoord> inCoords)
	{
	}

	public HexTile GetTile(HexCoord inCoord)
	{
		return null;
	}

	public Vector3 HexCoordToWorldPos(HexCoord inCoord)
	{
		return default(Vector3);
	}

	public HexCoord WorldPosToHexCoord(Vector3 inWorldPos)
	{
		return default(HexCoord);
	}

	private void UpdateHexGridPositions(bool animateTilePositions = false)
	{
	}

	private void OnValidate()
	{
	}

	[IteratorStateMachine(typeof(<Neighbors>d__15))]
	public IEnumerable<HexTile> Neighbors(HexCoord inCoord)
	{
		return null;
	}

	public IEnumerable<HexTile> Neighbors(HexTile inTile)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<Tiles>d__17))]
	public IEnumerable<HexTile> Tiles()
	{
		return null;
	}

	public HexTile GetNeighbor(HexTile inTile, HexDirection inDirection)
	{
		return null;
	}

	public HexTile GetNeighbor(HexCoord inCoord, HexDirection inDirection)
	{
		return null;
	}

	public void UpdateTilesOnGrid(bool animateTilePositions = true)
	{
	}

	public void SetHighlightAtCoord(HexCoord inCoord, bool inHighlighted)
	{
	}

	public void SetOutlineAtCoord(HexCoord inCoord, bool inOutlined)
	{
	}

	public void SetPowerupAOEHighlight(HexCoord inCoord, bool inHighlighted)
	{
	}
}
