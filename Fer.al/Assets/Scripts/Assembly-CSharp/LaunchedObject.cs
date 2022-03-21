using UnityEngine;

public class LaunchedObject : MonoBehaviour
{
	public GameObject destroyFX;

	public float collisionDelay;

	public bool destroyAfterTime;

	public float destroyTime;

	public GameObject impactSpawnObject;

	public float spawnChance;

	private float elapsedTime;

	private float localFloorLevel;

	private float elapsedImpactObjectTime;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void OnCollisionEnter(Collision collision)
	{
	}

	private void DestroyThis()
	{
	}
}
