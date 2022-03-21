using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryTwiggle : ManagedBehaviour
{
	[SerializeField]
	protected GameObject _twiggleGameObjectRef;

	[SerializeField]
	protected ActorNPCSpawner _twiggleSpawnerRef;

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<InitWait>d__3))]
	protected virtual IEnumerator InitWait()
	{
		return null;
	}
}
