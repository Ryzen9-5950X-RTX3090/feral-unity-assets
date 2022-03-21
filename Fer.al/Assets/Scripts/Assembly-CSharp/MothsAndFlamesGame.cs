using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MothsAndFlamesGame : ParlorGameBase
{
	internal enum EBetTypes
	{
		MMM,
		MM,
		FFF,
		FF,
		NONE
	}

	internal enum EgameState
	{
		Shake,
		Bet,
		Roll,
		Results
	}

	internal static MothsAndFlamesGame instance;

	public MothsAndFlamesUIManager uiManager;

	public MothsAndFlamesDiceManager diceManager;

	public MothsAndFlamesBetSpotManager betSpotManager;

	public MothsAndFlamesToken crystalToken;

	public Animator cupAnimator;

	public float minMoveDistance;

	public GameObject cupRevealFogFX;

	public GameObject cupTrailFX;

	private EgameState _gameState;

	private bool _skipCompare;

	private bool _draggingCrystal;

	private Vector3 _crystalTokenStartPosition;

	private Vector3 _lastPosition;

	private Vector3 _tokenClickOffset;

	private Plane _intersectPlane;

	private Ray _dragRay;

	private Camera _camera;

	private ParlorManager.EWinState _serverWinResults;

	private MothsAndFlamesBetSpot _lastBetSpot;

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

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(<Load>d__29))]
	internal override IEnumerator Load(int[] inAdditionalParameters)
	{
		return null;
	}

	internal override void Unload()
	{
	}

	[IteratorStateMachine(typeof(<StartGame>d__31))]
	internal override IEnumerator StartGame()
	{
		return null;
	}

	internal override void Replay(bool inDoubleUp = false)
	{
	}

	internal void Setup()
	{
	}

	internal Vector3 GetBoardClickPos()
	{
		return default(Vector3);
	}

	internal void BetSpotSelected()
	{
	}

	internal void RequestPlayerPlay()
	{
	}

	internal override void GameResponse(ParlorGameCommand inParlorGameCommand)
	{
	}

	internal override void MultiplierResponse(int inMultiplerResults)
	{
	}

	[IteratorStateMachine(typeof(<Reveal>d__39))]
	private IEnumerator Reveal(int inMultiplerResults)
	{
		return null;
	}

	internal void StartSelect()
	{
	}

	internal void CupHitTable()
	{
	}
}
