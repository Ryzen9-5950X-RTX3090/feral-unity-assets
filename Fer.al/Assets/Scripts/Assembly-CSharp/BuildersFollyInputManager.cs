using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BuildersFollyInputManager : MonoBehaviour
{
	internal enum ETileMode
	{
		Drag,
		Path,
		Straight,
		Corner
	}

	internal enum EDir
	{
		Left,
		Right,
		Above,
		Below,
		None
	}

	private BuildersFollyGame _game;

	public Camera gameCamera;

	public float minMoveDistance;

	public float pulseTileTime;

	public float clearTileTime;

	public float holdTime;

	public GraphicRaycaster raycaster;

	internal float minSnapWidth;

	internal ETileMode tileMode;

	private int _fastX;

	private int _fastZ;

	private int tmp;

	private int _gridXspot;

	private int _gridZspot;

	private bool _overGrid;

	private bool _pathMaking;

	private bool _startFromEntrance;

	private bool _endOnEntrance;

	private float _gridPosZ_row;

	private float _gridPosX_col;

	private Vector3 _lastPosition;

	private Vector3 _dropPoint;

	private Vector3 _dragPoint;

	private List<RaycastResult> _UIClickResults;

	private PointerEventData _pointerEventData;

	private Plane _intersectPlane;

	private Ray _dragRay;

	private BuildersFollyTileManager _tileManager;

	private BuildersFollyGridManager _gridManager;

	private BuildersFollyUIManager _uiManager;

	private BuildersFollyTile _lastTileUnderMouse;

	internal BuildersFollyTile tileUnderMouse;

	internal BuildersFollyData.ETileTypes _draggedTileType;

	internal BuildersFollyTile selectedTile;

	private bool _dragging;

	private int _pathDeleteTileIndex;

	private BuildersFollyData.ETileTypes stationButtonTileType;

	internal ETileMode TileMode
	{
		set
		{
		}
	}

	internal BuildersFollyTile LastTileUnderMouse
	{
		set
		{
		}
	}

	internal BuildersFollyData.ETileTypes DraggedTileType
	{
		get
		{
			return default(BuildersFollyData.ETileTypes);
		}
		set
		{
		}
	}

	internal BuildersFollyTile SelectedTile
	{
		set
		{
		}
	}

	private bool Dragging
	{
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetHighlight(BuildersFollyData.ETileTypes inTileType)
	{
	}

	private void MouseOver()
	{
	}

	private void ResetTrackedFields()
	{
	}

	private void MouseUp()
	{
	}

	private bool IsConnectedRight()
	{
		return default(bool);
	}

	private bool AutoConnectEnd()
	{
		return default(bool);
	}

	private BuildersFollyTile GetPotentialTile([Optional] BuildersFollyTile inTileToExclude)
	{
		return null;
	}

	private bool AutoConnectStart([Optional] BuildersFollyTile inTileToExclude)
	{
		return default(bool);
	}

	private void MouseDown()
	{
	}

	private void SwitchToPathMode()
	{
	}

	[IteratorStateMachine(typeof(<HoldChq>d__62))]
	private IEnumerator HoldChq()
	{
		return null;
	}

	private bool CanConnectToExistingPath(BuildersFollyTile inTile)
	{
		return default(bool);
	}

	private bool PathPointIsConnectedToStation(Transform inTrans, BuildersFollyStationTile inStationTile)
	{
		return default(bool);
	}

	private void FindConnectedPath(BuildersFollyTile inTile, ref List<BuildersFollyTile> refTiles)
	{
	}

	private void ClearClicked()
	{
	}

	internal void ResetInput()
	{
	}

	private void DragTile()
	{
	}

	private void DragPathMakeTileChq()
	{
	}

	private bool OtherPossibleConnection()
	{
		return default(bool);
	}

	private bool AtValidStationConnectionPoint(BuildersFollyTile inStationTile, Vector3 inPathPoint, float inAdjustment = 1f)
	{
		return default(bool);
	}

	internal void TilePathChq()
	{
	}

	private bool ValidPathChq(BuildersFollyTile inPathTile, BuildersFollyTile inStationTile, bool inForceInvalid = false)
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<NotValid>d__74))]
	private IEnumerator NotValid(BuildersFollyTile inTile)
	{
		return null;
	}

	private void FillInPaths()
	{
	}

	private void MakePathTile_Tool()
	{
	}

	private void MakePathAndReplace()
	{
	}

	private void SetClosestGridSpotWhenSelected(BuildersFollyTile inTile)
	{
	}

	private void ReplacePath(BuildersFollyData.ETileTypes inTileType, int inRotationTimes)
	{
	}

	private BuildersFollyTile MakePathTile(BuildersFollyData.ETileTypes inTileType)
	{
		return null;
	}

	private EDir GetTileDir(BuildersFollyGridSpot inSpot, BuildersFollyGridSpot inPreviousSpot)
	{
		return default(EDir);
	}

	private void SetDragPoint()
	{
	}

	private void SetDropPoint(BuildersFollyGridSpot[,] inGridPositions)
	{
	}

	internal BuildersFollyTile GetTileUnderMouse()
	{
		return null;
	}
}
