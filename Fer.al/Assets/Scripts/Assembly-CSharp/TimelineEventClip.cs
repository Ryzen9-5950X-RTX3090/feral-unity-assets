using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class TimelineEventClip : PlayableAsset, ITimelineClipAsset
{
	public TimelineEventBehaviour template;

	public GameObject TrackTargetObject
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public ClipCaps clipCaps
	{
		get
		{
			return default(ClipCaps);
		}
	}

	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}
}
