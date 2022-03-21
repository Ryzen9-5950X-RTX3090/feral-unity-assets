using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WorldEvent_Bridge : WorldEvent
{
	public float bridgeFxDelay;

	public GameObject bridgeFx;

	private Animation _animation;

	public override void MStart()
	{
	}

	protected override void OnWorldEvent(WorldEventMessage inWorldEventMessage)
	{
	}

	private void ActivateBridge()
	{
	}

	private void DeactivateBridge()
	{
	}

	[IteratorStateMachine(typeof(<PlayBridgeFx>d__7))]
	private IEnumerator PlayBridgeFx()
	{
		return null;
	}

	private void StopBridgeFx()
	{
	}
}
