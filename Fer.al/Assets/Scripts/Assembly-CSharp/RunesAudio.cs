using UnityEngine;

public class RunesAudio : MonoBehaviour
{
	private static RunesAudio _instance;

	public FeralAudioInfo gameMusic;

	public FeralAudioInfo splashMusic;

	public FeralAudioInfo gameOverStinger;

	[Space]
	public FeralAudioInfo uiPopupStinger;

	public FeralAudioInfo uiButtonOK;

	public FeralAudioInfo uiButtonStart;

	public FeralAudioInfo uiButtonExit;

	public FeralAudioInfo uiButtonNext;

	public FeralAudioInfo uiRewardRecieved;

	public FeralAudioInfo uiForcedTutorialPopup;

	public FeralAudioInfo uiForcedTutorialContinue;

	[Space]
	public FeralAudioInfo bombAvailable;

	public FeralAudioInfo bombPickedUp;

	public FeralAudioInfo bombPlaced;

	[Space]
	public FeralAudioInfo runeGroupSpawned;

	public FeralAudioInfo runeGroupPickedUp;

	public FeralAudioInfo runeGroupSinglePlaced;

	public FeralAudioInfo runeGroupDoublePlaced;

	public FeralAudioInfo runeGroupTriplePlaced;

	public FeralAudioInfo runeGroupReturnToSpawn;

	public FeralAudioInfo runeGroupRotateTiles;

	public FeralAudioInfo runeGroupWiggle;

	public FeralAudioInfo runeGroupDespawned;

	[Space]
	public FeralAudioInfo pointsComboMultiplier;

	public FeralAudioInfo runeIconMove;

	public FeralAudioInfo runeIconRestore;

	[Space]
	public FeralAudioInfo cycloneSpawned;

	public FeralAudioInfo cyclonePickedUp;

	public FeralAudioInfo cyclonePlaced;

	public FeralAudioInfo cycloneCollectionFinished;

	public FeralAudioInfo cycloneLiftedUpTile;

	public FeralAudioInfo cycloneCollectedTile;

	[Space]
	public FeralAudioInfo meterFilledFlame;

	public FeralAudioInfo meterFilledFlora;

	public FeralAudioInfo meterFilledMiasma;

	public FeralAudioInfo powerupMeterFillingLoop;

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

	public static void PlayGameOverStinger()
	{
	}

	public static void PlayUiPopupStinger()
	{
	}

	public static void PlayUiButtonOK()
	{
	}

	public static void PlayUiButtonStart()
	{
	}

	public static void PlayUiButtonExit()
	{
	}

	public static void PlayUiButtonNext()
	{
	}

	public static void PlayUIForcedTutorialPopup()
	{
	}

	public static void PlayUIForcedTutorialContinue()
	{
	}

	public static void PlayBombAvailable()
	{
	}

	public static void PlayBombPickedUp()
	{
	}

	public static void PlayBombPlaced()
	{
	}

	public static void PlayRuneGroupSpawned()
	{
	}

	public static void PlayRuneGroupPickedUp()
	{
	}

	public static void PlayRuneGroupSinglePlaced()
	{
	}

	public static void PlayRuneGroupDoublePlaced()
	{
	}

	public static void PlayRuneGroupTriplePlaced()
	{
	}

	public static void PlayRuneGroupReturnToSpawn()
	{
	}

	public static void PlayRuneGroupRotateTiles()
	{
	}

	public static void PlayRuneGroupWiggle()
	{
	}

	public static void PlayRuneGroupDespawned()
	{
	}

	public static void PlayCycloneSpawned()
	{
	}

	public static void PlayCyclonePickedUp()
	{
	}

	public static void PlayCyclonePlaced()
	{
	}

	public static void PlayCycloneFinished()
	{
	}

	public static void PlayCycloneLiftedUpTile()
	{
	}

	public static void PlayCycloneCollectedTile()
	{
	}

	public static void PlayMeterFilledFlame()
	{
	}

	public static void PlayMeterFilledFlora()
	{
	}

	public static void PlayMeterFilledMiasma()
	{
	}

	public static void PlayPowerupMeterFillingLoop()
	{
	}

	public static void StopPowerupMeterFillingLoop()
	{
	}

	public static void PlayPointsComboMultiplier()
	{
	}

	public static void PlayRuneIconMove()
	{
	}

	public static void PlayRuneIconRestore()
	{
	}

	public static void PlayUiRewardReceived()
	{
	}
}
