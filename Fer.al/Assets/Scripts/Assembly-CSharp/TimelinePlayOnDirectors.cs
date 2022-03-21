using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

[ManagedBehaviourManager("CinematicManager")]
public class TimelinePlayOnDirectors : ManagedBehaviour
{
	[SerializeField]
	private PlayableDirector[] playableDirectors;

	[SerializeField]
	private PlayableAsset[] playables;

	public void Play(int inIndex)
	{
	}

	[IteratorStateMachine(typeof(<PlayCoroutine>d__3))]
	private IEnumerator PlayCoroutine(int inIndex)
	{
		return null;
	}
}
