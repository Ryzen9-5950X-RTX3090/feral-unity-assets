using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayAudioClip : ManagedBehaviour
{
	private static PlayAudioClip _instance;

	private AudioSource _audioSource;

	public static PlayAudioClip instance
	{
		get
		{
			return null;
		}
	}

	public AudioSource audioSource
	{
		get
		{
			return null;
		}
	}

	public void Play(AudioClip inAudioClip)
	{
	}

	[IteratorStateMachine(typeof(<PlayCoroutine>d__7))]
	private IEnumerator PlayCoroutine(AudioClip inAudioClip, bool inLoop = true)
	{
		return null;
	}
}
