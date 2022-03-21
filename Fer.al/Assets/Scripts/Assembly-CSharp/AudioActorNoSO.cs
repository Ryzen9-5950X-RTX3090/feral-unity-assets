using UnityEngine;

public class AudioActorNoSO : MonoBehaviour
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

	[Header("Gliding")]
	public FeralAudioInfo gliding;

	public FeralAudioInfo glideFall;

	public FeralAudioInfo glideUpdraftLaunch;

	public FeralAudioInfo glideInitiate;

	[Header("Respawn")]
	public FeralAudioInfo teleportAway;

	public FeralAudioInfo teleportArrive;

	public FeralAudioInfo boundaryDeath;

	public FeralAudioInfo boundaryRespawn;
}
