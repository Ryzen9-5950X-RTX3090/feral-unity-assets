using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.DeInspektor.Attributes;
using UnityEngine;

public class CodeBreakerGame : CasualGame<CodeBreakerGame>
{
	[RootSelectorCompact("Casual Game Level Def Id", "LevelChartData", null, false, false)]
	public string levelDefId;

	public CodeBreakerLevelGenerator levelGenerator;

	public CodeBreakerUI ui;

	public BeetleController beetleController;

	public IngredientWheel ingredientWheel;

	public GameObject mixNoneCorrectFx;

	public GameObject mixSomeIncorrectPositionFx;

	public GameObject mixSomeCorrectPositionFx;

	public GameObject mixAllCorrectFx;

	public ObscuredInt currentLevel;

	[Header("UserVar")]
	public CachedUserVar tutorialUserVar;

	public CachedUserVar levelsUnlockedUserVar;

	public CachedUserVar levelScoresUserVar;

	private float _levelTimer;

	private bool _waitingForLevelStart;

	private Dictionary<int, bool> _seenMissMargueriteDialogs;

	private int _spawnerReadyCount;

	private int _pausedCount;

	private Code _lastGuessCode;

	[Header("Debug")]
	public int debugMaxUnlockedLevelIndex;

	public bool debugShowForcedTutorial;

	public new bool Paused
	{
		get
		{
			return default(bool);
		}
	}

	public bool HasSeenTutorial
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public long UnlockedLevelCount
	{
		get
		{
			return default(long);
		}
	}

	public Code TutorialSecretCode
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

	public int TryCount
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool LevelRunning
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool PlayerUsedDuplicates
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int LevelTimer
	{
		get
		{
			return default(int);
		}
	}

	public CodeBreakerDefComponent gameData
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

	private void Start()
	{
	}

	protected override void OnWindowOpened(WindowOpenedMessage inMessage)
	{
	}

	protected override void OnWindowClosed(WindowClosedMessage inMessage)
	{
	}

	private void Update()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void StartGame()
	{
	}

	private bool ShouldShowTutorial()
	{
		return default(bool);
	}

	public void ExitGame()
	{
	}

	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage)
	{
	}

	private void OnSpawnerReady(SpawnerReadyMessage inMessage)
	{
	}

	private void OnTryCode(TryCodeMessage inMessage)
	{
	}

	private void OnHintRecieved(Code inGuessCode, CodeHint inGuessHints)
	{
	}

	[IteratorStateMachine(typeof(<ShowAttemptFX>d__59))]
	private IEnumerator ShowAttemptFX(GameObject inAttemptFx)
	{
		return null;
	}

	private void HandleWin(int inIngredientScore, int inTimeScore, int inFirstGuessBonus, int inLastIngredientBonus)
	{
	}

	private void HandleLose(Code inSecretCode)
	{
	}

	private void OnLevelStarted(CodeBreakerLevelStartMessage inMessage)
	{
	}

	public void GoToNextLevel()
	{
	}

	public void GoToPrevLevel()
	{
	}

	public void ReplayLevel()
	{
	}

	public void RestartGame()
	{
	}

	public void GoToTutorialLevel()
	{
	}

	public void GoToLevel(int inLevelIndex)
	{
	}

	private void InternalGoToLevel(int inLevelIndex)
	{
	}

	public void GoToLevelSelect()
	{
	}

	public void ClearLevel()
	{
	}

	public void TutorialFinished()
	{
	}

	[CasualGameCommand("startLevel")]
	private void HandleGameCommandLevelStart(CodeBreakerGoToLevelMessage inMessage)
	{
	}

	[CasualGameCommand("hint")]
	private void HandleGameCommandHint(CodeBreakerHintMessage inMessage)
	{
	}

	[CasualGameCommand("endLevelWin")]
	private void HandleGameCommandLevelWin(CodeBreakerLevelWinMessage inMessage)
	{
	}

	[CasualGameCommand("endLevelLose")]
	private void HandleGameCommandLevelLose(CodeBreakerLevelLoseMessage inMessage)
	{
	}

	private void SendGameCommandStartLevel(int inLevelIndex)
	{
	}

	[IteratorStateMachine(typeof(<WaitForLevelStart>d__78))]
	private IEnumerator WaitForLevelStart()
	{
		return null;
	}

	private void SendGameCommandGuess(Code inCode)
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void DebugSetMaxUnlockedLevel()
	{
	}
}
