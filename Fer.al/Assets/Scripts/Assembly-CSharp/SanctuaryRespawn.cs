using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryRespawn : ManagedBehaviour
{
	[SerializeField]
	private Transform _respawnPoint;

	public Transform respawnPoint
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void OnTriggerEnter(Collider inCollider)
	{
	}
}
