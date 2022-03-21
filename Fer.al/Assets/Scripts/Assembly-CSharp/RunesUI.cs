using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RunesUI : MonoBehaviour
{
	[Serializable]
	public class RuneTypeGroupUI
	{
		public Color color;

		public Color bgColor;

		public Transform scoreAnimateTo;

		public WWImage rewardBurstImage;

		[SerializeField]
		private RawImage prizeIconImage1;

		[SerializeField]
		private RawImage prizeIconImage2;

		public WWImage progressFillbarImage;

		public WWImage progressBackgroundImage;

		public WWTextMeshProUGUI progressText;

		public WWTextMeshProUGUI levelText;

		public ParticleSystem progressFx;

		public WWTextMeshProUGUI progressIncrementText;

		public string progressTweenGroupIn;

		public string progressTweenGroupOut;

		public HexTile queuedCycloneIndicator;

		private RawImage _currentPrizeIcon;

		private RawImage _nextPrizeIcon;

		public string ColorHex
		{
			get
			{
				return null;
			}
		}

		public string BgColorHex
		{
			get
			{
				return null;
			}
		}

		public int progressIncrement
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float targetProgress
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RawImage GetCurrentPrizeIconImage()
		{
			return null;
		}

		public RawImage GetNextPrizeIconImage()
		{
			return null;
		}

		public void SwapIconImages()
		{
		}

		public void ResetCurrentNextPrizeIcons()
		{
		}
	}

	public GameObject splashScreen;

	public RunesResultsScreen resultsScreen;

	public GameObject quitPopup;

	public GameObject gameHUD;

	public GameObject closeButton;

	[Space]
	public GameObject tutorialScreen;

	public List<GameObject> tutorialPages;

	[Space]
	public WWTextMeshProUGUI scoreText;

	public WWTextMeshProUGUI highScoreText;

	[Space]
	public RuneTypeGroupUI flameUI;

	public RuneTypeGroupUI floraUI;

	public RuneTypeGroupUI miasmaUI;

	[Space]
	public WWImage inventoryIcon;

	[Space]
	public RunesGame game;

	private int _tutorialPage;

	private bool _showingPopup;

	public bool IsShowingUI
	{
		get
		{
			return default(bool);
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnBackButton()
	{
	}

	public bool AnyPopupOpen()
	{
		return default(bool);
	}

	public void ShowSplashScreen()
	{
	}

	public void HideSplashScreen()
	{
	}

	public void ShowGameHUD()
	{
	}

	public void HideGameHUD()
	{
	}

	public void ShowResultsScreen(int score, List<RunesReward> inRewards, bool isProgressOnly = false)
	{
	}

	public void HideResultsScreen()
	{
	}

	public void ShowTutorialScreen()
	{
	}

	public void HideTutorialScreen()
	{
	}

	public void ShowCloseButton()
	{
	}

	public void HideCloseButton()
	{
	}

	public void BtnClicked_PlayGame()
	{
	}

	public void BtnClicked_PlayGameWithTutorial()
	{
	}

	private void DoGameStart(bool tutorialOn)
	{
	}

	public void BtnClicked_ExitGame()
	{
	}

	public void BtnClicked_ResultsExitGame()
	{
	}

	public void BtnClicked_TutorialNextPage()
	{
	}

	public void BtnClicked_TutorialGoToPage(int inPage)
	{
	}

	public void BtnClicked_TutorialOK()
	{
	}

	public void BtnClicked_ShowGameProgress()
	{
	}

	public void BtnClicked_HelpPlease()
	{
	}

	public void BtnClicked_QuitCancel()
	{
	}

	private void ShowTutorialPage(int inPage)
	{
	}

	public void SetScore(int inScore)
	{
	}

	public void SetHighScore(long inHighScore)
	{
	}

	public void SetRuneLevelProgress(RuneType inType, int inProgress, int inDeltaProgress, int inLevelThreshold, int inLevelIndex)
	{
	}

	private void SetLevelProgress(RuneTypeGroupUI inGroupUI, int inProgress, int inDeltaProgress, int inLevelThreshold, int inLevelIndex)
	{
	}

	public void ResetScoreProgressIncrementText()
	{
	}

	private void PlayLevelProgressSfx(RuneType inType)
	{
	}

	private RuneTypeGroupUI GetGroupUIFromRuneType(RuneType inRuneType)
	{
		return null;
	}

	public void SetRunePrizeIcon(RuneType inRuneType, string inItemDefId, int inCount)
	{
	}

	private void SetPrizeIcon(RuneTypeGroupUI inGroupUI, string inItemDefId, int inCount)
	{
	}

	public void ShowPrizeRewarded(RuneType inRuneType, int inLevel)
	{
	}

	public void ClearRewardsUI()
	{
	}

	public void SetQueuedCycloneVisible(RuneType inType, bool inVisible)
	{
	}

	public void ClearAllQueuedCyclones()
	{
	}

	[DeMethodButton("Test Inventory Icon Pulse", 0, new object[] { })]
	private void PulseInventoryIcon()
	{
	}
}
