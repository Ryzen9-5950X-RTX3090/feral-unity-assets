using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[ExcludeFromPreset]
	public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview
	{
		public enum DurationMode
		{
			BasedOnClips,
			FixedLength
		}

		[Serializable]
		public class EditorSettings
		{
			internal static readonly float kMinFps;

			internal static readonly float kMaxFps;

			internal static readonly float kDefaultFps;

			[SerializeField]
			[HideInInspector]
			private float m_Framerate;

			[SerializeField]
			[HideInInspector]
			private bool m_ScenePreview;

			public float fps
			{
				get
				{
					return default(float);
				}
				set
				{
				}
			}
		}

		private const int k_LatestVersion = 0;

		[SerializeField]
		[HideInInspector]
		private int m_Version;

		[HideInInspector]
		[SerializeField]
		private List<ScriptableObject> m_Tracks;

		[HideInInspector]
		[SerializeField]
		private double m_FixedDuration;

		[NonSerialized]
		[HideInInspector]
		private TrackAsset[] m_CacheOutputTracks;

		[NonSerialized]
		[HideInInspector]
		private List<TrackAsset> m_CacheRootTracks;

		[NonSerialized]
		[HideInInspector]
		private List<TrackAsset> m_CacheFlattenedTracks;

		[SerializeField]
		[HideInInspector]
		private EditorSettings m_EditorSettings;

		[SerializeField]
		private DurationMode m_DurationMode;

		[HideInInspector]
		[SerializeField]
		private MarkerTrack m_MarkerTrack;

		public EditorSettings editorSettings
		{
			get
			{
				return null;
			}
		}

		public override double duration
		{
			get
			{
				return default(double);
			}
		}

		public double fixedDuration
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public DurationMode durationMode
		{
			get
			{
				return default(DurationMode);
			}
			set
			{
			}
		}

		public override IEnumerable<PlayableBinding> outputs
		{
			[IteratorStateMachine(typeof(<get_outputs>d__27))]
			get
			{
				return null;
			}
		}

		public ClipCaps clipCaps
		{
			get
			{
				return default(ClipCaps);
			}
		}

		public int outputTrackCount
		{
			get
			{
				return default(int);
			}
		}

		public int rootTrackCount
		{
			get
			{
				return default(int);
			}
		}

		internal IEnumerable<TrackAsset> flattenedTracks
		{
			get
			{
				return null;
			}
		}

		public MarkerTrack markerTrack
		{
			get
			{
				return null;
			}
		}

		internal List<ScriptableObject> trackObjects
		{
			get
			{
				return null;
			}
		}

		private void UpgradeToLatestVersion()
		{
		}

		private void OnValidate()
		{
		}

		internal static float GetValidFramerate(float framerate)
		{
			return default(float);
		}

		public TrackAsset GetRootTrack(int index)
		{
			return null;
		}

		public IEnumerable<TrackAsset> GetRootTracks()
		{
			return null;
		}

		public TrackAsset GetOutputTrack(int index)
		{
			return null;
		}

		public IEnumerable<TrackAsset> GetOutputTracks()
		{
			return null;
		}

		private void UpdateRootTrackCache()
		{
		}

		private void UpdateOutputTrackCache()
		{
		}

		internal void AddTrackInternal(TrackAsset track)
		{
		}

		internal void RemoveTrack(TrackAsset track)
		{
		}

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		private void __internalAwake()
		{
		}

		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		public void CreateMarkerTrack()
		{
		}

		internal void Invalidate()
		{
		}

		internal void UpdateFixedDurationWithItemsDuration()
		{
		}

		private DiscreteTime CalculateItemsDuration()
		{
			return default(DiscreteTime);
		}

		private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks)
		{
		}

		public TrackAsset CreateTrack(Type type, TrackAsset parent, string name)
		{
			return null;
		}

		public T CreateTrack<T>(TrackAsset parent, string trackName) where T : TrackAsset, new()
		{
			return null;
		}

		public T CreateTrack<T>(string trackName) where T : TrackAsset, new()
		{
			return null;
		}

		public T CreateTrack<T>() where T : TrackAsset, new()
		{
			return null;
		}

		public bool DeleteClip(TimelineClip clip)
		{
			return default(bool);
		}

		public bool DeleteTrack(TrackAsset track)
		{
			return default(bool);
		}

		internal void MoveLastTrackBefore(TrackAsset asset)
		{
		}

		internal TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType)
		{
			return null;
		}

		private void DeleteRecordedAnimation(TrackAsset track)
		{
		}

		private void DeleteRecordedAnimation(TimelineClip clip)
		{
		}
	}
}
