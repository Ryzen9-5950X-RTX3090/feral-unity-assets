using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class RunesGameBoard : MonoBehaviour
{
	public enum TutorialSteps
	{
		RotatePiece = 0,
		DragPiece = 1,
		ScorePiece = 2,
		ScorePowerup = 3,
		ScoreMetersReward = 4,
		CycloneTile = 5,
		PowerupTile = 6,
		EndTutorial = 7,
		None = -1
	}

	public RunesGame game;

	public HexTile runeTilePrefab;

	public RuneGroup runeGroupPrefab;

	public HexGrid runeGrid;

	public float pickUpTimer;

	public float dragThreshold;

	[Space]
	public GameObject tutorialContainer;

	[EnumList(typeof(TutorialSteps), 0.35f)]
	public List<GameObject> tutorialObjects;

	[EnumList(typeof(TutorialSteps), 0.35f)]
	public List<GameObject> tutorialUISteps;

	[Header("Spawn Points")]
	public List<RuneSpawnPoint> spawns;

	public RuneSpawnPoint tutorialSpawn;

	public Transform rightSideSpawnContainer;

	public Transform rightSideSpawnLocation4x3;

	[Header("Power Up")]
	public RuneSpawnPoint powerUpSpawn;

	public int comboLevel1;

	public int comboLevel2;

	[Range(0f, 100f)]
	public int powerUpMeter;

	public float powerUpMeterAnimSpeed;

	public float powerUpMeterTutorialAnimSpeed;

	public Animator powerUpMeterAnimator;

	[Header("FX")]
	public GameObject fxPrefabScoreMultiplier2;

	public GameObject fxPrefabScoreMultiplier4;

	public GameObject fxPrefabTileExplosion;

	public GameObject fxPrefabTileExplosionFlame;

	public GameObject fxPrefabTileExplosionFlora;

	public GameObject fxPrefabTileExplosionMiasma;

	public GameObject fxPrefabCycloneFlame;

	public GameObject fxPrefabCycloneFlora;

	public GameObject fxPrefabCycloneMiasma;

	public ParticleSystem fxPowerupReady;

	public ParticleSystem fxPowerupPickedUp;

	private RuneGroup _holdingPiece;

	private Vector3 _holdingOffset;

	private float _holdTimer;

	private bool _dragging;

	private float _originalLocation;

	private List<HexCoord> _lastCanDropCoords;

	private List<HexCoord> _lastDropCoords;

	private List<HexCoord> _lastPowerupBombHighlightCoords;

	private Plane _touchPlane;

	public Dictionary<RuneType, ObscuredInt> _levelProgressPerRuneType;

	public Dictionary<RuneType, ObscuredInt> _levelsReachedPerRuneType;

	private List<int> _scoreThresholds;

	private int _lastLevelThresholdDelta;

	private int _waitForTilesCount;

	private bool _updateHighScoreUservar;

	private Queue<RuneType> queuedCycloneTiles;

	private List<HexTile> _tempCycloneTiles;

	private List<RuneType> _standardRuneTypesList;

	public ObscuredInt Score
	{
		[CompilerGenerated]
		get
		{
			return default(ObscuredInt);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public ObscuredLong HighScore
	{
		[CompilerGenerated]
		get
		{
			return default(ObscuredLong);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsPowerupMeterAnimating
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

	public bool CanPickPieceUp
	{
		get
		{
			return default(bool);
		}
	}

	public bool TutorialOn
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

	public TutorialSteps TutorialStep
	{
		[CompilerGenerated]
		get
		{
			return default(TutorialSteps);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public TutorialSteps NextTutorialStep
	{
		[CompilerGenerated]
		get
		{
			return default(TutorialSteps);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private void Start()
	{
	}

	public void SetGameData(RunesDataDefComponent inGameData)
	{
	}

	private int GetLevelThreshold(int inLevelIndex)
	{
		return default(int);
	}

	public void ResetBoard()
	{
	}

	public void SpawnTutorial()
	{
	}

	public void SpawnFromStart(List<RuneGroupType> inGroupTypes, List<List<RuneType>> inGroupRunes)
	{
	}

	private void Update()
	{
	}

	private void UpdateTutorial()
	{
	}

	private void UpdateBoard()
	{
	}

	private void CheckForLoseCondition()
	{
	}

	public void DoGameOverSequence()
	{
	}

	private void GameOver()
	{
	}

	private void ClearScores()
	{
	}

	public void ClearBoard()
	{
	}

	public void OnRuneGroupPressed(RuneGroup inGroup)
	{
	}

	private void PlayPickedUpSfxForRuneGroup(RuneGroup inGroup)
	{
	}

	private int GetSpawnIndexFromRuneGroup(RuneGroup inRuneGroup)
	{
		return default(int);
	}

	public void OnRuneGroupReleased(RuneGroup inGroup)
	{
	}

	private void ReturnRunePiecesToSpawnPoints(RuneGroup inGroup)
	{
	}

	private RuneGroup GetRuneGroupFromIndex(int inIndex)
	{
		return null;
	}

	public void RuneGroupPlacedResponse(RunesPlaceTileMessage inMessage)
	{
	}

	public void RuneGroupSpawnResponse(RunesSpawnRuneGroupMessage inMessage)
	{
	}

	public void OnRunePiecePlaced(List<HexCoord> inDropCoords, RuneGroup inDroppedPiece, RunesPlaceTileMessage inMessage)
	{
	}

	private void OnTileScored(HexTile inTile)
	{
	}

	private void AddTotalScore(int inScore)
	{
	}

	private void OnCycloneRunePlaced(HexTile inCycloneTile)
	{
	}

	private void OnCycloneRuneCollected(HexTile inCycloneTile, int inNewTileScore)
	{
	}

	private void OnPowerUpBombPlaced(HexTile inBombTile)
	{
	}

	private List<HexTile> FindConnectedTiles(HexTile inTile, bool includeSelf = true)
	{
		return null;
	}

	public void ReplaceDroppedPiece(int inSpawnIndex, RunesSpawnRuneGroupMessage inMessage)
	{
	}

	private RuneGroup CreateRunePiece()
	{
		return null;
	}

	private RuneGroup CreateRunePiece(RuneGroupType inGroupType, List<RuneType> inGroupRunes)
	{
		return null;
	}

	private RuneGroup CreatePowerUpRunePiece(RuneType inPowerUpType)
	{
		return null;
	}

	private RuneGroup CreateTutorialPiece(TutorialSteps inTutorialStep)
	{
		return null;
	}

	private void IncreasePowerUpMeterValue(int inIncrease)
	{
	}

	private void OnPowerUpMeterFull()
	{
	}

	private void UpdatePowerUpMeter(bool forceUpdate = false)
	{
	}

	public static RuneType ConvertCycloneToStandardType(RuneType inCycloneType)
	{
		return default(RuneType);
	}

	public static RuneType ConvertStandardToCycloneType(RuneType inStandardType)
	{
		return default(RuneType);
	}

	private void AddLevelReached(RuneType inRuneType)
	{
	}

	private void ExplodeTile(HexTile inTile)
	{
	}

	private void ActivatePowerUpFx()
	{
	}

	private void DeactivatePowerUpFx(bool inPickedup)
	{
	}

	private void GoToTutorialStep(TutorialSteps inStep, float inTransitionDelay = 0f)
	{
	}

	private void HandleCleanupStep(TutorialSteps inStep)
	{
	}

	private void HandleSetupStep(TutorialSteps inStep)
	{
	}

	private void SpawnTutorialPieceForStep(TutorialSteps inStep)
	{
	}

	private bool CanPlacePieceInTutorialStep(TutorialSteps inStep)
	{
		return default(bool);
	}

	private List<HexCoord> GetDropCoordsForTutorialStep(TutorialSteps inStep)
	{
		return null;
	}

	private void SetTutorialStepActive(TutorialSteps inTutorialStep, bool inActive)
	{
	}

	private void ClearTutorialObjects()
	{
	}
}
