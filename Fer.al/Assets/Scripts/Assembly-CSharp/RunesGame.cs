using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RunesGame : CasualGame<RunesGame>
{
	[RootSelectorCompact("Casual Game Level Def Id", "LevelChartData", null, false, false)]
	public string levelDefId;

	public RunesGameBoard gameBoard;

	public RunesUI ui;

	[Header("UserVars")]
	public CachedUserVar highScoreUserVar;

	public CachedUserVar tutorialSeenUserVar;

	[Header("Debug")]
	public bool debugForceTutorial;

	private MinigameRewardDefComponent _rewardDefComponent;

	public Dictionary<string, CasualGameCommand> queuedGameCommands;

	public List<RunesReward> _runeTypeRewards;

	private const string kShownTutorialKey = "WhatTheHex_ShownTutorial";

	public Queue<MinigamePrizeSelected> queuedPrizeSelectedMessage;

	public RunesDataDefComponent gameData
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

	public bool CanShowNewPrizeSelectedIcon
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

	public bool WaitingForSpawnTileMessage
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

	public bool CanHandleGameOverMessage
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

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnMinigamePrizeGiven(MinigamePrizeGiven msg)
	{
	}

	private void OnMinigamePrizeSelected(MinigamePrizeSelected msg)
	{
	}

	public void HandlePrizeSelectedMessage(MinigamePrizeSelected msg)
	{
	}

	private void SetupGameData()
	{
	}

	public void PlayGame(bool tutorialOn)
	{
	}

	private void StartGame()
	{
	}

	public void ExitGame()
	{
	}

	public void OnGameOver()
	{
	}

	public void OnScoreUpdated(int inScore)
	{
	}

	public void OnHighScoreUpdated(long inHighScore)
	{
	}

	public void OnRuneLevelProgressUpdated(RuneType inRuneType, int inProgress, int inDeltaProgress, int inLevelThreshold, int inLevelIndex)
	{
	}

	public void OnRuneLevelUp(RuneType inRuneType, int inLevel)
	{
	}

	public void TutorialGetNextPrizeForRuneType(RuneType inRuneType, int inLevel)
	{
	}

	public void RedeemPrizeForRuneType(RuneType inRuneType, int inLevel)
	{
	}

	private int LevelToRewardIndex(RuneType inRuneType, int inLevel)
	{
		return default(int);
	}

	private int RuneTypeToIndex(RuneType inRuneType)
	{
		return default(int);
	}

	private RuneType IndexToRuneType(int inIndex)
	{
		return default(RuneType);
	}

	[CasualGameCommand("startGame")]
	private void HandleCommandGameStart(RunesGameStartMessage inMessage)
	{
	}

	[CasualGameCommand("placeTile")]
	private void HandleGameCommandPlaceTile(RunesPlaceTileMessage inMessage)
	{
	}

	[CasualGameCommand("spawnTile")]
	private void handleGameCommandSpawnTile(RunesSpawnRuneGroupMessage inMessage)
	{
	}

	[CasualGameCommand("gameOver")]
	private void HandleCommandGameOver(RunesGameOverMessage inMessage)
	{
	}

	private void SendGameCommandGameStart()
	{
	}

	public void SendGameCommandPlaceTile(int inTileIndex, HexCoord inCoord)
	{
	}

	public void SendGameCommandRotateTile(int inTileIndex)
	{
	}
}
