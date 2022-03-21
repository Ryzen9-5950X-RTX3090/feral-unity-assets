using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CodeBreakerUI : MonoBehaviour
{
	public GameObject startScreen;

	public CodeBreakerLevelSelect levelSelectScreen;

	public GameObject HUD;

	public GameObject successPopup;

	public GameObject failPopup;

	public GameObject quitPopup;

	public GameObject tutorialPopup;

	public CodeBreakerTutorial forcedTutorial;

	public WWButton startButton;

	public GameObject dropButton;

	public GameObject mixButton;

	public CodeBreakerScoreUI scoreResults;

	public CodeBreakerRewardUI rewardUI;

	public Sprite levelIcon_Normal;

	public Sprite levelIcon_Red;

	public WWImage successLevelIcon;

	public WWTextMeshProUGUI successLevelText;

	public WWImage pausedLevelIcon;

	public WWTextMeshProUGUI pausedLevelText;

	public WWTextMeshProUGUI failureHintText;

	public CodeNoteUI failSecretCode;

	public GameObject codeNoteRules_DuplicatesAllowed;

	public GameObject codeNoteRules_NoDuplicatesAllowed;

	public RectTransform codeNoteRulesContainer;

	public CodeBreakerGame game;

	public CodeNoteUI codeNoteTemplate;

	public float codeNoteSpacing;

	public int maxNotesVisible;

	public CodeBreakerScroll scroll;

	public TextMeshPro timerText;

	public CodeBreakerDialogPopup dialogPopup;

	[RootSelectorCompact("Dialogs", "LocalizationChartData", null, false, false)]
	public List<string> missMargueriteDialog;

	[RootSelectorCompact("Miss M Win Dialog", "LocalizationChartData", null, false, false)]
	public string missMargueriteWinDialog;

	[RootSelectorCompact("Miss M Lose Dialog", "LocalizationChartData", null, false, false)]
	public string missMargueriteLoseDialog;

	[RootSelectorCompact("Failure Hints", "LocalizationChartData", null, false, false)]
	public List<string> failureHintStringIds;

	[RootSelectorCompact("Failure Hints", "LocalizationChartData", null, false, false)]
	public string failureHintNoDupes;

	private List<CodeNoteUI> _codeNotes;

	private List<CodeAttempt> _codeHistory;

	private float startPosY;

	private bool _showingTutorial;

	private CodeNoteUI _codeNoteNextAttempt;

	private int _pausedCount;

	private Tween _timerPausedTween;

	private float _tweenTime;

	private bool _waitingForNextCodeNote;

	private bool Paused
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

	private void OnMinigamePrizeGiven(MinigamePrizeGiven inMessage)
	{
	}

	private void OnBackButton()
	{
	}

	public void SetTimerText(float inSeconds)
	{
	}

	private void OnCodeAttempt(CodeAttemptMessage inMessage)
	{
	}

	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage)
	{
	}

	public void ShowDialog(int inDialogIndex)
	{
	}

	public void ShowWinDialog()
	{
	}

	public void ShowLoseDialog()
	{
	}

	[IteratorStateMachine(typeof(<ShowNewCodeAttempt>d__57))]
	private IEnumerator ShowNewCodeAttempt(CodeAttempt inAttempt)
	{
		return null;
	}

	public void SetNotesCodeLength(int inLength)
	{
	}

	public void SetLevelRules()
	{
	}

	public void SetLevelRulesForTutorial()
	{
	}

	private void CreateNextCodeNote()
	{
	}

	public void ClearNotes()
	{
	}

	private void RepositionNotes()
	{
	}

	public void ShowStartScreen()
	{
	}

	public void HideStartScreen()
	{
	}

	public void ShowLevelSelectScreen()
	{
	}

	public void HideLevelSelectScreen()
	{
	}

	public void ShowHUD()
	{
	}

	public void HideHUD()
	{
	}

	public void ShowResults(bool inSuccess, [Optional] Code inSecretCode, int inIngredientScore = -1, int inTimeScore = -1, int inFirstGuessBonus = -1, int inLastIngredientBonus = -1)
	{
	}

	public void HideResults()
	{
	}

	public void ShowForcedTutorial()
	{
	}

	public void HideForcedTutorial()
	{
	}

	public void ShowQuitConfirmation()
	{
	}

	public void HideQuitConfirmation()
	{
	}

	public void ShowTutorialPopup()
	{
	}

	public void HideTutorialPopup()
	{
	}

	public void BtnClicked_StartGame()
	{
	}

	public void BtnClicked_QuitConfirmation()
	{
	}

	public void BtnClicked_QuitCancel()
	{
	}

	public void BtnClicked_QuitToLevelSelect()
	{
	}

	public void BtnClicked_Quit()
	{
	}

	public void BtnClicked_LevelSelectQuit()
	{
	}

	public void BtnClicked_NextLevel()
	{
	}

	public void BtnClicked_PrevLevel()
	{
	}

	public void BtnClicked_ReplayLevel()
	{
	}

	public void BtnClicked_RestartGame()
	{
	}

	public void BtnClicked_LevelSelect()
	{
	}

	public void BtnClicked_TutorialPopup()
	{
	}

	public void BtnClicked_ExitTutorial()
	{
	}

	private int GetTotalCorrectPositionsFromNotes()
	{
		return default(int);
	}

	private int GetTotalCorrectColorsFromNotes()
	{
		return default(int);
	}

	public void HideGameplayButtons()
	{
	}

	public void ShowGameplayButtons()
	{
	}

	private void GiveRewards(int inLevel, int inStarCount, bool inHasWon3StarReward)
	{
	}

	private int DetermineReward(int inLevel, int inStar, bool inHasWon3StarReward)
	{
		return default(int);
	}
}
