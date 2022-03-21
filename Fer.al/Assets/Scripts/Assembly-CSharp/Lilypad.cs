using UnityEngine;

public class Lilypad : ManagedBehaviour
{
	[SerializeField]
	private GameObject fxLilypad;

	[SerializeField]
	private GameObject fxLilypadSteppedOn;

	[SerializeField]
	private float _steppedOffOffset;

	[SerializeField]
	private float _fxSteppedOnOffset;

	private SphereCollider _sphereCollider;

	private Vector3 _fxSpawnPosition;

	private Vector3 _steppedOffPosition;

	private Vector3 _steppedOnPosition;

	public Fish fishRef;

	public override void MStart()
	{
	}

	private void SpawnFx()
	{
	}

	private void SpawnFxSteppedOn()
	{
	}

	private void OnTriggerEnter(Collider inCollider)
	{
	}

	private void OnTriggerExit(Collider inCollider)
	{
	}
}
