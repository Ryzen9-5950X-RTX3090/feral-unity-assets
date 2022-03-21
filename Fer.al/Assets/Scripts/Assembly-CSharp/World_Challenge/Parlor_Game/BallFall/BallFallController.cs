using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace World_Challenge.Parlor_Game.BallFall
{
	public class BallFallController : ParlorGame
	{
		public enum TriggerColor
		{
			YELLOW,
			RED,
			GREEN,
			BLUE
		}

		[Header("BallFall")]
		public GameObject boardPrefab;

		public GameObject ballPrefab;

		public GameObject spawnerPrefab;

		public CanvasGroup uiCanvasGroup;

		public Text yellowCount;

		public Text redCount;

		public Text greenCount;

		public Text blueCount;

		private List<GameObject> balls;

		private GameObject spawner;

		private BallFallSpawnerController spawnerController;

		private Transform spawnLocator;

		private int numBalls;

		private int ballsUsed;

		private int ballsCounted;

		private TriggerColor targetColor;

		private Dictionary<TriggerColor, int> colorCount;

		private bool isBurstDropping;

		private float burstWaitTime;

		private float elapsedTime;

		private float revealTime;

		public override void MStart()
		{
		}

		private void ResetGame(bool newGame)
		{
		}

		public override void MUpdate()
		{
		}

		internal override void Intro()
		{
		}

		internal override void ResultsDone()
		{
		}

		[IteratorStateMachine(typeof(<BurstDrop>d__25))]
		private IEnumerator BurstDrop()
		{
			return null;
		}

		private void DropBall()
		{
		}

		[IteratorStateMachine(typeof(<StartGame>d__27))]
		private IEnumerator StartGame()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<RevealUI>d__30))]
		private IEnumerator RevealUI()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<FinishGame>d__31))]
		private IEnumerator FinishGame()
		{
			return null;
		}

		public void BallEnteredTrigger(TriggerColor color)
		{
		}

		private void UpdateScoreUI()
		{
		}
	}
}
