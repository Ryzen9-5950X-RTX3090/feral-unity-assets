using UnityEngine;

public class PlayersInRadius : MonoBehaviour
{
	public int playersInRadius;

	public int localPlayersInRadius;

	public int networkPlayersInRadius;

	public float checkRadius;

	private float checkTimer;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
