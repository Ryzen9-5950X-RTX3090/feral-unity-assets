using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ParlorUIManager : MonoBehaviour
{
	public Camera uiCamera;

	public GameObject gameHud;

	public GameObject selectGameScreen;

	public GameObject[] selectGameButtons;

	public WWTextMeshProUGUI[] selectGameButtonNames;

	public WWImage[] selectGameImages;

	public GameObject selectGameMainScreen;

	public WWTextMeshProUGUI selectGameName;

	public WWTextMeshProUGUI selectGameDescription;

	public BuildersFollyUI_Tutorial[] tutorials;

	public WWTextMeshProUGUI pot;

	public WWTextMeshProUGUI totalFunds;

	public GameObject wagerScreen;

	public TMP_InputField currentWager;

	public GameObject doubleUpScreen;

	public WWTextMeshProUGUI doubleUpDescription;

	public GameObject playAgainScreen;

	public GameObject newGameScreen;

	public GameObject exitGameScreen;

	public GameObject exitParlorScreen;

	public GameObject payoutScreen;

	public WWTextMeshProUGUI payoutAmount;

	public GameObject noFundsScreen;

	public GameObject HideDuringTutorial;

	public GameObject results;

	public WWTextMeshProUGUI resultsTXT;

	private int _wager;

	private ParlorManager _parlorManager;

	private int _selectedGameIndex;

	private int _tutorialPage;

	private bool _firstTimeTutorial_startGame;

	public float fadeInTime;

	public WWImage fadeInSceeen;

	internal static bool isTutorialWindowUp;

	internal int Wager
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal void Init()
	{
	}

	internal void ShowDoubleUp(bool inShow, bool inOverDoubleUpLimit = false)
	{
	}

	[IteratorStateMachine(typeof(<DoFadeIn>d__38))]
	internal IEnumerator DoFadeIn()
	{
		return null;
	}

	internal void ShowPlayAgain(bool inShow)
	{
	}

	internal void ShowNewGame(bool inShow)
	{
	}

	internal void ShowExitGame(bool inShow)
	{
	}

	internal void ShowExitParlor(bool inShow)
	{
	}

	private void ShowSelectGame(bool inShow)
	{
	}

	internal void ShowResults(bool inShow)
	{
	}

	[IteratorStateMachine(typeof(<Payout>d__45))]
	private IEnumerator Payout(int inPayout)
	{
		return null;
	}

	internal void ShowPayout(bool inShow, int inPayout = 0, bool inRefresh = true)
	{
	}

	internal void ShowGameHud(bool inShow)
	{
	}

	private void ShowWagerScreen(bool inShow)
	{
	}

	internal void ShowTutorial(bool inShow)
	{
	}

	private void ShowTutorialPage()
	{
	}

	public void BtnClicked_NoFundsOK()
	{
	}

	public void BtnClicked_PayoutOK()
	{
	}

	public void BtnClicked_SelectGame(int inGame)
	{
	}

	public void BtnClicked_selectGameTutorial()
	{
	}

	public void BtnClicked_TutorialNextPage()
	{
	}

	public void BtnClicked_TutorialClose()
	{
	}

	public void BtnClicked_SelectGameStart()
	{
	}

	public void WagerValidate()
	{
	}

	public void BtnClicked_WagerScreenPlaceBet()
	{
	}

	public void BtnClicked_WagerIncrease()
	{
	}

	public void BtnClicked_WagerMax()
	{
	}

	public void BtnClicked_WagerDecrease()
	{
	}

	public void BtnClicked_DoubleUp(bool inYes)
	{
	}

	public void BtnClicked_PlayAgain(bool inYes)
	{
	}

	public void BtnClicked_NewGame(bool inYes)
	{
	}

	public void BtnClicked_ExitGame(bool inYes)
	{
	}

	public void BtnClicked_ExitParlor(bool inYes)
	{
	}

	public void BtnClicked_Parlor_X()
	{
	}
}
