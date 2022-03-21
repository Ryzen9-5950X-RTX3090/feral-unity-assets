using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildersFollyUIManager : MonoBehaviour
{
	public Camera uICamera;

	public Canvas hudCanvas;

	public Color starColorFilled;

	public Color starColorUnfilled;

	public Color UIBlue;

	public Color buttonColorHighlighted;

	public Color buttonColorNormal;

	public Color rewardsColorMystery;

	public float infoPopUpTime;

	public float starPulseTime;

	public float starPulseScale;

	[Space]
	public BuildersFollyUI_Tutorial tutorialScreen;

	public BuildersFollyUI_Tutorial tutorialExpertScreen;

	[Space]
	public GameObject splashScreen;

	public BuildersFollyUI_LevelSelect levelSelectScreen;

	public GameObject gameHUD;

	public GameObject rewardScreen;

	public GameObject exitGame;

	public GameObject exitGameGuidedButtonsBlocker;

	public GameObject exitGameResetButtonBlocker;

	public GameObject HideDuringGameplay;

	public GameObject devTools;

	public GameObject infoWindow;

	public GameObject infoWindowDeleteStation;

	public GameObject playButton;

	public GameObject fastForwardButton_normal;

	public GameObject fastForwardButton_active;

	[Space]
	public GameObject cutStationButtonMask;

	public GameObject sewStationButtonMask;

	public GameObject buildStationButtonMask;

	public GameObject kilnStationButtonMask;

	public GameObject dyeStationButtonMask;

	public UI_ColorizedIcon cutStationIcon;

	public UI_ColorizedIcon sewStationIcon;

	public UI_ColorizedIcon buildStationIcon;

	public UI_ColorizedIcon kilnStationIcon;

	public UI_ColorizedIcon dyeStationIcon;

	public Rectangle cutStationBKG;

	public Rectangle sewStationBKG;

	public Rectangle buildStationBKG;

	public Rectangle kilnStationBKG;

	public Rectangle dyeStationBKG;

	[Space]
	public float goalsListSpaceing;

	public GameObject goalsList;

	public RectTransform goalsListBKG;

	public BuildersFollyUI_GoalListItem goalsListItem;

	[Space]
	public Sprite resourceImage_NONE;

	public WWTextMeshProUGUI infoWindow_name;

	public GameObject infoWindow_stationInfo;

	public WWTextMeshProUGUI infoWindow_inputInfo;

	public WWImage infoWindow_inputImage;

	public WWTextMeshProUGUI infoWindow_outputInfo;

	public WWImage infoWindow_outputImage;

	public GameObject infoWindow_stationOptions;

	public GameObject infoWindow_colorOptions;

	public UI_ColorizedIcon infoWindow_colorIndicator;

	public WWButton[] infoWindow_colors;

	public GameObject infoWindow_buildStationInfo;

	public WWTextMeshProUGUI infoWindow_buildStationInputInfo1;

	public WWImage infoWindow_buildStationInputImage1;

	public WWTextMeshProUGUI infoWindow_buildStationInputInfo2;

	public WWImage infoWindow_buildStationInputImage2;

	public WWTextMeshProUGUI infoWindow_buildStationOutputInfo;

	public WWImage infoWindow_buildStationOutputImage;

	public GameObject infoWindow_resourceInfo;

	public WWImage infoWindow_resourceImage;

	public WWTextMeshProUGUI infoWindow_resourceDescription;

	[Space]
	public GameObject rewardScreenTitle_PickReward;

	public GameObject rewardScreenTitle_NoStars;

	public GameObject rewardScreenNextLevelButtonInactive;

	public GameObject rewardScreenFinishedOptions;

	public UI_ColorizedIcon rewardTierHalfStar;

	public UI_ColorizedIcon rewardTier1Star;

	public UI_ColorizedIcon rewardTier1HalfStar;

	public UI_ColorizedIcon rewardTier2Star;

	public UI_ColorizedIcon rewardTier2HalfStar;

	public UI_ColorizedIcon rewardTier3Star;

	public TextMeshProUGUI rewardsTier1Text;

	public TextMeshProUGUI rewardsTier2Text;

	public TextMeshProUGUI rewardsTier3Text;

	public RawImage rewardsTier1Image;

	public RawImage rewardsTier2Image;

	public RawImage rewardsTier3Image;

	public UI_ColorizedIcon reward1ImageFill;

	public UI_ColorizedIcon reward2ImageFill;

	public UI_ColorizedIcon reward3ImageFill;

	[Space]
	public GameObject broomPopUp;

	public RectTransform pathDelete;

	public GameObject tut_intro;

	public GameObject tut_showGoals;

	public GameObject tut_showResources;

	public GameObject tut_showResourceCounters;

	public GameObject tut_showLogs;

	public GameObject tut_clickDragLogPathOBJ;

	public GameObject tut_clickDragLogPath;

	public GameObject tut_clickPlay1;

	public GameObject tut_tutorialComplete1;

	public GameObject tut_showCutStation;

	public GameObject tut_clickDragStation;

	public GameObject tut_dragStationOBJ;

	public GameObject tut_showRotate;

	public GameObject tut_showFlip;

	public GameObject tut_clickDragResource;

	public GameObject tut_dragResourcePathOBJ;

	public GameObject tut_showStationInfo;

	public GameObject tut_showInput;

	public GameObject tut_showOutput;

	public GameObject tut_showOptionArrows;

	public GameObject tut_drawNextPath;

	public GameObject tut_dragStationPathOBJ;

	public GameObject tut_clickPlay2;

	public GameObject tut_tutorialComplete2;

	public GameObject tileEditButtons;

	public GameObject stationOptionButtons;

	public WWTextMeshProUGUI levelName;

	public RectTransform resourceBKG;

	public BuildersFollyUI_ResoureDisplay resourceDisplay;

	public float resourceXpadding;

	public float resourceFrameXpadding;

	public GameObject recipeWindow;

	public GameObject recipeWindowBackButton;

	public BuildersFollyUI_Recipe buildRecipe;

	public BuildersFollyUI_Recipe stationRecipe;

	public BuildersFollyUI_Recipe resourceRecipe;

	public GameObject expertButton;

	internal BuildersFollyTile infoTile;

	internal List<BuildersFollyUI_ResoureDisplay> resoureDisplayList;

	private Sprite _buildStationSprite;

	private Sprite _cutStationSprite;

	private Sprite _sewStationSprite;

	private Sprite _kilnStationSprite;

	private List<BuildersFollyUI_GoalListItem> _goalsLists;

	private List<BuildersFollyResource> _recipeResources;

	private RectTransform _canvasRect;

	private Vector3 _infoPopUpEndScale;

	private Vector3 _infoPopUpEndPosition;

	private Vector3 _rewardTierStarStartScale;

	private bool _autoLevelSelect;

	private bool _autoExit;

	private int _tutorialPage;

	private float _goalsListBKGHieght;

	private BuildersFollyGame.EgameState _cachedGameState;

	private BuildersFollyInputManager.ETileMode _priorTileMode;

	private BuildersFollyStationTile _selectedStation;

	private Texture _cachedMysteryTexture;

	private BuildersFollyGame _game;

	private BuildersFollyInputManager _inputManager;

	internal void Init()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnBackButton()
	{
	}

	private void InitGoalsList()
	{
	}

	internal void UpdateGoalListStars()
	{
	}

	internal void InitResources()
	{
	}

	internal void UpdateResourcesAmount()
	{
	}

	private void ShowSplashScreen(bool inShow)
	{
	}

	internal void ShowInfoWindow(bool inShow, [Optional] BuildersFollyTile inTile)
	{
	}

	private void DyeStationColorSet(BuildersFollyTile inDyeStationTile)
	{
	}

	internal string GetColorText(BuildersFollyLevel_Scriptable.BuildersFollyGoal inGoal)
	{
		return null;
	}

	private string GetColorText(BuildersFollyStationTile inTile, bool inOutput, int inIndex = 0)
	{
		return null;
	}

	internal void UpdateStationInfo(BuildersFollyStationTile inStationTile, bool inLeft = true)
	{
	}

	internal Sprite GetStationIconSprite(BuildersFollyData.EStationType inRequiredStation)
	{
		return null;
	}

	internal void ShowPathDelete(bool inShow)
	{
	}

	internal void ShowWalkthroughPopup()
	{
	}

	internal void ShowHUD(bool inShow)
	{
	}

	private void ShowHideDuringGameplay(bool inPlay)
	{
	}

	internal void ShowLevelSelect(bool inShow)
	{
	}

	internal void ShowRewardScreen(bool inShow)
	{
	}

	private void RewardScreenTierUpdate(int inScore)
	{
	}

	internal void RewardCollected()
	{
	}

	private void ShowExitGame(bool inShow)
	{
	}

	private void ShowTutorialPage()
	{
	}

	internal void ShowTutorial(bool inShow)
	{
	}

	private void ShowGoalsList(bool inShow)
	{
	}

	private void ShowBroomPopUp(bool inShow)
	{
	}

	private void ResetResources()
	{
	}

	private void SetGameRunning()
	{
	}

	internal void CleanupLevel()
	{
	}

	internal void TileModeChq()
	{
	}

	[IteratorStateMachine(typeof(<PulseTransform>d__178))]
	internal IEnumerator PulseTransform(Transform inTrans, Vector3 inStartScale)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<InfoWindowPopUp>d__179))]
	private IEnumerator InfoWindowPopUp(Vector3 inPos)
	{
		return null;
	}

	private void InitRecipeIcon(BuildersFollyUI_RecipeIcon inRecipeIcon, BuildersFollyResource inResource)
	{
	}

	internal void ShowRecipe(BuildersFollyResource inGoalResouorce, bool inReversing = false)
	{
	}

	internal void ShowRecipe(bool inShow, [Optional] BuildersFollyLevel_Scriptable.BuildersFollyGoal inBuildersFollyGoal)
	{
	}

	public void BtnClicked_ToggleExpertMode()
	{
	}

	public void BtnClicked_RecipieBack()
	{
	}

	public void BtnClicked_RecipeClosed()
	{
	}

	public void BtnClicked_RewardScreenNextLevel()
	{
	}

	public void BtnClicked_RewardScreenLevelSelect()
	{
	}

	public void BtnClicked_RewardScreenReplay()
	{
	}

	public void BtnClicked_TileRotate()
	{
	}

	public void BtnClicked_TileFlip(bool inHorizontal)
	{
	}

	public void BtnClicked_SplashScreenStart()
	{
	}

	public void BtnClicked_StartTutorial()
	{
	}

	public void BtnClicked_TutorialNextPage()
	{
	}

	public void BtnClicked_TutorialClose()
	{
	}

	public void BtnClicked_LevelSelectStart()
	{
	}

	public void RecievedLevelStart()
	{
	}

	public void BtnClicked_CloseGoalsList()
	{
	}

	public void BtnClicked_GameX()
	{
	}

	public void BtnClicked_ExitGame()
	{
	}

	public void BtnClicked_ExitLevel()
	{
	}

	public void BtnClicked_ExitCancel()
	{
	}

	public void BtnClicked_ExitReset()
	{
	}

	public void BtnClicked_OpenLevelSelect()
	{
	}

	public void BtnClicked_Save()
	{
	}

	public void BtnClicked_ResetGrid()
	{
	}

	public void BtnClicked_LevelSuccessReward()
	{
	}

	public void BtnClicked_BroomPopUpOK()
	{
	}

	public void BtnClicked_BroomPopUpCancel()
	{
	}

	public void BtnClicked_Broom()
	{
	}

	public void BtnClicked_PlayAndFastForward()
	{
	}

	public void BtnClicked_InfoOption(bool inLeft)
	{
	}

	public void BtnClicked_ColorSelect(int inIndex)
	{
	}

	public void BtnClicked_DBG()
	{
	}

	public void BtnClicked_InfoWindowDeleteStation()
	{
	}
}
