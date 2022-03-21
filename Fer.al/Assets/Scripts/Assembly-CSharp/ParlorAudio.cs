using UnityEngine;

public class ParlorAudio : MonoBehaviour
{
	private static ParlorAudio _instance;

	[Tooltip("mus_parlor_kino_lp  - trigger main music when the player presses â\u0080\u009cplayâ\u0080\u009d (should stop when the game is over")]
	public FeralAudioInfo parlorGameMusic;

	[Tooltip("Mus_parlor_kino_game_selection_lp -  loop for the duration of game selection or tutorial screen.")]
	public FeralAudioInfo parlorGameSelection;

	[Space]
	[Space(8f)]
	[Tooltip("Pg_mus_stinger_win - trigger when player wins.")]
	public FeralAudioInfo stingerWin;

	[Tooltip("Pg_mus_stinger_fail - trigger when player fails.")]
	public FeralAudioInfo stingerFail;

	[Tooltip("Pg_01_duel_gameboard_rollout - triggered when game boar rolls out onto the table.")]
	public FeralAudioInfo boardRollout;

	[Tooltip("pg_02_fourcrows_gameboard_roll_up - triggered for the game board rolling back up.")]
	public FeralAudioInfo boardRollUp;

	[Tooltip("ui_likes_counter triggers each time the value changes")]
	public FeralAudioInfo likesCounter;

	[Tooltip("pg_02_duel_crystals_zipping - to the 3 sets of shooting crystals (winf fireworks effect)")]
	public FeralAudioInfo crystalsZipping;

	internal static GameObject AudioGO
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

	internal static void PlayMusic_ParlorGameMusic(bool inPlay)
	{
	}

	internal static void PlayMusic_ParlorGameSelection(bool inPlay)
	{
	}

	internal static void PlayStingerWin()
	{
	}

	internal static void PlayStingerFail()
	{
	}

	internal static void PlayBoardRollout()
	{
	}

	internal static void PlayBoardRollUp()
	{
	}

	internal static void PlayLikesCounter()
	{
	}

	internal static void PlayCrystalsZipping()
	{
	}
}
