using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FourCrowsGame : ParlorGameBase
{
	internal class Player
	{
		internal List<FourCrowsCard> currentHand;

		internal List<FourCrowsCard> playedCards;

		internal void NewHand()
		{
		}

		internal void PlayCard(int inIndex)
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
		Deal,
		Collect,
		Turn1_dealer,
		Turn1_player,
		Turn2_dealer,
		Turn2_player,
		Turn3_dealer,
		Turn3_player,
		Turn4_dealer,
		Turn4_player,
		Reveal
	}

	public FourCrowsDeckManager deckManager;

	public FourCrowsUIManager uiManager;

	public float minMoveDistance;

	public float showWaitDeck;

	public float showWaitTree;

	public float treeGrowTime;

	public float revealWait;

	[Tooltip("Time between crows flying and break is called on the animator")]
	public float crowsFlyBranchBreaksDelay;

	[Tooltip("Time between break called on the animator and the break effect and crackle audio")]
	public float treeBreakFXDelay;

	[Tooltip("Time between the break effect and crackle audio, and the snap audio")]
	public float snapAfterCrackleAudioDelay;

	[Tooltip("Time after calling un-break on the tree animatinnbefor calling the attach audio")]
	public float branchReattachAudioDeleay;

	public Animator treeAnimator;

	public FourCrowsCrow[] theCrows;

	public ParticleSystem treeBreakEffect;

	internal bool canClickCard;

	internal bool canPlay;

	internal bool skipCompare;

	internal int _playerTurnIndex;

	internal int _dealerTurnIndex;

	internal static FourCrowsGame instance;

	internal Dealer dealer;

	internal Player player;

	private EgameState _gameState;

	private int _gameScore;

	private Vector3 _lastPosition;

	private Plane _intersectPlane;

	private Ray _dragRay;

	private Camera _camera;

	private bool _doReveal;

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

	internal Vector3 GetBoardClickPos()
	{
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(<Load>d__46))]
	internal override IEnumerator Load(int[] inAdditionalParameters)
	{
		return null;
	}

	internal override void Unload()
	{
	}

	[IteratorStateMachine(typeof(<StartGame>d__48))]
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

	private void RequestDealCards()
	{
	}

	internal override void GameResponse(ParlorGameCommand inParlorGameCommand)
	{
	}

	private void DealerResponse(ParlorGameCommand parlorGameCommand)
	{
	}

	[IteratorStateMachine(typeof(<BranchBreak>d__54))]
	private IEnumerator BranchBreak()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<Reveal>d__55))]
	internal IEnumerator Reveal(int inMultiplerResults)
	{
		return null;
	}

	internal override void MultiplierResponse(int inMultiplerResults)
	{
	}

	private void ResetTreeAndCrowsAndCardIndicators()
	{
	}

	internal void RoundOver()
	{
	}

	[IteratorStateMachine(typeof(<DealerRevealPlayedCard>d__59))]
	internal IEnumerator DealerRevealPlayedCard()
	{
		return null;
	}

	private void AfterCompare()
	{
	}

	private void ScoreCards()
	{
	}

	internal void ShowPlayerPlayIndicator(bool inShow)
	{
	}

	internal void AllCardsMoved()
	{
	}
}
