using UnityEngine;
using UnityEngine.Playables;

[ManagedBehaviourManager("CinematicManager")]
public class TimelinePlayDirectors : ManagedBehaviour
{
	[SerializeField]
	private bool playOnStart;

	[SerializeField]
	private PlayableDirector[] playableDirectors;

	public override void MStart()
	{
	}

	public void Play()
	{
	}
}
