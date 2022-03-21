using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class PongPongController : QuickGamesBase
	{
		public GameObject paddlePrefab;

		public GameObject ballPrefab;

		public GameObject playerGoal;

		public GameObject enemyGoal;

		public GameObject playerScoreTextHolder;

		public GameObject enemyScoreTextHolder;

		public float playerPaddleSpeed;

		public float enemyPaddleSpeed;

		private GameObject board;

		private Rect boardRect;

		private Rect paddleRect;

		private Rect ballRect;

		private GameObject playerPaddle;

		private GameObject enemyPaddle;

		private PongPongPaddleController playerPaddleController;

		private PongPongPaddleController enemyPaddleController;

		private GameObject ball;

		private PongPongBallController ballController;

		private Vector2 playerStartPos;

		private Vector2 enemyStartPos;

		private Vector2 ballStartPos;

		private int playerScore;

		private int enemyScore;

		private Text playerScoreText;

		private Text enemyScoreText;

		private bool isPlaying;

		private bool isResetting;

		private bool needsReset;

		public override void MStart()
		{
		}

		private void Initialize()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__31))]
		public override IEnumerator ShowResults()
		{
			return null;
		}

		private void StartRound()
		{
		}

		private void ResetGame()
		{
		}

		public void BallEnteredGoal(GameObject goal)
		{
		}

		public Vector2 CheckForPaddleForce(GameObject o)
		{
			return default(Vector2);
		}
	}
}
