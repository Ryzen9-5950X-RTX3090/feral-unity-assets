using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Audio/CoreAudioManager")]
public class CoreAudioManager : CoreManagerBase<CoreAudioManager>
{
	public float sceneTransitionTime;

	public AnimationCurve sceneTransitionCurve;

	private AudioListener _listener;

	private float _musicVolume;

	private float _soundVolume;

	private float _sceneTransitionCur;

	public float MusicVolume
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float SoundVolume
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	private void OnApplicationFocus(bool inFocus)
	{
	}

	public static void PauseMusic()
	{
	}

	public static void ResumeMusic()
	{
	}

	public static void StopMusic()
	{
	}

	public override bool HasInitCoroutine()
	{
		return default(bool);
	}

	public virtual void SoundVolumeChanged(float inVolume)
	{
	}

	public virtual void MusicVolumeChanged(float inVolume)
	{
	}

	[IteratorStateMachine(typeof(<InitCoroutine>d__19))]
	public override IEnumerator InitCoroutine()
	{
		return null;
	}

	public override void MOnDestroy()
	{
	}

	public override void MUpdate()
	{
	}

	private void OnLevelLoaded(Message inMessage)
	{
	}

	private void OnLoadingStarted(Message inMessage)
	{
	}

	private void OnLoadingFinished(Message inMessage)
	{
	}

	protected float VolumeInDb(float inValue)
	{
		return default(float);
	}

	private void UpdateSceneTransition()
	{
	}
}
