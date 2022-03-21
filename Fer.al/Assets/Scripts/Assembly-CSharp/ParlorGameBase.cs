using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public class ParlorGameBase : MonoBehaviour
{
	public enum EWinReplayType
	{
		DoubleUp,
		Multiplyer
	}

	[Serializable]
	public class GamePieceSpawner
	{
		public Transform gamePiece;

		public float spawnDelay;

		public float spawnTime;

		public UnityEvent OnLoaded;

		private Vector3 _baseScale;

		[IteratorStateMachine(typeof(<Spawn>d__5))]
		internal IEnumerator Spawn(float inRollOutGameBoardDelay)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<DeSpawn>d__6))]
		internal IEnumerator DeSpawn()
		{
			return null;
		}
	}

	public GameObject gameBoard;

	public Animator gameBoardAnimator;

	public Renderer gameBoardRenderer;

	public Texture gameBoardMatOverride;

	public Texture gameBoardBackOverride;

	public Material gameBoardMatMaterialOverride;

	public bool serverReady;

	public float afterWagerDelay;

	public float rollOutGameBoardDelay;

	public float compareTime;

	public ParlorManager.EParlorGame parlorGame;

	public EWinReplayType winReplayType;

	[RootSelector("Game Name", "LocalizationChartData", false, false)]
	public string gameName;

	private string _gameName;

	[RootSelector("Game Description", "LocalizationChartData", false, false)]
	public string gameDescription;

	private string _gameDescription;

	public Sprite gameSelectImage;

	[SerializeField]
	public GamePieceSpawner[] spawnedGamePieces;

	internal ParlorManager parlorManager;

	internal int scoreMultiplier;

	internal static int doubleUpsAllowed;

	private static Material _cachedGameBoardMaterial;

	internal string GameName
	{
		get
		{
			return null;
		}
	}

	internal string GameDescription
	{
		get
		{
			return null;
		}
	}

	[IteratorStateMachine(typeof(<Load>d__28))]
	internal virtual IEnumerator Load([Optional] int[] inAdditionalParameters)
	{
		return null;
	}

	internal virtual void Unload()
	{
	}

	[IteratorStateMachine(typeof(<StartGame>d__30))]
	internal virtual IEnumerator StartGame()
	{
		return null;
	}

	internal virtual void Replay(bool inDoubleUp = false)
	{
	}

	internal virtual void MultiplierResponse(int inMultiplerResults)
	{
	}

	internal virtual void GameResponse(ParlorGameCommand parlorGameCommand)
	{
	}

	internal virtual bool OverDoubleUpLimit()
	{
		return default(bool);
	}

	internal virtual ParlorManager.EWinState GetWinStateFromCommand(string inState)
	{
		return default(ParlorManager.EWinState);
	}
}
