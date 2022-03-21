using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryAudio : ManagedBehaviour
{
	public FeralAudioInfo feralAudioInfo;

	public static SanctuaryAudio Create(GameObject inGameObject, FeralAudioInfo inFeralAudioInfo, bool inPlay = false)
	{
		return null;
	}

	public void Setup(FeralAudioInfo inFeralAudioInfo, bool inPlay = false)
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}
}
