using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QueensDuelGame : ParlorGameBase
{
	internal enum EgameState
	{
		Shake1,
		Select1,
		Shake2,
		Select2,
		Reveal,
		TieShake,
		TieCompare,
		Results
	}

	public static QueensDuelGame instance;

	[Header("Managers")]
	public QueensDuelUIManager uiManager;

	public QueensDuelDiceManager diceManager;

	public GameObject[] WinLaneFX;

	public GameObject[] LoseLaneFX;

	public ParticleSystem[] dividerParticles;

	public float mistRevealWaitTime;

	public float minMoveDistance;

	public float laneFXdelay;

	internal EgameState _gameState;

	internal bool fakeServer;

	private bool[] _rowsResultsShown;

	private bool _doReveal;

	private List<int> _tieColumns;

	private ParticleSystem[][] _dividerParticles;

	private string[] _opponentRow;

	private Vector3 _lastPosition;

	private Plane _intersectPlane;

	private Ray _dragRay;

	private Camera _camera;

	private int _timesDoubledUp;

	private ParlorManager.EWinState _serverWinResults;

	private string _scoreTrack;

	private string _outFileName;

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

	[IteratorStateMachine(typeof(<StartGame>d__28))]
	internal override IEnumerator StartGame()
	{
		return null;
	}

	private void Update()
	{
	}

	internal Vector3 GetBoardClickPos()
	{
		return default(Vector3);
	}

	internal override void GameResponse(ParlorGameCommand inParlorGameCommand)
	{
	}

	private void ReceivedOpponentSelection(ParlorGameCommand parlorGameCommand)
	{
	}

	private string GetPlayerDice(int inLocatorIndex)
	{
		return null;
	}

	internal void RequestCompare()
	{
	}

	[IteratorStateMachine(typeof(<Reveal>d__35))]
	internal IEnumerator Reveal(string inResults)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<TallyScore>d__36))]
	private IEnumerator TallyScore()
	{
		return null;
	}

	internal void EnableDividerParticles(bool inEnable)
	{
	}

	internal void Setup()
	{
	}

	internal void StateUpdate()
	{
	}

	private void OpponentSelect()
	{
	}

	internal void Shake()
	{
	}

	[IteratorStateMachine(typeof(<DealerAutoRoll>d__42))]
	internal IEnumerator DealerAutoRoll()
	{
		return null;
	}

	internal void TieShake()
	{
	}

	private void TieShakeResponse(ParlorGameCommand parlorGameCommand)
	{
	}

	private void StartTieBreaker()
	{
	}

	private void TallyFinalScore()
	{
	}

	[IteratorStateMachine(typeof(<ShowRowResults>d__48))]
	private IEnumerator ShowRowResults(QueensDuelUI_ColumnScore inColumnScore, GameObject inGameObject)
	{
		return null;
	}

	private void TieChq(int inColumnIndex)
	{
	}

	internal void TallySideScore(bool inPlayer)
	{
	}

	internal override void Replay(bool inDoubleUp = false)
	{
	}

	internal override void Unload()
	{
	}

	internal override bool OverDoubleUpLimit()
	{
		return default(bool);
	}

	private void LogIt()
	{
	}
}
