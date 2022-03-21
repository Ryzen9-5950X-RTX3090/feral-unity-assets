using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CoreLevelBaseWorld : CoreLevelBase
{
	[Header("Spawn")]
	public List<Transform> spawnPoints;

	public Vector2 randomSpawnPointRange;

	[Header("Avatar Local")]
	public float localMoverMaxSpeedMultiplier;

	[Header("Camera")]
	public PlayerCameraMode defaultPlayerCameraMode;

	[Header("Camera Option")]
	public bool useCameraOptions;

	public PlayerCameraOptions_CM cameraOptions;

	[Header("Respawn Option")]
	public GameObject[] collisionOn;

	public GameObject[] collisionOff;

	public GameObject[] collisionRespawn;

	public PlayerCameraOptions_CM CameraOptions
	{
		get
		{
			return null;
		}
	}

	private void OnDrawGizmos()
	{
	}

	[IteratorStateMachine(typeof(<InitFromManager>d__12))]
	public override IEnumerator InitFromManager()
	{
		return null;
	}
}
