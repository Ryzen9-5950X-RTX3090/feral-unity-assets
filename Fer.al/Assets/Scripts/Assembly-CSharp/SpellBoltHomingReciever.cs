using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class SpellBoltHomingReciever : ManagedBehaviour
{
	private SphereCollider _collider;

	private SpellBoltController _controller;

	public override void MStart()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
