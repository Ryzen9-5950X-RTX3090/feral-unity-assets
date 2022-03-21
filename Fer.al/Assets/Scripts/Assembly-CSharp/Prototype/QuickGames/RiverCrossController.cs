using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Prototype.QuickGames
{
	public class RiverCrossController : QuickGamesBase, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public GameObject instructions;

		public float instructionTime;

		public GameObject groundStartPrefab;

		public GameObject groundFinishPrefab;

		public GameObject logPrefab;

		public GameObject playerPrefab;

		public int numLogRows;

		private GameObject player;

		private GameObject groundStart;

		private GameObject groundFinish;

		private GameObject board;

		private RectTransform playerRectTransform;

		private Rigidbody2D playerBody;

		private List<List<GameObject>> logRows;

		private List<int> rowDirections;

		private int playerRow;

		private GameObject currentLog;

		private float logSpeed;

		private bool updatePlayerState;

		private bool pointerDown;

		private Vector2 pointerDownPos;

		private int _verticalDir;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__22))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void CreateLogs()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		public void OnPointerDown(PointerEventData pointerEventData)
		{
		}

		public void OnPointerUp(PointerEventData pointerEventData)
		{
		}

		public void HandlePlayerLogCollision(GameObject log)
		{
		}

		public void HandlePlayerLogExit(GameObject log)
		{
		}

		public void StartPlayerMove(int vDirection)
		{
		}

		public void FinishPlayerMove()
		{
		}

		private void UpdatePlayerState()
		{
		}

		public void PlayerReachedGoal()
		{
		}

		public void PlayerDied()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__37))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
