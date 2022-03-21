using UnityEngine;

public class Match3Audio : MonoBehaviour
{
	private static Match3Audio _instance;

	[Header("Music")]
	public FeralAudioInfo gameMusic;

	public FeralAudioInfo splashMusic;

	[Header("UI")]
	public FeralAudioInfo popupOpen;

	public FeralAudioInfo continueButton;

	public FeralAudioInfo levelScoreMeterFill;

	public FeralAudioInfo powerUpMeterFill;

	public FeralAudioInfo puzzleGalleryButton;

	public FeralAudioInfo backButton;

	public FeralAudioInfo selectPuzzlePiece;

	public FeralAudioInfo placedPuzzlePiece;

	public FeralAudioInfo puzzleComplete;

	public FeralAudioInfo selectPuzzlePortrait;

	public FeralAudioInfo levelObjectivesShown;

	[Header("Gameplay")]
	public FeralAudioInfo standardBirdRemoval;

	public FeralAudioInfo matchMade;

	public FeralAudioInfo boosterActivated_Flyer;

	public FeralAudioInfo boosterActivated_TwinTrouble;

	public FeralAudioInfo boosterActivated_Peacock;

	public FeralAudioInfo tileDrop;

	public FeralAudioInfo swapStarted;

	public FeralAudioInfo swapping;

	public FeralAudioInfo swapBack;

	public FeralAudioInfo powerUpHatched;

	public FeralAudioInfo gameOver;

	public FeralAudioInfo levelComplete;

	public FeralAudioInfo boosterAdded;

	public FeralAudioInfo boosterCombined;

	public FeralAudioInfo dizzyPowerupUsed;

	public FeralAudioInfo eggCracked;

	public FeralAudioInfo eggSpawn;

	public FeralAudioInfo specialItemSpawn;

	public FeralAudioInfo specialItemRemoved;

	public FeralAudioInfo clearedByPeacock;

	public FeralAudioInfo doublePeacock;

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

	public static void PlayGameMusic()
	{
	}

	public static void StopGameMusic()
	{
	}

	public static void PlaySplashMusic()
	{
	}

	public static void StopSplashMusic()
	{
	}

	public static void PlayPopupOpen()
	{
	}

	public static void PlayContinueButton()
	{
	}

	public static void PlayLevelScoreMeterFill()
	{
	}

	public static void StopLevelScoreMeterFill()
	{
	}

	public static void PlayPowerUpMeterFill()
	{
	}

	public static void StopPowerUpMeterFill()
	{
	}

	public static void PlayPuzzleGalleryButton()
	{
	}

	public static void PlayPuzzleBackButton()
	{
	}

	public static void PlaySelectPuzzlePiece()
	{
	}

	public static void PlayPlacedPuzzlePiece()
	{
	}

	public static void PlayPuzzleComplete()
	{
	}

	public static void PlaySelectPuzzlePortrait()
	{
	}

	public static void PlayLevelObjectivesShown()
	{
	}

	public static void PlayStandardBirdRemoval()
	{
	}

	public static void PlayMatchMade()
	{
	}

	public static void PlayBoosterActivated(BoosterType inType)
	{
	}

	public static void PlayTileDropped()
	{
	}

	public static void PlaySwapStarted()
	{
	}

	public static void PlaySwapping()
	{
	}

	public static void PlaySwapBack()
	{
	}

	public static void PlayPowerUpHatched()
	{
	}

	public static void PlayGameOver()
	{
	}

	public static void PlayLevelCompleted()
	{
	}

	public static void PlayBoosterAdded()
	{
	}

	public static void PlayBoosterCombined()
	{
	}

	public static void PlayDizzyPowerupUsed()
	{
	}

	public static void PlayEggCracked()
	{
	}

	public static void PlayEggSpawn()
	{
	}

	public static void PlaySpecialItemSpawn()
	{
	}

	public static void PlaySpecialItemRemoved()
	{
	}

	public static void PlayClearedByPeacock()
	{
	}

	public static void PlayDoublePeacock()
	{
	}
}
