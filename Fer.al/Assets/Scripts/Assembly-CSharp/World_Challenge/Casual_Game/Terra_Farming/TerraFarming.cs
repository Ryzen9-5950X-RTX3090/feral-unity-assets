using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace World_Challenge.Casual_Game.Terra_Farming
{
	public class TerraFarming : CasualGame
	{
		private struct TerrafarmingGridGroup
		{
			internal int gridGroupColorIndex;

			internal List<TerrafarmingBlock> groupBlocks;

			public TerrafarmingGridGroup(int inColorIndex, TerrafarmingBlock inBlock)
			{
			}
		}

		[Header("UI")]
		[Header("TerraFarming")]
		public CanvasGroup uiCanvasGroup;

		public Text totalScoreText;

		public Text colorsMatchedMultiplyerText;

		public Texture collectorImage;

		public Texture[] elementImages;

		public Color[] elementColors;

		public Text[] turnScoreTexts;

		public Text[] collectorTexts;

		public Text[] progressTexts;

		public RawImage[] uiImages;

		public Image[] fillImages;

		public GameObject[] collectorEarnedImages;

		[Header("Drop Blocks Spawn Info")]
		public float blockGroupInSpeed;

		public Transform[] blockGroupStarts;

		public Transform[] blockGroupEnds;

		[Header("Scoring")]
		[Tooltip("How long the totalScoreText and colorsMatchedMultiplyerText are shown. Fades out half way through.")]
		public float turnScoreShowTime;

		public int[] scoreThreshholds;

		[Header("FX")]
		public ParticleSystem[] fXBlockToScore;

		public ParticleSystem[] fXScoreBurst;

		public ParticleSystem[] fXCollectorEarned;

		public ParticleSystem[] fXBlockLinked;

		public ParticleSystem[] fXBlockCollected;

		[Header("Block Info")]
		public float blockPulseScaler;

		public float blockPulseTime;

		public float pulseDelay;

		public float blockToCollectorTime;

		[Tooltip("The distance the drop block needs to move before it will recheck the grid to see what blocks it's over, or clear the blocks it was over.")]
		public float minMoveDist;

		[Tooltip("Controls how for the drop blocks can be moved from the center of the grid.")]
		public float moveMaxX;

		[Tooltip("Controls how for the drop blocks can be moved from the center of the grid.")]
		public float moveMaxZ;

		[Tooltip("How far up the selected drop block group will raise so it doesn'tappear to clp the grid blocks when dragged.")]
		public float selectedBlockYoffset;

		[Tooltip("Controls the length of time it takes the selected drop block group to fall into place, or return to it's original spot once it's released.")]
		public float placeBlockGroupTime;

		[Tooltip("Controls how far a drop block must be from a grip block to see if it can be dropped on it.")]
		public float minBlockDistanceScaler;

		[Tooltip("How fast the drop block groups switch their positions when toggeling their colors.")]
		public float colorToggleSpeed;

		internal TerrafarmingGrid grid;

		private float _distanceToTouchPlane;

		private float _minBlockDist;

		private int[] _scoreThreshholdIndexes;

		private int[] _scores;

		private int _numColorsMatched;

		private int[] _turnScores;

		private bool _collecting;

		private int _totalScore;

		private int _nextToGridSideIndex;

		private int _nextToDroppedSideIndex;

		private Vector3 _selectionOffset;

		private Vector3 _selectedPos;

		private Vector3 _lastPos;

		private Vector3 _mousePos;

		private Vector3 _pointAlongPlane;

		private Ray _mouseScreenPointToRay;

		private Plane _touchPlane;

		private TerrafarmingBlockGroup _selectedBlockGroup;

		private Transform[] _draggableBlockGroupTransforms;

		private TerrafarmingBlockGroup[] _draggableBlockGroups;

		private List<TerrafarmingGridGroup> _gridBlockGroups;

		private List<int> _gatherBlocksEarned;

		private List<TerrafarmingBlockGroup> _blockGroupsForSpawning;

		public Queue<RuneType> queuedCycloneTiles;

		public override void Start()
		{
		}

		private void InitBlockGroups()
		{
		}

		private void ResetUI()
		{
		}

		[IteratorStateMachine(typeof(<FadeInUI>d__62))]
		private IEnumerator FadeInUI()
		{
			return null;
		}

		internal override void Intro()
		{
		}

		private void SpawnBlockGroup(int inSpawnIndex, bool inInitial = false, int inCollectorColor = -1)
		{
		}

		[IteratorStateMachine(typeof(<MoveBlockGroupToSelectionPoint>d__65))]
		private IEnumerator MoveBlockGroupToSelectionPoint(int inIndex, bool inDoGameOverCheck = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<BlockGroupOut>d__66))]
		private IEnumerator BlockGroupOut(int inIndex)
		{
			return null;
		}

		public void Update()
		{
		}

		private void CheckGrid()
		{
		}

		internal void BlockGroupSelected([Optional] TerrafarmingBlockGroup inBlockGroup)
		{
		}

		[IteratorStateMachine(typeof(<PlaceDropBlockGroup>d__70))]
		private IEnumerator PlaceDropBlockGroup(TerrafarmingBlockGroup inDropBlockGroup)
		{
			return null;
		}

		private void SetGridBlockColorsFromDropBlock(TerrafarmingBlock inDropBlock)
		{
		}

		private int AddDropBlockToGridBlockGroup(TerrafarmingBlock inDropBlock)
		{
			return default(int);
		}

		public void UpdateScore(Dictionary<RuneType, int> turnScores, int comboMultiplier, Vector3 dropPosition)
		{
		}

		private void AdjustScore(Vector3 inColorsMatchedMultiplierPos)
		{
		}

		[IteratorStateMachine(typeof(<BlockGroupPlaced>d__75))]
		private IEnumerator BlockGroupPlaced(TerrafarmingBlockGroup inDropBlockGroup)
		{
			return null;
		}

		private void QueueGatherBlock(int colorIndex)
		{
		}

		public void OnGatherBlockSpawned()
		{
		}

		private void SpawnNext(int inSpawnIndex)
		{
		}

		[IteratorStateMachine(typeof(<CollectorPulse>d__79))]
		private IEnumerator CollectorPulse(TerrafarmingBlock inCollectorBlock)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<StartCollectorPulse>d__80))]
		private IEnumerator StartCollectorPulse(TerrafarmingBlock inDropBlock)
		{
			return null;
		}

		private void SetPulseIndexes(TerrafarmingBlock inBlock, TerrafarmingGridGroup inTerrafarmingGridGroup)
		{
		}

		private bool IsGridBlockEmpty(Vector3 inGridBlockLocation)
		{
			return default(bool);
		}

		private bool IsGameOverCheck()
		{
			return default(bool);
		}

		[IteratorStateMachine(typeof(<ShowTurnScore>d__84))]
		private IEnumerator ShowTurnScore(Text inText)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<PulseCollectorText>d__85))]
		private IEnumerator PulseCollectorText(Text inText)
		{
			return null;
		}

		private bool IsNextTo(TerrafarmingBlock inGridBlock, TerrafarmingBlock inDropBlock)
		{
			return default(bool);
		}

		private bool NextToCheckAndColorSides(TerrafarmingBlock inGridBlock, TerrafarmingBlock inDropBlock)
		{
			return default(bool);
		}

		internal override void ResultsDone()
		{
		}

		[IteratorStateMachine(typeof(<CleanupAndReset>d__89))]
		private IEnumerator CleanupAndReset()
		{
			return null;
		}

		public void ResetGame()
		{
		}
	}
}
