using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace World_Challenge.Parlor_Game.CeeLo
{
	public class CeeLoController : ParlorGame
	{
		public enum CeeLoStep
		{
			PRE_GAME,
			DEALER_PRE_ROLL,
			DEALER_ROLL,
			DEALER_ROLL_INVALID,
			DEALER_ROLL_VALID,
			DEALER_ROLL_OUT,
			SHOW_DEALER_ROLL,
			PLAYER_PRE_ROLL,
			PLAYER_ROLL,
			PLAYER_ROLL_VALID,
			PLAYER_ROLL_INVALID,
			PLAYER_ROLL_OUT,
			SHOW_PLAYER_ROLL,
			COMPARE_ROLL,
			GAME_OVER
		}

		public enum DieValue
		{
			ONE,
			TWO,
			THREE,
			FOUR,
			FIVE,
			SIX
		}

		private class PlayerState
		{
			public bool isDealer;

			public bool isRolling;

			public bool rolledOut;

			public int numRolls;

			public int maxRolls;

			public CeeLoScore score;

			public bool hasValidRoll;

			public DiceCannonController cannonController;

			public PlayerState(int maxRolls, bool isDealer)
			{
			}

			public void RollComplete(int v1, int v2, int v3)
			{
			}

			public void StartRolling()
			{
			}

			public void Update()
			{
			}

			public void Reset(bool saveScore = false, bool complete = false)
			{
			}
		}

		public class CeeLoScore
		{
			public int v1;

			public int v2;

			public int v3;

			public bool isValid;

			public bool isAutoWin;

			public bool isAutoLose;

			public bool isTriple;

			public bool rolledOut;

			private int evaluatedScore;

			public CeeLoScore(int v1, int v2, int v3)
			{
			}

			public void Update(int v1, int v2, int v3)
			{
			}

			public int GetValue()
			{
				return default(int);
			}

			public override string ToString()
			{
				return null;
			}

			private void EvaluateRoll()
			{
			}

			public static int CompareScores(CeeLoScore a, CeeLoScore b)
			{
				return default(int);
			}
		}

		public GameObject diceCannonPrefab;

		public Transform playerCannonLocator;

		public Transform dealerCannonLocator;

		public int maxRollsPerPlayer;

		public CanvasGroup hudCanvasGroup;

		public Text playerScoreText;

		public Text dealerScoreText;

		private bool updatingScore;

		private float scoreUpdateTime;

		private float elapsedScoreUpdateTime;

		private bool comparingRolls;

		private float scoreCompareTime;

		private float elapsedScoreCompareTime;

		private bool playerWon;

		private CeeLoStep currentStep;

		private PlayerState playerState;

		private PlayerState dealerState;

		private GameObject playerCannon;

		private GameObject dealerCannon;

		private int dealerScore;

		private int playerScore;

		private float revealTime;

		private float elapsedRevealTime;

		private Color startColor;

		private Color endColor;

		private Text winningText;

		private Text losingText;

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

		[IteratorStateMachine(typeof(<StartGame>d__29))]
		private IEnumerator StartGame()
		{
			return null;
		}

		private void EndGame()
		{
		}

		[IteratorStateMachine(typeof(<RevealHUD>d__33))]
		private IEnumerator RevealHUD()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<UpdateScore>d__36))]
		private IEnumerator UpdateScore(bool dealer)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateScore_Dealer>d__37))]
		private IEnumerator AnimateScore_Dealer()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateScore_Player>d__38))]
		private IEnumerator AnimateScore_Player()
		{
			return null;
		}

		private void AdvanceStep(bool isValid = true, bool isOut = false)
		{
		}

		[IteratorStateMachine(typeof(<CompareRolls>d__42))]
		private IEnumerator CompareRolls()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateScoreCompare>d__43))]
		private IEnumerator AnimateScoreCompare()
		{
			return null;
		}
	}
}
