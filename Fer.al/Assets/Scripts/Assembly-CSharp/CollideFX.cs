using UnityEngine;

public class CollideFX : MonoBehaviour
{
	[SerializeField]
	private GameObject _FX;

	[SerializeField]
	private float _distanceFromPlayer;

	[SerializeField]
	private float _timeBetweenFX;

	private float _timeSinceLastFX;

	private void Update()
	{
	}

	public void Collide(Transform other)
	{
	}
}
