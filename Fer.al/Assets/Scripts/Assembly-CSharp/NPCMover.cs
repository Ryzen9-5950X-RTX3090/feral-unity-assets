using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NPCMover : MonoBehaviour
{
	public Animator animator;

	public ActorBase actorBase;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(<Init>d__3))]
	private IEnumerator Init()
	{
		return null;
	}

	public void Set()
	{
	}
}
