using UnityEngine;
using UnityEngine.Playables;

[ManagedBehaviourManager("CinematicManager")]
public class TimelineSkip : ManagedBehaviour
{
	[SerializeField]
	private PlayableDirector playableDirector;

	[SerializeField]
	private float[] skipTimes;

	public void Skip()
	{
	}

	public void SkipAll()
	{
	}
}
