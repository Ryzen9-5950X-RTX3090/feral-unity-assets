using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryPortal : ManagedBehaviour
{
	[SerializeField]
	private SanctuaryIndoorRoom _sanctuaryIndoorRoom;

	[SerializeField]
	private Transform _teleportTo;

	public void Setup(Transform inTeleportTo)
	{
	}

	private void OnTriggerEnter(Collider inCollider)
	{
	}
}
