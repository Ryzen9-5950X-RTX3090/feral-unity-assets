using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class ParlorManager : CasualGame<ParlorManager>
{
	public enum EParlorGame
	{
		None,
		QueensDuel,
		FourCrows,
		MothsAndFlames,
		MoonPhases
	}

	internal enum EParlorState
	{
		SelectGame,
		PlaceWager,
		PlayGame,
		DoubleUp,
		Payout,
		PlayAgain,
		NewGame,
		ExitGame
	}

	internal enum EWinState
	{
		None,
		Player,
		Opponent,
		Tie
	}

	public Camera parlorCamera;

	public ParlorUIManager uiManager;

	public ParticleSystem gameOverWinEffect;

	public Transform kinoLocator;

	public ActorNPCSpawner kinoSpawner;

	public ParlorGameBase[] parlorGames;

	public float crystalZipAudioWait;

	public int startingWager;

	public int startingFunds;

	public bool alwaysShowTutorialFirstTime;

	internal int maxWager;

	internal ParlorGameBase currentParlorGame;

	internal bool replayingParlorGame;

	internal bool fakeServer;

	private Animator _kinoAnimator;

	internal EParlorState ParlorState;

	private int _pot;

	private int _totalFunds;

	private EWinState _winState;

	private int _currentWager;

	internal const string GameCommand = "gameCommand";

	private bool _kinoSpawned;

	internal Animator KinoAnimator
	{
		get
		{
			return null;
		}
	}

	internal int Pot
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal int TotalFunds
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal EWinState WinState
	{
		get
		{
			return default(EWinState);
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void HandleGameCommand(CasualGameCommand inMessage)
	{
	}

	public void KinoSpawned()
	{
	}

	internal void PlaceWager()
	{
	}

	private void OnMinigameMessage(ParlorGameCommand msg)
	{
	}

	private void MultiplierResults(int inMultiplyerResults)
	{
	}

	internal void SendServerMessage(string[] inData)
	{
	}

	private void GameResponse(ParlorGameCommand parlorGameCommand)
	{
	}

	internal void PlaySnap()
	{
	}

	private void SetupParlor()
	{
	}

	internal void LoadParlorGameRequest()
	{
	}

	internal void LoadParlorGameAccepted(int inMaxWager, [Optional] int[] inAdditionalParameters)
	{
	}

	internal void PlaceWagerRequest()
	{
	}

	internal void PlayAgain()
	{
	}

	private void WagerAccepted(int inAcceptedWager)
	{
	}

	internal void DoubleUpRequest(bool inAccept)
	{
	}

	private void DoubleUpResults(bool inIncreasePot)
	{
	}

	internal void ParlorGameOver()
	{
	}

	internal void UnloadParlorGame()
	{
	}

	[IteratorStateMachine(typeof(<PlayerWin>d__57))]
	internal IEnumerator PlayerWin()
	{
		return null;
	}

	internal void ExitParlor()
	{
	}

	internal void PlayEffects(ParticleSystem inParticleSystem)
	{
	}

	internal string TimeIt(string inString)
	{
		return null;
	}

	internal bool HasSeenTutorial(string inGameName)
	{
		return default(bool);
	}
}
