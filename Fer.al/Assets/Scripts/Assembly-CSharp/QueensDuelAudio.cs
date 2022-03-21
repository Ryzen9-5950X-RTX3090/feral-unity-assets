using System;
using UnityEngine;

public class QueensDuelAudio : MonoBehaviour
{
	private bool _playOneAudio;

	private static QueensDuelAudio _instance;

	[Tooltip("Pg_01_duel_atk_ctr_app_disap  -  triggered each time attack counter appears/ disappears. (This is the tiny box displaying attack number)")]
	public FeralAudioInfo attackButton;

	[Tooltip("Pg_01_duel_dice_drop_slide_release - triggered when dice is placed on an invalid space on the game board then slides back into its original place.")]
	public FeralAudioInfo invalidDropSlide;

	[Tooltip("Pg_01_duel_dice_group_pickup_roll  - triggered each time a group of dice is picked up from game board.")]
	public FeralAudioInfo groupPickup;

	[Tooltip("Pg_01_duel_dice_single_pickup -  triggered when only a single dice is lifted off the gameboard for rotation.")]
	public FeralAudioInfo singlePickup;

	[Tooltip("Pg_01_duel_dice_rotate_rise - trigger when dice start to rise.")]
	public FeralAudioInfo rotateRise;

	[Tooltip("Pg_01_duel_dice_rotate_lp  - should loop when dice start to rotate and stop when dice no longer are rotating.")]
	public FeralAudioInfo rotateLoop;

	[Tooltip("Pg_01_duel_dice_rotate_lower - trigger when dice start to lower.")]
	public FeralAudioInfo rotateLower;

	private static bool _canPlayDrop;

	[Tooltip("Pg_01_duel_dice_group_drop_table  - triggered each time a group of dice is placed back on game board.")]
	public FeralAudioInfo groupDrop;

	[Tooltip("Pg_01_duel_dice_single_tabledrop - triggered when a single dice is placed back on game board from rotating.")]
	public FeralAudioInfo singleDrop;

	[Tooltip("Pg_01_duel_dice_selection_keep - triggered when player picks a dice to keep.")]
	public FeralAudioInfo selectionKeep;

	[Tooltip("Pg_01_duel_magic_wall_appear - triggered when black wall of smoke appears/start.")]
	public FeralAudioInfo wallAppear;

	[Tooltip("Pg_01_duel_magic_wall_disappear - triggered when black wall of smoke disappears/stop.")]
	public FeralAudioInfo wallDisappear;

	[Tooltip("Pg_01_duel_magic_wall_lp - loop is played for the duration of thw black smoke wall being present on the game board.")]
	public FeralAudioInfo wallLoop;

	[Tooltip("Pg_01_duel_attack - triggered when pink arrows and smoke finalize game results.")]
	public FeralAudioInfo attackEffect;

	public static GameObject AudioGO
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public static void PlayAttackButton()
	{
	}

	public static void PlayInvalidDropSlide()
	{
	}

	public static void PlayGroupPickup()
	{
	}

	public static void PlaySinglePickup()
	{
	}

	public static void PlayRotateRise()
	{
	}

	public static void PlayRotateLoop(bool inPlay)
	{
	}

	public static void PlayRotateLower()
	{
	}

	public static void PlayGroupDrop()
	{
	}

	public static void PlaySingleDrop()
	{
	}

	public static void PlaySelectionKeep()
	{
	}

	public static void PlayWallAppear()
	{
	}

	public static void PlayWallDisappear()
	{
	}

	public static void PlayWallLoop(bool inPlay)
	{
	}

	public static void PlayAttackEffect()
	{
	}

	public static void PlayOne(Action<GameObject> inAudioEffectPlay)
	{
	}
}
