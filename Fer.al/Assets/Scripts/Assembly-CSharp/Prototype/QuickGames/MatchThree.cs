using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class MatchThree : QuickGamesBase
	{
		[RootSelector("Recipe", "RecipeChartData", false, false)]
		public string recipeDefId;

		public GameObject instructions;

		public GameObject cellPrefab;

		public GameObject cursorPrefab;

		public GameObject glowPrefab;

		public int numRows;

		public int numColumns;

		private GameObject board;

		private GameObject boardOverlay;

		private GameObject cursor;

		private MatchThreeCursorController cursorController;

		private Rect boardRect;

		private Rect cellRect;

		private int cursorDirection;

		private int cursorX;

		private int cursorY;

		private int checkNumber;

		private MatchThreeCellController[][] cellControllers;

		private int numStandardTypes;

		private int numSpecialTypes;

		private List<int[]> keyRoots;

		private List<MatchThreeCellController> keyControllers;

		private List<List<MatchThreeCellController>> keyDependents;

		private bool useKeyboardControls;

		private int keysCollected;

		private GameObject keyHolder;

		private GameObject keySlot_a;

		private GameObject keySlot_b;

		private GameObject keySlot_c;

		private bool _isSwapping;

		private bool _isMouseSwap;

		private float _swapTime;

		private float _currentTime;

		private float _normalizedTime;

		private Vector2 _swapPosA;

		private Vector2 _swapPosB;

		private RectTransform _swapRectA;

		private RectTransform _swapRectB;

		private int swapTargetX;

		private int swapTargetY;

		private Vector3 pendingPosition;

		private int selectionX;

		private int selectionY;

		private Vector3 selectionPos;

		private bool selecting;

		private string resultString;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__30))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		private void Initialize()
		{
		}

		private int[][] InitPrizes()
		{
			return null;
		}

		private bool Swap(int[][] state, int[][] shuffledCoords, int numMoves)
		{
			return default(bool);
		}

		private void InitCursor(float xStart, float yStart)
		{
		}

		public override void QuickGameUpdate()
		{
		}

		private void HandleKeyInput()
		{
		}

		[IteratorStateMachine(typeof(<SwapCells>d__49))]
		private IEnumerator SwapCells()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateCellMovement>d__50))]
		private IEnumerator AnimateCellMovement()
		{
			return null;
		}

		private void CheckMatches()
		{
		}

		private void CheckKeyState()
		{
		}

		public void KeyOpened(MatchThreeCellController cellController)
		{
		}

		public void CellClicked(MatchThreeCellController cellController)
		{
		}

		public void CellReleased(MatchThreeCellController cellController)
		{
		}

		private void CheckMouseMove()
		{
		}

		private MatchThreeCellController[] GetNeighbors(int x, int y)
		{
			return null;
		}

		private void CheckResults()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__64))]
		public override IEnumerator ShowResults()
		{
			return null;
		}

		private int[] Shuffle(int[] arr)
		{
			return null;
		}

		private int[][] Shuffle(int[][] arr, int l)
		{
			return null;
		}
	}
}
