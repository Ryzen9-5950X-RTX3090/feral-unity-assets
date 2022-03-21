using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CFX_ShurikenThreadFix : MonoBehaviour
{
	private ParticleSystem[] systems;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(<WaitFrame>d__2))]
	private IEnumerator WaitFrame()
	{
		return null;
	}
}
