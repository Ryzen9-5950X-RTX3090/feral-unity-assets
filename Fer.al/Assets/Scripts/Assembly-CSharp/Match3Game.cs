using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.DeInspektor.Attributes;
using UnityAtoms;
using UnityEngine;
using WW.Waiters;

public class Match3Game : CasualGame<Match3Game>
{
	public const int LEVEL_PRIZE_LIST_INDEX = 0;

	[RootSelectorCompact("Casual Game Level Def Id", "LevelChartData", null, false, false)]
	public string LevelDefId;

	public Match3GameBoard gameBoard;

	public Match3UI ui;

	public Match3LevelData levelData;

	public Match3LevelObjectiveTracker levelTracker;

	public PersistentAtomController persistentAtomController;

	public Match3AchievementRewardController achievementRewardController;

	[Header("UserVars")]
	public CachedUserVar tutorialSeenUserVar;

	[Header("Game Values")]
	public ObscuredIntReference playerScore;

	public ObscuredIntReference playerHighScore;

	public ObscuredIntReference totalScore;

	public ObscuredIntReference playerPowerupMeter;

	public ObscuredIntConstant powerupMax;

	public ObscuredIntConstant powerupIncrement;

	[Header("Game Events")]
	public VoidEvent startGameEvent;

	public IntEvent startLevelEvent;

	public VoidEvent powerupReadyEvent;

	public VoidEvent powerupHatchedEvent;

	public VoidEvent gameOverEvent;

	private readonly IDictionary<Match3Reward, int> _rewardsCountLookup;

	private ObscuredInt _currentLevelIndex;

	private ObscuredInt _prevPlayerScoreSent;

	private int totalGames;

	private float totalMoveCount;

	private List<int> allMoveCounts;

	private int minMoveGame;

	private int maxMoveGame;

	private string retryDefId;

	private bool _waitingForLevelCompleteFx;

	private WW.Waiters.Waiter _goToLevelWaiter;

	public bool HasShownTutorial
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public int MoveCountAverage
	{
		get
		{
			return default(int);
		}
	}

	public int MoveCountMedian
	{
		get
		{
			return default(int);
		}
	}

	public int CurrentLevelIndex
	{
		get
		{
			return default(int);
		}
	}

	public Match3DefComponent GameData
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

	public MinigameDefComponent MinigameData
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

	public bool WaitingSyncClient
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

	public Match3SyncClientMessage SyncClientMessage
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

	private void Start()
	{
	}

	public void LoadSavedValues()
	{
	}

	private void SaveSavedValues()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void StartGame()
	{
	}

	public void ExitGame()
	{
	}

	private void Update()
	{
	}

	private void UpdateUI()
	{
	}

	public void OnBoosterActivated()
	{
	}

	public void OnPowerupUsed()
	{
	}

	private void ResetPowerupMeter()
	{
	}

	public void OnScoreUpdated(ObscuredInt inCurrentScore, ObscuredInt inOldScore)
	{
	}

	public void GoToLevelIndex(int inLevelIndex, List<Match3LevelObjectiveTrackingInfo> inTrackedObjectives)
	{
	}

	private void OnScoreLevelObjectiveUpdated()
	{
	}

	public void OnGameBoardMoveComplete()
	{
	}

	private void TriggerGameOver()
	{
	}

	public void OnGameOver()
	{
	}

	public void ShowLevelProgress()
	{
	}

	[IteratorStateMachine(typeof(<DoLevelComplete>d__65))]
	private IEnumerator DoLevelComplete()
	{
		return null;
	}

	private void OnMinigamePrizeGiven(MinigamePrizeGiven message)
	{
	}

	[CasualGameCommand("startGame")]
	private void HandleCommandGameStart(Match3GameStartMessage inMessage)
	{
	}

	private bool IsReadyForLevelUp()
	{
		return default(bool);
	}

	[CasualGameCommand("goToLevel")]
	private void HandleCommandGoToLevel(Match3GoToLevelMessage inMessage)
	{
	}

	[CasualGameCommand("syncClient")]
	private void HandleCommandSyncClient(Match3SyncClientMessage inMessage)
	{
	}

	public void HandleSyncClient()
	{
	}

	public void SendGameCommandGameStart()
	{
	}

	public void SendGameCommandGameContinue()
	{
	}

	public void SendGameCommandSaveGame()
	{
	}

	public void SendGameBoardMove(Match3GameBoard.GameBoardMove inMove)
	{
	}

	public void SendHatchedDizzyBird()
	{
	}

	private string GetRetryDefId()
	{
		return null;
	}

	public int GetRetriesUsed()
	{
		return default(int);
	}

	public void SendRedeemPuzzlePiece(int puzzleIndex, int pieceIndex)
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void DebugResetHighScore()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void DebugScreenCapture()
	{
	}
}
