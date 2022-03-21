using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class RoadCross : QuickGamesBase
	{
		public GameObject playerPrefab;

		public GameObject enemyPrefab;

		public GameObject finishLinePrefab;

		public int numEnemyRows;

		public float enemySpeed;

		private GameObject player;

		private List<List<GameObject>> enemyRows;

		private GameObject finishLine;

		private GameObject board;

		private Rect boardRect;

		private Rect enemyRect;

		private RectTransform playerRectTransform;

		private Rigidbody2D playerBody;

		private int enemyStartDirection;

		private float enemyMinX;

		private float enemyMaxX;

		private int maxEnemiesPerRow;

		private float enemyPadding;

		private float finishLineY;

		private float movementAmount;

		private bool _isMoving;

		private float _moveTime;

		private float _currentTime;

		private float _normalizedTime;

		private Vector2 _originalPos;

		private Vector2 _targetPos;

		private Vector2 _movementDir;

		public override void MStart()
		{
		}

		private void Initialize()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		private void TryMovePlayer()
		{
		}

		[IteratorStateMachine(typeof(<Move>d__31))]
		private IEnumerator Move()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateMovement>d__32))]
		private IEnumerator AnimateMovement()
		{
			return null;
		}

		private void CheckPlayerPosition()
		{
		}

		public void HandlePlayerEnemyCollision()
		{
		}

		public void HandlePlayerWin()
		{
		}
	}
}
