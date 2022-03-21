using UnityEngine;

public class QuestMudMonsterAudio : MonoBehaviour
{
	private static QuestMudMonsterAudio _instance;

	public FeralAudioInfo musicDanger;

	public FeralAudioInfo awareStinger;

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

	public static void PlayMusic_Danger(bool inPlay)
	{
	}

	public static void PlayAwareStinger()
	{
	}
}
