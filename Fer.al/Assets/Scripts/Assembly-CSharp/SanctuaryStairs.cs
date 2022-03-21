using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryStairs : ManagedBehaviour
{
	[SerializeField]
	private Transform _safeSpot;

	private SanctuaryIndoorRoom _sanctuaryIndoorRoom;

	private bool _upstairs;

	public Transform safeSpot
	{
		get
		{
			return null;
		}
	}

	public void Setup(SanctuaryIndoorRoom inSanctuaryIndoorRoom, bool inUpstairs)
	{
	}

	private void OnTriggerEnter(Collider inCollider)
	{
	}

	private void Teleport()
	{
	}
}
