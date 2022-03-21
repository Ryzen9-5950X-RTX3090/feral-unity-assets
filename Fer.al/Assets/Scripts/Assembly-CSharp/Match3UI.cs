using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using TMPro;
using UnityAtoms;
using UnityEngine;
using UnityEngine.UI;

public class Match3UI : MonoBehaviour
{
	[Serializable]
	public class LevelObjectiveUIGroup
	{
		public WWImage icon;

		public WWTextMeshProUGUI label;

		public WWTextMeshProUGUI value;

		public Match3LevelObjectiveType currentObjectiveType
		{
			[CompilerGenerated]
			get
			{
				return default(Match3LevelObjectiveType);
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}

	public Match3Game game;

	public WWTextMeshProUGUI totalGamesText;

	public WWTextMeshProUGUI averageMovesText;

	public WWTextMeshProUGUI medianMovesText;

	public WWTextMeshProUGUI leastMovesText;

	public WWTextMeshProUGUI mostMovesText;

	public WWTextMeshProUGUI currentMoveText;

	public WWTextMeshProUGUI availableMovesText;

	public WWTextMeshProUGUI scoreText;

	public WWTextMeshProUGUI levelCountText;

	public WWTextMeshProUGUI highScoreText;

	public WWImage levelScoreFillbar;

	public WWImage powerUpFillbar;

	public ParticleSystem scoreMeterFx;

	public GameObject scoreMeterFxFloor;

	public GameObject scoreMeterFxCeiling;

	public GameObject splashScreen;

	public FeralButton newGameButton;

	public FeralButton continueGameButton;

	public GameObject powerupReady;

	public GameObject powerupDisabled;

	public GameObject hud;

	public UI_CasualGameSlideshow tutorialSlideshow;

	public Match3UI_PuzzleList puzzleList;

	public Match3UI_PuzzleGallery puzzleGallery;

	public GameObject quitConfirmation;

	public GameObject levelCompleteFx;

	public GameObject dizzyBirdActivateFx;

	public GameObject doublePeacockClearFx;

	public string levelObjectiveTweenUI;

	public GameObject singleObjectiveContainer;

	public GameObject doubleObjectiveContainer;

	public LevelObjectiveUIGroup singleObjective;

	public LevelObjectiveUIGroup doubleObjective1;

	public LevelObjectiveUIGroup doubleObjective2;

	public Match3UI_ResultsScreen resultsScreen;

	public WWTextMeshProUGUI rewardCounter;

	public Match3UI_RewardToast rewardToast;

	public Match3UI_ScoreFlashup scoreFlashup;

	public GameObject syncingPopup;

	public VoidEvent powerupUsedEvent;

	private int _unreadRewardCount;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void HideAllScreens()
	{
	}

	private void SetScreenVisible(GameObject inScreen, bool inVisible)
	{
	}

	public void HideSplashScreen()
	{
	}

	public void ShowSplashScreen()
	{
	}

	public void ShowQuitConfirmation()
	{
	}

	public void HideQuitConfirmation()
	{
	}

	public void ShowHUD()
	{
	}

	public void HideHUD()
	{
	}

	public void BtnClicked_StartGame()
	{
	}

	public void BtnClickedContinueGame()
	{
	}

	public void BtnClicked_QuitGame()
	{
	}

	public void BtnClicked_QuitConfirmation()
	{
	}

	public void BtnClicked_CancelQuitConfirmation()
	{
	}

	public void BtnClicked_Tutorial()
	{
	}

	public void BtnClicked_Puzzles()
	{
	}

	public void BtnClicked_ShowGameProgress()
	{
	}

	public void BtnClicked_UsePowerupDizzyBird()
	{
	}

	public void UpdateDebugValues(int inTotalGames, int inMoveCountAverage, int inMoveCountMedian, int inLeastMoves, int inMostMoves, int inCurrentMoves, int availableMoves, int inHighScore)
	{
	}

	public void SetLevelText(int inLevelIndex)
	{
	}

	public void OnLevelStarted(int inLevelIndex)
	{
	}

	public void OnScoreUpdated(ObscuredInt inCurrentScore)
	{
	}

	public void OnLevelScoreMeterUpdated(Match3LevelObjectiveTrackingInfo scoreTrackedObjective)
	{
	}

	private void SetScoreFill(float inFillAmount)
	{
	}

	private void UpdateScoreFxPosition()
	{
	}

	private void CompleteScoreFxPosition()
	{
	}

	public void SetPowerUpFill(ObscuredInt inPowerupMeterObscured)
	{
	}

	public void SetPowerUpFill(int inPowerupMeter)
	{
	}

	private void SetImageFill(WWImage inFillImage, float inFillAmount, [Optional] Action onUpdate, [Optional] Action onComplete)
	{
	}

	public void ShowResultsScreen(int inLevel, float inLevelProgress, int inScore, IReadOnlyDictionary<Match3Reward, int> rewardCounts, bool isGameProgress)
	{
	}

	public void GiveRewards()
	{
	}

	private int GetRewardIndex(int levelIndex)
	{
		return default(int);
	}

	private bool IsLevelInRange(int levelIndex, Match3LevelReward reward)
	{
		return default(bool);
	}

	public void ClearScoreMeter()
	{
	}

	public void ClearMeters()
	{
	}

	public void OnPowerupReady()
	{
	}

	public void OnPowerupUsed()
	{
	}

	public void PlayLevelCompleteFx()
	{
	}

	public void DisableLevelCompleteFx()
	{
	}

	public void PlayDizzyBirdActivateFx()
	{
	}

	public void StopDizzyBirdActivateFx()
	{
	}

	public void PlayDoublePeacockClearFx()
	{
	}

	public void OnBoosterComboActivated_DoublePeacock()
	{
	}

	public void SetLevelObjectiveUI(List<SpecialOrderType> inSpecialOrders, List<Match3LevelObjectiveTrackingInfo> inTrackingInfo, bool doLevelObjectiveTween)
	{
	}

	public void UpdateSpecialOrderObjectiveUI(Match3LevelObjectiveTrackingInfo inTrackingInfo)
	{
	}

	private void OnMinigamePrizeGiven(MinigamePrizeGiven inMessage)
	{
	}

	public void ShowScoreFlashup(int inScore, Color inColor, bool doMovement, Vector3 inPosition)
	{
	}

	[IteratorStateMachine(typeof(<DoScoreFlashup>d__91))]
	private IEnumerator DoScoreFlashup(int inScore, Color inColor, bool doMovement, Vector3 inPosition)
	{
		return null;
	}

	public void ShowSyncingPopup()
	{
	}

	public void HideSyncingPopup()
	{
	}
}
