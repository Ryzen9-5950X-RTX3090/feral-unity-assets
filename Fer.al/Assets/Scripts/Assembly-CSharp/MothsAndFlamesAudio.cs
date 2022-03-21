using UnityEngine;

public class MothsAndFlamesAudio : MonoBehaviour
{
	private static MothsAndFlamesAudio _instance;

	[Tooltip("pg_03_m&f_ dice_roll - trigger when dice begin to rise and rotate.")]
	public FeralAudioInfo diceRoll;

	[Tooltip("pg_03_m&f_crystalpulse_ring -  trigger when the ring around the crystal appears.")]
	public FeralAudioInfo crystalPulseRing;

	[Tooltip("pg_03_m&f_crystaltoken_pickup - trigger when the player picks up the crystal token.")]
	public FeralAudioInfo crystalTokenPickup;

	[Tooltip("pg_03_m&f_crystaltoken_placed - trigger when the player places the crystal token.")]
	public FeralAudioInfo crystalTokenPlaced;

	[Tooltip("pg_03_m&f_dicecup_reveal_flame - trigger when the dice are revealed and the player picks the correct option (Flame).")]
	public FeralAudioInfo diceCupRevealFlame;

	[Tooltip("pg_03_m&f_dicecup_reveal_placed - trigger when the dice are revealed and the player chooses incorrectly.")]
	public FeralAudioInfo diceCupRevealPlaced;

	[Tooltip("pg_03_m&f_dicecup_reveal_moths - trigger when the dice are revealed and the player chooses the correct option (Moths).")]
	public FeralAudioInfo diceCupRevealMoths;

	[Tooltip("pg_03_m&f_dicecup_scoop - trigger when Kino scoops up the dice.")]
	public FeralAudioInfo diceCupScoop;

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

	public static void PlayDiceRoll()
	{
	}

	public static void PlayCrystalPulseRing()
	{
	}

	public static void PlayCrystalTokenPickup()
	{
	}

	public static void PlayCrystalTokenPlaced()
	{
	}

	public static void PlayDiceCupRevealFlame()
	{
	}

	public static void PlayDiceCupRevealPlaced()
	{
	}

	public static void PlayDiceCupRevealMoths()
	{
	}

	public static void PlayDiceCupScoop()
	{
	}
}
