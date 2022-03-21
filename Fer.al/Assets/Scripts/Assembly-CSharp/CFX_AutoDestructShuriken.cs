using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class CFX_AutoDestructShuriken : MonoBehaviour
{
	public bool OnlyDeactivate;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(<CheckIfAlive>d__2))]
	private IEnumerator CheckIfAlive()
	{
		return null;
	}
}
