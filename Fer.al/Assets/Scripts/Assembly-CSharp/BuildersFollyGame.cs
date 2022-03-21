using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.DeInspektor.Attributes;
using UnityEngine;

public class BuildersFollyGame : CasualGame<BuildersFollyGame>
{
	internal enum EGameMode
	{
		Normal,
		Expert
	}

	internal enum EgameState
	{
		splashScreen,
		tutorial,
		autoTutorial,
		levelSelect,
		design,
		running,
		paused,
		reward,
		walkthrough1,
		walkthrough2
	}

	internal enum EWalkthroughState
	{
		none,
		intro,
		showGoals,
		showResources,
		showResourceCounters,
		showLogs,
		clickToDragLogPath,
		dragLogPath,
		pressPlay1,
		building1,
		complete1,
		showCutStation,
		clickToDragStation,
		dragStation,
		showRotate,
		showFlip,
		clickToDragResourcePath,
		dragPathToStation,
		pathIntro,
		showStationInfo,
		showEditInfo,
		showInput,
		showOutput,
		showOptionArrows,
		changeOption,
		dragPathFromStationToDeliver,
		pressPlay2,
		building2,
		complete2
	}

	internal struct Reward
	{
		internal string rewardDef;

		internal int rewardCount;
	}

	public float unitMoveTime;

	internal float moveTime;

	internal float unitMoveScaler;

	[Tooltip("The number of move cycles a station takes up")]
	public int stationMoveWaits;

	internal EGameMode gameMode;

	[RootSelectorCompact("Casual Game Level Def Id", "LevelChartData", null, false, false)]
	public string levelDefId;

	public CachedUserVar levelScoresUserVar;

	public CachedUserVar expertLevelScoresUserVar;

	[Space]
	public BuildersFollyResource junkResource;

	[Header("Managers")]
	public BuildersFollyUIManager uiManager;

	public BuildersFollyGridManager gridManager;

	public BuildersFollyInputManager inputManager;

	public BuildersFollyTileManager tileManager;

	public BuildersFollyTwiggleManager twiggleManager;

	[Space]
	public BuildersFollyData_Scriptable buildersFollyData;

	public Camera gameCamera;

	public Transform worldCrates;

	[Space]
	public float fastForwardSpeed;

	public float autoContinueDelay;

	public int tutorial2Level;

	private bool _expertModeUnlocked;

	[Header("Debug")]
	public bool showDevTools;

	public int setNormalHighScoresMaxLevel;

	public int setExpertHighScoresMaxLevel;

	private bool _showDevTools;

	internal EgameState gameState;

	internal EWalkthroughState walkthrougState;

	internal bool playWalkthrough1;

	internal bool playWalkthrough2;

	internal bool _fastForward;

	internal bool fakeServer;

	internal float normalTimeScale;

	internal ObscuredInt selectedLevelIndex;

	internal ObscuredInt selectedExpertLevelIndex;

	internal ObscuredInt levelPoints;

	internal ObscuredInt serverLevelPoints;

	internal BuildersFollyPathManager pathManager;

	internal BuildersFollyLevel_Scriptable currentLevelData;

	internal Reward[] rewards;

	private bool _waitingForResponse;

	internal EgameState GameState
	{
		get
		{
			return default(EgameState);
		}
		set
		{
		}
	}

	internal EWalkthroughState WalkthrougState
	{
		get
		{
			return default(EWalkthroughState);
		}
		set
		{
		}
	}

	internal bool FastForward
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void OutputLevelGoals()
	{
	}

	private string GetLevelGoals(BuildersFollyLevel_Scriptable[] inLevels)
	{
		return null;
	}

	private string GetMismatch(string inResource, int inNeed, int inHave)
	{
		return null;
	}

	private string GetInput(BuildersFollyResource inBuildersFollyResource, string inIndent, ref List<BuildersFollyResource> refResourcesNeeded, ref List<BuildersFollyData.EStationType> refStationsNeeded)
	{
		return null;
	}

	private string GetStationMatchInfo(int inCount, BuildersFollyData.EStationType inStationType, ref List<BuildersFollyData.EStationType> refStationsNeeded)
	{
		return null;
	}

	private int GetEntry(BuildersFollyResource inBuildersFollyResource)
	{
		return default(int);
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void SetHighScores()
	{
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnMinigamePrizeGiven(MinigamePrizeGiven msg)
	{
	}

	internal void ReloadLevel()
	{
	}

	internal void SetCurrentLevel()
	{
	}

	internal void PlayWalkthrough1()
	{
	}

	internal void PlayWalkthrough2()
	{
	}

	private void InitLevels(BuildersFollyLevel_Scriptable[] inLevels, EGameMode inGameMode)
	{
	}

	[IteratorStateMachine(typeof(<StartSetup>d__69))]
	public IEnumerator StartSetup()
	{
		return null;
	}

	internal void TutorialComplete1()
	{
	}

	internal void TutorialComplete2()
	{
	}

	internal void StartPlay()
	{
	}

	internal BuildersFollyResource UpdateInfoOutput(BuildersFollyStationTile inStationTile, bool inLeft = true)
	{
		return null;
	}

	public void ExitGame()
	{
	}

	internal void SaveData()
	{
	}

	internal void LevelSetup()
	{
	}

	[IteratorStateMachine(typeof(<ResourceDelivered>d__77))]
	internal IEnumerator ResourceDelivered()
	{
		return null;
	}

	private void ClearData(BuildersFollyLevel_Scriptable.RowInfo[] inRowInfo)
	{
	}

	private void SetData(BuildersFollyLevel_Scriptable.RowInfo[] inRowInfo, BuildersFollyTile inTile)
	{
	}

	internal bool NextLevel()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<WaitForResponse>d__82))]
	private IEnumerator WaitForResponse()
	{
		return null;
	}

	public void SendGameCommandStartLevel()
	{
	}

	public void SendGameCommandRequestResults(string[] inGoalsDetails)
	{
	}

	public void SendGameCommandRequestEndLevel()
	{
	}

	[CasualGameCommand("startLevel")]
	private void HandleGameCommandLevelStart(BuildersFollyStartLevelMessage inMessage)
	{
	}

	[CasualGameCommand("endLevel")]
	private void HandleGameCommandReceiveEndLevel(BuildersFollyReceiveEndLevelMessage inMessage)
	{
	}
}
