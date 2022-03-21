using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Teleporter : ManagedBehaviour
{
	[SerializeField]
	private Transform _teleportTo;

	private float _fadeOutTime;

	private float _fadeWaitTime;

	private float _fadeInTime;

	public static bool teleporting;

	private void OnTriggerEnter(Collider inCollider)
	{
	}

	[IteratorStateMachine(typeof(<Teleport>d__6))]
	private IEnumerator Teleport(WorldMapLocation inWorldMapLocation)
	{
		return null;
	}

	private void FadeToBlack(float inTime = 1f)
	{
	}

	private void FadeToGame(float inTime = 1f)
	{
	}

	public override void MOnDestroy()
	{
	}
}
