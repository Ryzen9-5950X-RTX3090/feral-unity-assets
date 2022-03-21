using System.Collections.Generic;
using UnityEngine;

public class CodeBreakerAudio : MonoBehaviour
{
	private static CodeBreakerAudio _instance;

	public FeralAudioInfo gameMusic;

	public FeralAudioInfo splashMusic;

	[Header("Collision Sfx")]
	public FeralAudioInfo redCollision;

	public FeralAudioInfo blueCollision;

	public FeralAudioInfo yellowCollision;

	public FeralAudioInfo greenCollision;

	public FeralAudioInfo orangeCollision;

	public FeralAudioInfo purpleCollision;

	public FeralAudioInfo pinkCollision;

	public FeralAudioInfo cyanCollision;

	[Header("UI")]
	public FeralAudioInfo scoreFillbarStarFilled;

	public FeralAudioInfo dropButton;

	public FeralAudioInfo mixButton;

	public FeralAudioInfo levelButtonSelected;

	public FeralAudioInfo uiForcedTutorialPopup;

	public FeralAudioInfo uiForcedTutorialContinue;

	[Header("Gameplay")]
	public FeralAudioInfo timerTick;

	public FeralAudioInfo beetleMove;

	public FeralAudioInfo beetleWingsLP;

	public FeralAudioInfo beetleDiscardIngredient;

	public FeralAudioInfo cauldronActive;

	public FeralAudioInfo cauldronLP;

	public FeralAudioInfo ingredientWheelTap;

	public FeralAudioInfo ingredientWheelDragLP;

	public FeralAudioInfo resultsStinger;

	public FeralAudioInfo scrollNotesLP;

	public FeralAudioInfo hintCorrect;

	public FeralAudioInfo hintWrong;

	public FeralAudioInfo hintSomeCorrect;

	private Dictionary<CodeColor, float> _lastPlayedTimers;

	private bool _playingScrollNotesLP;

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

	private void Start()
	{
	}

	public static void PlayGameMusic()
	{
	}

	public static void PlaySplashMusic()
	{
	}

	public static void StopSplashMusic()
	{
	}

	public static void PlayIngredientTypeCollide(CodeColor inIngredientType)
	{
	}

	public static void PlayScoreFillbarStarFilled()
	{
	}

	public static void PlayTimerTick()
	{
	}

	public static void PlayDropButton()
	{
	}

	public static void PlayMixButton()
	{
	}

	public static void PlayBeetleMove()
	{
	}

	public static void PlayBeetleWingsLP()
	{
	}

	public static void StopBeetleWingsLP()
	{
	}

	public static void PlayBeetleDiscardIngredient()
	{
	}

	public static void PlayCauldronActive()
	{
	}

	public static void PlayCauldronLP()
	{
	}

	public static void StopCauldronLP()
	{
	}

	public static void PlayIngredientWheelTap()
	{
	}

	public static void PlayIngredientWheelDragLP()
	{
	}

	public static void StopIngredientWheelDragLP()
	{
	}

	public static void PlayHintCorrect()
	{
	}

	public static void PlayHintWrong()
	{
	}

	public static void PlayHintSomeCorrect()
	{
	}

	public static void PlayLevelButtonSelected()
	{
	}

	public static void PlayResultsStinger()
	{
	}

	public static void PlayScrollNotesLP()
	{
	}

	public static void StopScrollNotesLP()
	{
	}

	public static void PlayUIForcedTutorialPopup()
	{
	}

	public static void PlayUIForcedTutorialContinue()
	{
	}
}
