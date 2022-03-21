using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

[ManagedBehaviourManager("CinematicManager")]
public class TimelineTime : ManagedBehaviour
{
	[SerializeField]
	private Text _text;

	[SerializeField]
	private PlayableDirector _playableDirector;

	public override void MUpdate()
	{
	}
}
