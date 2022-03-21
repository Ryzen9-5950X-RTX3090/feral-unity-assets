using UnityEngine;

[CreateAssetMenu]
public class AudioActor : ScriptableObject
{
	[Header("Swimming")]
	public FeralAudioInfo swimming;

	[Header("Diving")]
	public FeralAudioInfo diving;

	[Header("Digging")]
	public FeralAudioInfo digging;

	[Header("Flying")]
	public FeralAudioInfo flying;

	[Header("Movement Loop")]
	public FeralAudioInfo movementLoop;

	[Header("Idle One Shots")]
	public FeralAudioInfo[] randomIdleOneShots;

	public float randomIdleTimerMin;

	public float randomIdleTimerMax;
}
