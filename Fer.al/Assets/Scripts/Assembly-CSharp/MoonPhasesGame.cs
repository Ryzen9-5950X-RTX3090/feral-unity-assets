using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class MoonPhasesGame : ParlorGameBase
{
	internal class Player
	{
		internal enum EHandType
		{
			None,
			HighVal,
			Crescent,
			Gibbous,
			PartialFull,
			Full
		}

		private EHandType _handType;

		internal List<MoonPhasesTile> currentHand;

		internal List<MoonPhasesTile> playedTiles;

		internal int score;

		internal int tokenPositionIndex;

		internal EHandType HandType
		{
			get
			{
				return default(EHandType);
			}
			set
			{
			}
		}

		internal void NewHand()
		{
		}

		internal void PlayTile(int inIndex)
		{
		}
	}

	internal class Dealer : Player
	{
		internal int dealerPlay;

		internal void PlayTurn()
		{
		}
	}

	internal enum EgameState
	{
		DealPlayedTiles,
		DealHandTiles,
		DrawTile,
		Turn1_dealer,
		Turn1_player,
		Draw,
		Reveal,
		Collect
	}

	public MoonPhasesTokenManager tokenManager;

	public MoonPhasesTileManager tileManager;

	public MoonPhasesUIManager uiManager;

	public float minMoveDistance;

	public float showWaitDeck;

	public float revealWait;

	internal bool canClickTile;

	internal bool canPlay;

	internal bool skipCompare;

	internal int _playerTurnIndex;

	internal int _dealerTurnIndex;

	internal static MoonPhasesGame instance;

	internal Dealer dealer;

	internal Player player;

	private EgameState _gameState;

	private bool _doReveal;

	private ParlorManager.EWinState _serverWinResults;

	internal int PlayerTurnIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal int DealerTurnIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

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

	private ParlorManager.EWinState ServerWinResults
	{
		get
		{
			return default(ParlorManager.EWinState);
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(<Load>d__36))]
	internal override IEnumerator Load(int[] inAdditionalParameters)
	{
		return null;
	}

	internal override void Unload()
	{
	}

	[IteratorStateMachine(typeof(<StartGame>d__38))]
	internal override IEnumerator StartGame()
	{
		return null;
	}

	internal override void Replay(bool inDoubleUp = false)
	{
	}

	private void StartGameLoop()
	{
	}

	private void RequestDealTiles()
	{
	}

	internal void RequestScore()
	{
	}

	internal override void GameResponse(ParlorGameCommand inParlorGameCommand)
	{
	}

	private void TieResponse(ParlorGameCommand parlorGameCommand)
	{
	}

	[IteratorStateMachine(typeof(<Reveal>d__45))]
	internal IEnumerator Reveal(string inResults)
	{
		return null;
	}

	internal override void MultiplierResponse(int inMultiplerResults)
	{
	}

	[IteratorStateMachine(typeof(<TallyScore>d__47))]
	private IEnumerator TallyScore()
	{
		return null;
	}

	private void StartTieBreaker()
	{
	}

	internal void RoundOver()
	{
	}

	[IteratorStateMachine(typeof(<DealerRevealPlayedTile>d__50))]
	internal IEnumerator DealerRevealPlayedTile()
	{
		return null;
	}

	private bool IsPossible(Player inPlayer, Player.EHandType inHandType)
	{
		return default(bool);
	}

	internal void AllTilesMoved()
	{
	}
}
