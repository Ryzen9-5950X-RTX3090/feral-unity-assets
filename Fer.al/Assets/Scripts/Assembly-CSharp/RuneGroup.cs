using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.DeInspektor.Attributes;
using DG.Tweening;
using UnityEngine;

public class RuneGroup : MonoBehaviour
{
	public HexTile tilePrefab;

	public HexGrid localGrid;

	public BoxCollider boundingBox;

	public float boundingBoxPadding;

	public float rotateSpeed;

	public float dropDuration;

	[Header("FX")]
	public GameObject fxPrefabRunePlacedFlame;

	public GameObject fxPrefabRunePlacedFlora;

	public GameObject fxPrefabRunePlacedMiasma;

	private bool _isMoving;

	private Tweener _moveTween;

	private int _tileDropCounter;

	private List<HexCoord> _lastDropCoords;

	public RuneGroupType GroupType
	{
		[CompilerGenerated]
		get
		{
			return default(RuneGroupType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool CanInteract
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsBombPowerUp
	{
		get
		{
			return default(bool);
		}
	}

	private RunesGameBoard GameBoard
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

	public void CreateGroup(RuneGroupType inGroupType, RunesGameBoard inGameBoard)
	{
	}

	public void SetRuneTypes(List<RuneType> inTypes, bool doShuffle = true)
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void RotateTiles()
	{
	}

	private void UpdateBoundingBox()
	{
	}

	private void OnMouseDown()
	{
	}

	private void OnMouseUp()
	{
	}

	public bool CanDrop(HexGrid inDropOnGrid, [Optional] List<HexCoord> outDropCoords)
	{
		return default(bool);
	}

	public bool CanDropForTutorial(HexGrid inDropOnGrid, List<HexCoord> tutorialCoords)
	{
		return default(bool);
	}

	public bool CanDropAtCoord(HexGrid inDropOnGrid, HexCoord inDropCoord, [Optional] List<HexCoord> outDropCoords)
	{
		return default(bool);
	}

	public void DropOnGrid(HexGrid inDropGrid)
	{
	}

	public void DropOnGrid(HexGrid inDropGrid, RunesPlaceTileMessage inMessage)
	{
	}

	private void DropStandardRune(HexTile inTile, HexTile inDropOnTile, float inDelay = 0f)
	{
	}

	private void DropPowerUpRune(HexTile inTile, HexTile inDropOnTile, float inDelay = 0f)
	{
	}

	[IteratorStateMachine(typeof(<WaitForDrop>d__40))]
	private IEnumerator WaitForDrop(RunesPlaceTileMessage inMessage)
	{
		return null;
	}

	private void PlayRuneDropFx(HexTile inTile)
	{
	}

	public void MovePieceTo(Vector3 inPosition, float inDuration, Ease inEase = Ease.Linear)
	{
	}

	public void WaitForPlacement()
	{
	}

	public void KillTweens()
	{
	}
}
