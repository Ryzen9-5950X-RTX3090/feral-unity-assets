using UnityEngine;

public class MoonPhasesAudio : MonoBehaviour
{
	private static MoonPhasesAudio _instance;

	[Tooltip("Pg_04_moon_token_spawn - trigger when the token spawns on the game board.")]
	public FeralAudioInfo tokenSpawn;

	[Tooltip("Pg_04_moon_domino_placed - trigger when a domino is placed.")]
	public FeralAudioInfo tilePlaced;

	[Tooltip("Pg_04_moon_domino_selected - trigger when a domino is selected.")]
	public FeralAudioInfo tileSelected;

	[Tooltip("Pg_04_moon_dominos_bag_return - trigger when dominos are returned to bag.")]
	public FeralAudioInfo tilesReturned;

	[Tooltip("Pg_04_moon_crystal_token_lp -  loop for the duration of crystal moving around the game board.")]
	public FeralAudioInfo crystalTokenLP;

	[Tooltip("Pg_04_moon_dealer_token_lp - loop for duration of the dealer token moving around the game board.")]
	public FeralAudioInfo dealerTokenLP;

	[Tooltip("Pg_04_moon_crystal_token_start - trigger when the crystal token first starts to move.")]
	public FeralAudioInfo crystalTokenStart;

	[Tooltip("Pg_04_moon_dealer_token_start - trigger when the dealer token first starts to move.")]
	public FeralAudioInfo dealerTokenStart;

	[Tooltip("Pg_04_moon_crystal_token_stop - trigger when the crystal token is about to stop or has stopped.")]
	public FeralAudioInfo crystalTokenStop;

	[Tooltip("Pg_04_moon_dealer_token_stop - trigger when the dealer token is about to stop or has stopped.")]
	public FeralAudioInfo dealerTokenStop;

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

	public void PlayTokenSpawn()
	{
	}

	public static void PlayTilePlaced()
	{
	}

	public static void PlayTileSelected()
	{
	}

	public static void PlayTilesReturned()
	{
	}

	public static void PlayCrystalTokenLP(bool inPlay)
	{
	}

	public static void PlayDealerTokenLP(bool inPlay)
	{
	}

	public static void PlayCrystalTokenStart()
	{
	}

	public static void PlayDealerTokenStart()
	{
	}

	public static void PlayCrystalTokenStop()
	{
	}

	public static void PlayDealerTokenStop()
	{
	}
}
