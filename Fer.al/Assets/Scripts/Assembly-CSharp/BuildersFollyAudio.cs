using FMODUnity;
using UnityEngine;

public class BuildersFollyAudio : MonoBehaviour
{
	private static BuildersFollyAudio _instance;

	[Tooltip("cg_folly_splash_screen_lp - Loop should continue to play when the player goes through the tutorial. Should stop after the tutorial is finished.")]
	public FeralAudioInfo splashMusic;

	[Tooltip("cg_02_mus_folly_play - trigger main music when player presses â\u0080\u009cplayâ\u0080\u009d button to start twiggles (should stop when the game is over)")]
	public FeralAudioInfo musicPlay;

	[Tooltip("cg_02_mus_folly_setup - trigger setup music when player presses â\u0080\u009cplayâ\u0080\u009d from the splash screen.")]
	public FeralAudioInfo musicSetup;

	[Space]
	[Space(8f)]
	[Tooltip("cg_folly_box_gears - trigger when box opens.")]
	public FeralAudioInfo deliverBoxGears;

	[Tooltip("cg_folly_station_cooking - trigger when dye station is active.")]
	public FeralAudioInfo stationDyeCooking;

	[Tooltip("cg_folly_station_hammer - trigger when build station is active.")]
	public FeralAudioInfo stationBuildHammer;

	[Tooltip("cg_folly_station_kiln - trigger when kiln station is active.")]
	public FeralAudioInfo stationKiln;

	[Tooltip("cg_folly_station_saw - trigger when cutting station is active.")]
	public FeralAudioInfo stationCutSaw;

	[Tooltip("cg_folly_station_sew - trigger when sewing station is active.")]
	public FeralAudioInfo stationSew;

	[Tooltip("cg_folly_stinger_delivered_01 - trigger when item is delivered in box.")]
	public FeralAudioInfo stingerDelivered01;

	[Tooltip("cg_folly_stinger_delivered_02 - trigger when twiggles celebrate.")]
	public FeralAudioInfo stingerDelivered02;

	[Tooltip("cg_folly_stinger_points - trigger when points appear for station item complete.")]
	public FeralAudioInfo stingerStationPoints;

	[Tooltip("cg_folly_station_deselect - trigger when station is removed.")]
	public FeralAudioInfo stationRemovedDeselect;

	[Tooltip("cg_folly_btn_station_select - trigger when station button is pressed.")]
	public FeralAudioInfo buttonStationSelect;

	[Tooltip("cg_folly_station_placed - trigger when station is placed.")]
	public FeralAudioInfo stationPlaced;

	[Tooltip("cg_folly_btn_tile_clear - trigger when clear button is pressed.")]
	public FeralAudioInfo buttonClear;

	[Tooltip("cg_folly_tile_placed - trigger when tile is placed.")]
	public FeralAudioInfo tilePlaced;

	[Tooltip("cg_folly_btn_tile_select - trigger when tile button is pressed")]
	public FeralAudioInfo buttonTileSelect;

	[Tooltip("cg_folly_btn_broom - trigger when broom button is pressed.")]
	public FeralAudioInfo buttonBroom;

	[Tooltip("cg_folly_btn_fast_forward - trigger when the forward button is pressed.")]
	private ParamRef[] musicParam;

	public FeralAudioInfo buttonForward;

	[Tooltip("cg_folly_btn_normal - trigger when the Fast forward button is deselected.")]
	public FeralAudioInfo buttonNormal;

	[Tooltip("cg_folly_btn_reward - trigger when the reward button is pressed.")]
	public FeralAudioInfo buttonReward;

	[Tooltip("cg_folly_stinger_reward - trigger when the Choose (reward) button is pressed.")]
	public FeralAudioInfo stingerChooseReward;

	[Tooltip("cg_folly_btn_reset - trigger when the reset button is pressed.")]
	public FeralAudioInfo buttonReset;

	[Tooltip("ui_btn_next - trigger when â\u0080\u009cNextâ\u0080\u009d button is pressed.")]
	public FeralAudioInfo buttonNext;

	[Tooltip("ui_btn_play -  trigger when â\u0080\u009cStartâ\u0080\u009d button is pressed")]
	public FeralAudioInfo buttonStartPlay;

	[Tooltip("ui_btn_ok - trigger when â\u0080\u009cOKâ\u0080\u009d button is pressed.")]
	public FeralAudioInfo buttonOk;

	[Tooltip("ui_btn_exit - trigger when â\u0080\u009cExitâ\u0080\u009d button is pressed.")]
	public FeralAudioInfo buttonExit;

	[Tooltip("cg_folly_btn_goalslist - trigger when the Goal List button is pressed.")]
	public FeralAudioInfo buttonGoalsList;

	[Tooltip("cg_folly_station_rotate - trigger when player rotates stations.")]
	public FeralAudioInfo stationRotate;

	[Tooltip("cg_folly_stinger_scorebar - trigger each time score bar meter increases to next star.")]
	public FeralAudioInfo stingerScoreBar;

	[Tooltip("Tutorial button - should trigger cg_btn_tutorial.")]
	public FeralAudioInfo tutorialButton;

	[Tooltip("Btn_CHOOSE - should trigger cg_btn_choose when any/all â\u0080\u009cChooseâ\u0080\u009d buttons are pressed.")]
	public FeralAudioInfo buttonChoose;

	[Tooltip("cg_folly_btn_clear_board - trigger when â\u0080\u009cClear Boardâ\u0080\u009d button is pressed.")]
	public FeralAudioInfo clearBoard;

	[Tooltip("cg_folly_btn_restart_stinge")]
	public FeralAudioInfo restartStinger;

	[Tooltip("cg_btn_cancel - should trigger when the player selects the â\u0080\u009cXâ\u0080\u009d button to clear tiles.")]
	public FeralAudioInfo ButtonCancel;

	[Tooltip("cg_folly_btn_level_select  - trigger when player selects the level (Hammer).")]
	public FeralAudioInfo levelSelect;

	[Tooltip("cg_folly_material_wiggle -  trigger when the material wiggles.")]
	public FeralAudioInfo materialWiggle;

	[Tooltip("Cg_folly_twiggle_sparkle - trigger when the sparkle appears above the twiggles head.")]
	public FeralAudioInfo twiggleSparkle;

	[Tooltip("Cg_folly_twiggle_steps -  trigger for each step the twiggles take.")]
	public FeralAudioInfo twiggleSteps;

	[Tooltip("Cg_btn_tap_to_continue - trigger when the tap to continue buttons are pressed.")]
	public FeralAudioInfo tapToContinue;

	[Tooltip("cg_folly_twiggle_spawn - trigger when twiggles spawn.")]
	public FeralAudioInfo twiggleSpawn;

	public static GameObject AudioGO
	{
		get
		{
			return null;
		}
	}

	public static void PlayMusic_Splash(bool inPlay)
	{
	}

	public static void PlayMusic_Game(bool inPlay)
	{
	}

	public static void PlayMusic_Setup(bool inPlay)
	{
	}

	public static void PlayDeliverBoxGears()
	{
	}

	public static void PlayStationDyeCooking()
	{
	}

	public static void PlayStationBuildHammer()
	{
	}

	public static void PlayStationKiln()
	{
	}

	public static void PlayStationCutSaw()
	{
	}

	public static void PlayStationSew()
	{
	}

	public static void PlayStingerDelivered01()
	{
	}

	public static void PlayStingerDelivered02()
	{
	}

	public static void PlayStingerStationPoints()
	{
	}

	public static void PlayStationRemovedDeselect()
	{
	}

	public static void PlayButtonStationSelect()
	{
	}

	public static void PlayStationPlaced()
	{
	}

	public static void PlayButtonClear()
	{
	}

	public static void PlayTilePlaced()
	{
	}

	public static void PlayButtonTileSelect()
	{
	}

	public static void PlayButtonBroom()
	{
	}

	public static void PlayButtonForward()
	{
	}

	public static void PlayButtonNormal()
	{
	}

	public static void PlayButtonReward()
	{
	}

	public static void PlayStingerChooseReward()
	{
	}

	public static void PlayButtonReset()
	{
	}

	public static void PlayButtonNext()
	{
	}

	public static void PlayButtonStartPlay()
	{
	}

	public static void PlayButtonOk()
	{
	}

	public static void PlayButtonExit()
	{
	}

	public static void PlayButtonGoalsList()
	{
	}

	public static void PlayStationRotate()
	{
	}

	public static void PlayStingerScoreBar()
	{
	}

	public static void PlayTutorialButton()
	{
	}

	public static void PlayButtonChoose()
	{
	}

	public static void PlayClearBoard()
	{
	}

	public static void PlayRestartStinger()
	{
	}

	public static void PlayButtonCancel()
	{
	}

	public static void PlayLevelSelect()
	{
	}

	public static void PlayMaterialWiggle()
	{
	}

	public static void PlayTwiggleSparkle()
	{
	}

	public static void PlayTwiggleSteps()
	{
	}

	public static void PlayTapToContinue()
	{
	}

	public static void PlayTwiggleSpawn()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
