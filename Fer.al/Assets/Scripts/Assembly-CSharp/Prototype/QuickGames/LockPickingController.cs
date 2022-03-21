using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class LockPickingController : QuickGamesBase
	{
		[Serializable]
		public struct LockPickingLevel
		{
			public GameObject centerUnlockFx;

			public GameObject lockGroup;

			public List<WWImage> locks;

			public List<GameObject> unlockFx;

			public void SetLockState(int inIndex, LockPickingController inLockPickingController, bool locked = true)
			{
			}

			[IteratorStateMachine(typeof(<SetLockStateCoroutine>d__5))]
			private IEnumerator SetLockStateCoroutine(int inIndex, LockPickingController inLockPickingController, bool locked = true)
			{
				return null;
			}

			public void ShowUnlockFx(int inIndex)
			{
			}
		}

		public bool initializeFromSettings;

		public QGEChestSettings settings;

		public NetworkedObjectInfo usePickNetworkObject;

		public ObscuredInt totalPicks;

		public GameObject pickPrefab;

		public GameObject ringPrefab;

		public GameObject levelHolderPrefab;

		public List<LockPickingLevel> levels;

		[Header("UI")]
		public Image foregroundPickHolderImage;

		public Image foregroundPickImage;

		public Image foregroundCloseButtonImage;

		public WWTextMeshProUGUI foregroundPickCountText;

		public WWButton closeButton;

		public GameObject background;

		public GameObject board;

		[SerializeField]
		private GameObject _body;

		[Header("Audio")]
		public FeralAudioInfo openGameSfx;

		public FeralAudioInfo closeGameSfx;

		public FeralAudioInfo lockPickMusic;

		public FeralAudioInfo bronzeLockpickMusic;

		public FeralAudioInfo silverLockpickMusic;

		public FeralAudioInfo goldLockpickMusic;

		public FeralAudioInfo lifeLostSfx;

		public FeralAudioInfo lockPickedSfx;

		public FeralAudioInfo fadeRingsSfx;

		public FeralAudioInfo treasureSfx;

		public List<FeralAudioInfo> ringSuccessSfx;

		public static bool IsActive;

		private RectTransform boardRectTransform;

		private GameObject locks;

		private RectTransform locksRectTransform;

		private List<GameObject> levelHolders;

		private GameObject pick;

		private LockPickingLockPickController pickController;

		private List<LockPickingRingController> ringControllers;

		private LockPickingLevel currentLevel;

		private LockPickingChestType chestType;

		private int currRingIndex;

		private GameObject oldLevelHolder;

		private GameObject backgroundCenter;

		private Image backgroundCenterImage;

		private bool levelTransitioning;

		private bool allLocksOpen;

		private bool _incrementLevelOnLevelComplete;

		private bool _incrementalRewards;

		private float _startLocksRectPosX;

		private int _currentRound;

		private FeralAudioInfo _playedMusic;

		private PlayerCameraMode _savedPlayerCameraMode;

		private int _inputBlockers;

		private Vector2 boardPosA;

		private Vector2 boardPosB;

		private float boardPanTime;

		private float elapsedTime;

		public LockPickingAssets downloadedLockPickingAssets
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

		public bool InputBlocked
		{
			get
			{
				return default(bool);
			}
		}

		public override void MStart()
		{
		}

		public override void MOnDestroy()
		{
		}

		private void OnBackButton()
		{
		}

		private void Initialize()
		{
		}

		private void InitializeFromSettings(QGEChestSettings inSettings)
		{
		}

		public void SetRingAssets(LockPickingRingModelController.RingInfo inRingInfo, int inLevelIndex, LockPickingRingController inParent, int inRingVariant, int inRingIndex)
		{
		}

		[IteratorStateMachine(typeof(<SetRingAssetsCoroutine>d__63))]
		private IEnumerator SetRingAssetsCoroutine(LockPickingRingModelController.RingInfo inRingInfo, int inLevelIndex, LockPickingRingController inParent, int inRingVariant, int inRingIndex)
		{
			return null;
		}

		private void InitializeLevelHolders()
		{
		}

		private void DownloadLevelAssets()
		{
		}

		private void AssignLevelAssets()
		{
		}

		private void InitializeLevel(LockPickingChestType inChestType)
		{
		}

		private void InitializePick()
		{
		}

		private void DestroyOldLevel()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		public void PassedRing(LockPickingRingController ringController)
		{
		}

		public int PickHitRing()
		{
			return default(int);
		}

		public void UsePick()
		{
		}

		[IteratorStateMachine(typeof(<CompleteLevel>d__74))]
		private IEnumerator CompleteLevel()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<CompleteGame>d__75))]
		private IEnumerator CompleteGame()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ShowResults>d__76))]
		public override IEnumerator ShowResults()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateLocksFading>d__77))]
		private IEnumerator AnimateLocksFading()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateBoardPan>d__82))]
		private IEnumerator AnimateBoardPan()
		{
			return null;
		}

		public void SetPickCountText(int inCount, bool doFx = true)
		{
		}

		public void BtnClicked_Close()
		{
		}

		private void OnWindowOpened(WindowOpenedMessage inMessage)
		{
		}

		private void OnWindowClosed(WindowClosedMessage inMessage)
		{
		}
	}
}
