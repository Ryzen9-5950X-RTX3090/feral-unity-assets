using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class MazeController : QuickGamesBase
	{
		public class MazeChunk
		{
			public List<MazeCellController> cells;

			public MazeChunk(MazeCellController cell)
			{
			}

			public void Connect(MazeChunk other)
			{
			}
		}

		private class MazeEdge
		{
			public int x;

			public int y;

			public int dx;

			public int dy;

			public int direction;

			public int opposite;

			public MazeEdge(int x, int y, int dx, int dy, int direction, int opposite)
			{
			}
		}

		public GameObject playerPrefab;

		public GameObject cellPrefab;

		public int numRows;

		public int numColumns;

		private GameObject board;

		private Rect boardRect;

		private Rect cellRect;

		private Rect playerRect;

		private RectTransform playerRectTransform;

		private MazeCellController[][] cellControllers;

		private GameObject player;

		private int playerX;

		private int playerY;

		private float playerOffsetX;

		private float playerOffsetY;

		private bool playerMoving;

		private float moveTime;

		private float elapsedMoveTime;

		private float normalizedTime;

		private Vector2 movePosA;

		private Vector2 movePosB;

		private int startX;

		private int startY;

		private int goalX;

		private int goalY;

		public override void MStart()
		{
		}

		private void Initialize()
		{
		}

		private void UpdatePlayerPos(int dx, int dy)
		{
		}

		[IteratorStateMachine(typeof(<MovePlayer>d__28))]
		private IEnumerator MovePlayer()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimatePlayerMovement>d__29))]
		private IEnumerator AnimatePlayerMovement()
		{
			return null;
		}

		public override void MUpdate()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__31))]
		public override IEnumerator ShowResults()
		{
			return null;
		}

		private void SetUpMaze()
		{
		}

		private void GenerateMaze()
		{
		}
	}
}
