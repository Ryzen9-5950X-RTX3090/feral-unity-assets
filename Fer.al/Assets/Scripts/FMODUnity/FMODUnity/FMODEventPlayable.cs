using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace FMODUnity
{
	[Serializable]
	public class FMODEventPlayable : PlayableAsset, ITimelineClipAsset
	{
		public FMODEventPlayableBehavior template;

		public float eventLength;

		private FMODEventPlayableBehavior behavior;

		[EventRef]
		[SerializeField]
		public string eventName;

		[SerializeField]
		public STOP_MODE stopType;

		[SerializeField]
		public ParamRef[] parameters;

		[NonSerialized]
		public bool cachedParameters;

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

		public override double duration
		{
			get
			{
				return default(double);
			}
		}

		public ClipCaps clipCaps
		{
			get
			{
				return default(ClipCaps);
			}
		}

		public TimelineClip OwningClip
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

		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}
	}
}
