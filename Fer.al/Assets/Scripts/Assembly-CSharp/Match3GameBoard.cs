using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.DeInspektor.Attributes;
using MimicJava;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityAtoms;
using UnityEngine;

public class Match3GameBoard : MonoBehaviour
{
	public enum GameBoardState
	{
		Init,
		Ready,
		Swapping,
		Matching,
		Dropping,
		Waiting,
		Done,
		OutOfMoves
	}

	public struct GameBoardMove : IEquatable<GameBoardMove>
	{
		public Match3Cell cell1;

		public Match3Cell cell2;

		private Match3TileType _cachedTileType1;

		private Match3TileType _cachedTileType2;

		public bool MoveCombinesBoosters
		{
			[IsReadOnly]
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

		public GameBoardMove(Match3Cell inCell1, Match3Cell inCell2)
		{
		}

		public bool CellPartOfMove(Match3Cell inCell)
		{
			return default(bool);
		}

		public Match3TileType GetOtherTileTypeFromMove(Match3Cell inCell)
		{
			return null;
		}

		public Match3TileType GetTileTypeFromMove(Match3Cell inCell)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(GameBoardMove move)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static bool operator ==(GameBoardMove lhs, GameBoardMove rhs)
		{
			return default(bool);
		}

		public static bool operator !=(GameBoardMove lhs, GameBoardMove rhs)
		{
			return default(bool);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RemoveCellsInMatch>d__84 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public GameBoardMatch inMatch;

		public Match3GameBoard <>4__this;

		public bool inMatchShouldAttackNeighbors;

		private string <logMatch>5__2;

		private HashSet<Match3Cell>.Enumerator <>7__wrap2;

		private Match3Cell <cell>5__4;

		private UniTask<int>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RemoveGameBoardMatches>d__85 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public Match3GameBoard <>4__this;

		private List<ValueTuple<Match3Cell, Match3Tile>> <newBoosters>5__2;

		private bool <boostersActivated>5__3;

		private float <timeWaited>5__4;

		private UniTask.Awaiter <>u__1;

		private List<UniTask<ValueTuple<Match3Tile, Vector2Int>>> <boosterTasks>5__5;

		private UniTask<int>.Awaiter <>u__2;

		private UniTask<ValueTuple<Match3Tile, Vector2Int>[]>.Awaiter <>u__3;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <HandleDoubleColorBomb>d__91 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<int> <>t__builder;

		public Match3GameBoard <>4__this;

		private int <tilesRemoved>5__2;

		private int <y>5__3;

		private int <x>5__4;

		private Match3Cell <cell>5__5;

		private UniTask<int>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <HandleColorBomb>d__92 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<int> <>t__builder;

		public Match3Tile inBoosterTile;

		public Match3GameBoard <>4__this;

		public Vector2Int inCellPos;

		private int <tilesRemoved>5__2;

		private Match3TileType <explosionType>5__3;

		private int <y>5__4;

		private int <x>5__5;

		private Match3Cell <cell>5__6;

		private UniTask<int>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <HandleTwinTrouble>d__94 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<int> <>t__builder;

		public Match3GameBoard <>4__this;

		public Vector2Int inCellPos;

		public Match3Tile inBoosterTile;

		public bool doLargeExplosion;

		private int <tilesRemoved>5__2;

		private Match3Cell <twinCell>5__3;

		private UniTask<int>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <HandleFlyer>d__95 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<int> <>t__builder;

		public Match3Tile inBoosterTile;

		public Match3GameBoard <>4__this;

		public Vector2Int inCellPos;

		public BoosterType inBoosterType;

		private int <tilesRemoved>5__2;

		private List<Match3Cell>.Enumerator <>7__wrap2;

		private Match3Cell <cell>5__4;

		private UniTask<int>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <ActivateBoosterEffect>d__96 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<ValueTuple<Match3Tile, Vector2Int>> <>t__builder;

		public Match3Tile inBoosterTile;

		public Match3GameBoard <>4__this;

		public Vector2Int inCellPos;

		private Match3TileType <inBoosterTileType>5__2;

		private Match3Tile <newBooster>5__3;

		private int <tilesRemoved>5__4;

		private int <>7__wrap4;

		private UniTask<int>.Awaiter <>u__1;

		private UniTask<int> <task1>5__6;

		private UniTask<int> <task2>5__7;

		private UniTask<ValueTuple<int, int>>.Awaiter <>u__2;

		private UniTask<int> <task3>5__8;

		private UniTask<int> <task4>5__9;

		private UniTask<int> <task5>5__10;

		private UniTask<int> <task6>5__11;

		private UniTask<ValueTuple<int, int, int, int, int, int>>.Awaiter <>u__3;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public const int TYPE_VALUE_SEPARATOR = 20;

	public Match3Grid grid;

	public Match3GridCamera gridCamera;

	public Match3GridMask gridMask;

	public Match3Tile tilePrefab;

	public float tileSwapSpeed;

	public float tileDropSpeed;

	public float dropDelayBetweenTiles;

	[Header("Tiles")]
	public List<Match3TileType> tileTypes;

	public List<Match3TileType> spawnTiles;

	public Match3TileType colorBombTileType;

	public List<Match3TileType> specialOrderTiles;

	private List<GameBoardMove> _availableMoves;

	private List<GameBoardMatch> _matches;

	[Header("Boosters")]
	public List<BoosterShapeData> boosteShapeList;

	[Header("Events")]
	public VoidEvent gameMoveCompleteEvent;

	public VoidEvent specialOrderTileRemoved;

	public VoidEvent boosterCombo_DoublePeacockEvent;

	public VoidEvent boosterCombo_PeacockTwinTroubleEvent;

	public VoidEvent boosterCombo_PeacockFlyerEvent;

	public VoidEvent boosterCombo_DoubleTwinTroubleEvent;

	public VoidEvent boosterCombo_TwinTroubleFlyerEvent;

	public VoidEvent boosterCombo_DoubleFlyerEvent;

	[Header("Temp Scoring Info")]
	public int baseMatch3Score;

	public int baseBoosterTileRemoveScore;

	public float baseBoosterMultiplier;

	[Header("DEBUG")]
	[DeDisabled("disabledMoveCountFlag", Condition.IsNullOrEmpty)]
	public int moveCount;

	[DeDisabled("disabledMoveCountFlag", Condition.IsNullOrEmpty)]
	public int turnMatchCount;

	[DeDisabled("disabledMoveCountFlag", Condition.IsNullOrEmpty)]
	public int boosterChains;

	[HideInInspector]
	public bool disabledMoveCountFlag;

	[DeButton("Undo Last Move", typeof(Match3GameBoard), "UndoLastMove", new object[] { })]
	public Match3DebugUtils match3DebugUtils;

	public bool forceGameBoardGuid;

	public string gameBoardGuid;

	private JavaRandom _randomizer;

	public ObscuredIntReference score;

	private Queue<ValueTuple<Vector2Int, Match3Tile>> _activatedBoosters;

	private List<Match3Cell> _boostersCreatedForMove;

	private Guid _gameGUID;

	private List<Match3Tile> _createdTiles;

	private List<Match3Cell> _specialOrderCellsToRemove;

	private int _droppedTileCount;

	private List<int> _cachedRandomSpawnOrderList;

	public GameBoardState BoardState
	{
		[CompilerGenerated]
		get
		{
			return default(GameBoardState);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public GameBoardMove? CurrentMove
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	public void RestartGameBoard()
	{
	}

	public void ReadyForNextMove()
	{
	}

	public void OutOfMoves()
	{
	}

	public void SaveBoardState()
	{
	}

	public void UndoLastMove()
	{
	}

	private void SetBoardState(GameBoardState inState)
	{
	}

	private void InitializeGameBoard()
	{
	}

	public int CalculateBoardChecksum()
	{
		return default(int);
	}

	public byte GridCellByteValueForChecksum(int col, int row)
	{
		return default(byte);
	}

	public Match3Tile ConvertByteToGridTile(byte b)
	{
		return null;
	}

	public void ResetBoardFromSerializedString(int inMoveCount, string inSerializedGameBoardString)
	{
	}

	private void GetPossibleMoves()
	{
	}

	private bool EitherCellBoosted(Match3Cell inCell1, Match3Cell inCell2)
	{
		return default(bool);
	}

	private bool WillSwapMakeMatch(Match3Cell inCell1, Match3Cell inCell2)
	{
		return default(bool);
	}

	private bool WillSwapMakeMatchIfType(Match3Cell inCell1, Match3TileType inCell1MatchType, Match3Cell inCell2)
	{
		return default(bool);
	}

	private void SwapCellTiles(Match3Cell cell1, Match3Cell cell2)
	{
	}

	public Match3Tile CreateTile(Match3TileType inType, bool trackCreatedTile = true)
	{
		return null;
	}

	public void ResetBoard()
	{
	}

	public void SetBoardFromTiles(List<Match3Tile> inTiles, int inMoveCount, long inRandomHashedSeed)
	{
	}

	public void MoveCellTile(Match3Cell inCell, Vector2Int inDirection)
	{
	}

	public bool CanActivateInPlace(Match3Cell inCell)
	{
		return default(bool);
	}

	public void ActivateCellInPlace(Match3Cell inCell)
	{
	}

	private BoosterType GetBoosterCombination(BoosterType inBoosterA, BoosterType inBoosterB)
	{
		return default(BoosterType);
	}

	private void DoMoveInPlace(GameBoardMove inMove)
	{
	}

	private void DoMove(GameBoardMove inMove)
	{
	}

	private void DoWrongMove(GameBoardMove inWrongMove)
	{
	}

	private bool CheckBoardForMatches()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<WaitForMove>d__77))]
	private IEnumerator WaitForMove(GameBoardMove inMove)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<WaitCombineBoostersMove>d__78))]
	private IEnumerator WaitCombineBoostersMove(GameBoardMove inMove, BoosterType comboType)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<WaitForWrongMove>d__79))]
	private IEnumerator WaitForWrongMove(float inWaitTime)
	{
		return null;
	}

	private bool FindMatch(Match3Cell inCell, Match3TileType inMatchType, List<Match3Cell> outMatchedCells, bool ignoreCellTileDistance = false)
	{
		return default(bool);
	}

	private bool HasMatchIfType(Match3Cell inCell, Match3TileType inMatchType)
	{
		return default(bool);
	}

	private bool CanMoveIfType(Match3Cell inCell, Match3TileType inMoveType)
	{
		return default(bool);
	}

	private void GetFirstMatchingFromConnection(Match3Cell inCell, Match3TileType inMatchingType, Match3CellConnection inConnection, List<Match3Cell> outMatchedCells, bool ignoreCellTileDistance = false)
	{
	}

	[AsyncStateMachine(typeof(<RemoveCellsInMatch>d__84))]
	private UniTask RemoveCellsInMatch(GameBoardMatch inMatch, bool inMatchShouldAttackNeighbors)
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(<RemoveGameBoardMatches>d__85))]
	private UniTask RemoveGameBoardMatches()
	{
		return default(UniTask);
	}

	private Match3Cell FindNextBoosterPosition(Match3Cell inCell)
	{
		return null;
	}

	private void QueueBoosterEffect(Vector2Int inCellPos, Match3Tile inBoosterTile)
	{
	}

	[IteratorStateMachine(typeof(<OnFlyerColorBombCreated>d__88))]
	private IEnumerator OnFlyerColorBombCreated(Match3TileType inTileType)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<OnTwinTroubleColorBombCreated>d__89))]
	private IEnumerator OnTwinTroubleColorBombCreated(Match3TileType inTileType)
	{
		return null;
	}

	private bool BoosterCanRemoveTile(Match3Tile inTile)
	{
		return default(bool);
	}

	[AsyncStateMachine(typeof(<HandleDoubleColorBomb>d__91))]
	private UniTask<int> HandleDoubleColorBomb(Vector2Int inCellPos)
	{
		return default(UniTask<int>);
	}

	[AsyncStateMachine(typeof(<HandleColorBomb>d__92))]
	private UniTask<int> HandleColorBomb(Vector2Int inCellPos, Match3Tile inBoosterTile)
	{
		return default(UniTask<int>);
	}

	private Match3TileType GetTileTypeWithMostTilesOnBoard()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<HandleTwinTrouble>d__94))]
	private UniTask<int> HandleTwinTrouble(Vector2Int inCellPos, Match3Tile inBoosterTile, bool doLargeExplosion)
	{
		return default(UniTask<int>);
	}

	[AsyncStateMachine(typeof(<HandleFlyer>d__95))]
	private UniTask<int> HandleFlyer(Vector2Int inCellPos, BoosterType inBoosterType, Match3Tile inBoosterTile)
	{
		return default(UniTask<int>);
	}

	[AsyncStateMachine(typeof(<ActivateBoosterEffect>d__96))]
	private UniTask<ValueTuple<Match3Tile, Vector2Int>> ActivateBoosterEffect(Vector2Int inCellPos, Match3Tile inBoosterTile)
	{
		return default(UniTask<ValueTuple<Match3Tile, Vector2Int>>);
	}

	private void DropAndSpawnTiles()
	{
	}

	private void OnTileFinishedDrop(Match3Cell inCell, bool completed)
	{
	}

	private void CheckForSpecialOrderTile(Match3Cell inCell)
	{
	}

	private bool IsSpecialOrderTile(Match3TileType inTileType)
	{
		return default(bool);
	}

	private bool RemoveSpecialOrderTiles()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<WaitForDroppedTiles>d__104))]
	private IEnumerator WaitForDroppedTiles()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<WaitForDizzyBirdScrambleTiles>d__105))]
	private IEnumerator WaitForDizzyBirdScrambleTiles()
	{
		return null;
	}

	public int GetAvailableMoveCount()
	{
		return default(int);
	}

	private List<int> GetRandomSpawnOrder()
	{
		return null;
	}

	public void CreateEggTiles(int inEggCount)
	{
	}

	public void CreateSpecialOrderTiles(int inCount)
	{
	}

	public void ScrambleTiles()
	{
	}

	private void ClearUntrackedTiles()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void DebugForceReadyNextMove()
	{
	}

	[DeMethodButton("Show Hint", 0, new object[] { })]
	public void ShowHint()
	{
	}

	[DeMethodButton("Copy Booster Shape List to Def Component", 0, new object[] { })]
	public void CopyBoosterShapeList()
	{
	}
}
