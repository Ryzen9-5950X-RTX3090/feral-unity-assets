using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;
using UnityEngine.Serialization;

namespace UnityEngine.Timeline
{
	[Serializable]
	[IgnoreOnPlayableTrack]
	public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner
	{
		private struct TransientBuildData
		{
			public List<TrackAsset> trackList;

			public List<TimelineClip> clipList;

			public List<IMarker> markerList;

			public static TransientBuildData Create()
			{
				return default(TransientBuildData);
			}

			public void Clear()
			{
			}
		}

		private const int k_LatestVersion = 3;

		[SerializeField]
		[HideInInspector]
		private int m_Version;

		[Obsolete]
		[SerializeField]
		[HideInInspector]
		[Obsolete("Please use m_InfiniteClip (on AnimationTrack) instead.", false)]
		[FormerlySerializedAs("m_animClip")]
		internal AnimationClip m_AnimClip;

		private static TransientBuildData s_BuildData;

		internal const string kDefaultCurvesName = "Track Parameters";

		[HideInInspector]
		[SerializeField]
		private bool m_Locked;

		[HideInInspector]
		[SerializeField]
		private bool m_Muted;

		[HideInInspector]
		[SerializeField]
		private string m_CustomPlayableFullTypename;

		[HideInInspector]
		[SerializeField]
		private AnimationClip m_Curves;

		[SerializeField]
		[HideInInspector]
		private PlayableAsset m_Parent;

		[HideInInspector]
		[SerializeField]
		private List<ScriptableObject> m_Children;

		[NonSerialized]
		private int m_ItemsHash;

		[NonSerialized]
		private TimelineClip[] m_ClipsCache;

		private DiscreteTime m_Start;

		private DiscreteTime m_End;

		private bool m_CacheSorted;

		private bool? m_SupportsNotifications;

		private static TrackAsset[] s_EmptyCache;

		private IEnumerable<TrackAsset> m_ChildTrackCache;

		private static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache;

		[SerializeField]
		[HideInInspector]
		protected internal List<TimelineClip> m_Clips;

		[HideInInspector]
		[SerializeField]
		private MarkerList m_Markers;

		public double start
		{
			get
			{
				return default(double);
			}
		}

		public double end
		{
			get
			{
				return default(double);
			}
		}

		public sealed override double duration
		{
			get
			{
				return default(double);
			}
		}

		public bool muted
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool mutedInHierarchy
		{
			get
			{
				return default(bool);
			}
		}

		public TimelineAsset timelineAsset
		{
			get
			{
				return null;
			}
		}

		public PlayableAsset parent
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal TimelineClip[] clips
		{
			get
			{
				return null;
			}
		}

		public virtual bool isEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public bool hasClips
		{
			get
			{
				return default(bool);
			}
		}

		public bool hasCurves
		{
			get
			{
				return default(bool);
			}
		}

		public bool isSubTrack
		{
			get
			{
				return default(bool);
			}
		}

		public override IEnumerable<PlayableBinding> outputs
		{
			[IteratorStateMachine(typeof(<get_outputs>d__65))]
			get
			{
				return null;
			}
		}

		internal string customPlayableTypename
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AnimationClip curves
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		string ICurvesOwner.defaultCurvesName
		{
			get
			{
				return null;
			}
		}

		Object ICurvesOwner.asset
		{
			get
			{
				return null;
			}
		}

		Object ICurvesOwner.assetOwner
		{
			get
			{
				return null;
			}
		}

		TrackAsset ICurvesOwner.targetTrack
		{
			get
			{
				return null;
			}
		}

		internal List<ScriptableObject> subTracksObjects
		{
			get
			{
				return null;
			}
		}

		public bool locked
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool lockedInHierarchy
		{
			get
			{
				return default(bool);
			}
		}

		public bool supportsNotifications
		{
			get
			{
				return default(bool);
			}
		}

		internal static event Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal static event Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void OnBeforeTrackSerialize()
		{
		}

		protected virtual void OnAfterTrackDeserialize()
		{
		}

		internal virtual void OnUpgradeFromVersion(int oldVersion)
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		private void UpgradeToLatestVersion()
		{
		}

		public IEnumerable<TimelineClip> GetClips()
		{
			return null;
		}

		public IEnumerable<TrackAsset> GetChildTracks()
		{
			return null;
		}

		private void __internalAwake()
		{
		}

		public void CreateCurves(string curvesClipName)
		{
		}

		public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		public TimelineClip CreateDefaultClip()
		{
			return null;
		}

		public TimelineClip CreateClip<T>() where T : ScriptableObject, IPlayableAsset
		{
			return null;
		}

		public bool DeleteClip(TimelineClip clip)
		{
			return default(bool);
		}

		public IMarker CreateMarker(Type type, double time)
		{
			return null;
		}

		public T CreateMarker<T>(double time) where T : ScriptableObject, IMarker
		{
			return null;
		}

		public bool DeleteMarker(IMarker marker)
		{
			return default(bool);
		}

		public IEnumerable<IMarker> GetMarkers()
		{
			return null;
		}

		public int GetMarkerCount()
		{
			return default(int);
		}

		public IMarker GetMarker(int idx)
		{
			return null;
		}

		internal TimelineClip CreateClip(Type requestedType)
		{
			return null;
		}

		internal TimelineClip CreateAndAddNewClipOfType(Type requestedType)
		{
			return null;
		}

		internal TimelineClip CreateClipOfType(Type requestedType)
		{
			return null;
		}

		internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset)
		{
			return null;
		}

		private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset)
		{
			return null;
		}

		internal IEnumerable<ScriptableObject> GetMarkersRaw()
		{
			return null;
		}

		internal void ClearMarkers()
		{
		}

		internal void AddMarker(ScriptableObject e)
		{
		}

		internal bool DeleteMarkerRaw(ScriptableObject marker)
		{
			return default(bool);
		}

		private int GetTimeRangeHash()
		{
			return default(int);
		}

		internal void AddClip(TimelineClip newClip)
		{
		}

		private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable)
		{
			return default(Playable);
		}

		internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable)
		{
			return default(Playable);
		}

		internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree)
		{
			return default(Playable);
		}

		private void GatherCompilableTracks(IList<TrackAsset> tracks)
		{
		}

		private void GatherNotificiations(List<IMarker> markers)
		{
		}

		internal virtual Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
		{
			return default(Playable);
		}

		internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend)
		{
		}

		internal void SortClips()
		{
		}

		internal void ClearClipsInternal()
		{
		}

		internal void ClearSubTracksInternal()
		{
		}

		internal void OnClipMove()
		{
		}

		internal TimelineClip CreateNewClipContainerInternal()
		{
			return null;
		}

		internal void AddChild(TrackAsset child)
		{
		}

		internal void MoveLastTrackBefore(TrackAsset asset)
		{
		}

		internal bool RemoveSubTrack(TrackAsset child)
		{
			return default(bool);
		}

		internal void RemoveClip(TimelineClip clip)
		{
		}

		internal virtual void GetEvaluationTime(out double outStart, out double outDuration)
		{
		}

		internal virtual void GetSequenceTime(out double outStart, out double outDuration)
		{
		}

		public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		internal GameObject GetGameObjectBinding(PlayableDirector director)
		{
			return null;
		}

		internal bool ValidateClipType(Type clipType)
		{
			return default(bool);
		}

		protected virtual void OnCreateClip(TimelineClip clip)
		{
		}

		private void UpdateDuration()
		{
		}

		protected internal virtual int CalculateItemsHash()
		{
			return default(int);
		}

		protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
		{
			return default(Playable);
		}

		internal void Invalidate()
		{
		}

		internal double GetNotificationDuration()
		{
			return default(double);
		}

		internal virtual bool CanCompileClips()
		{
			return default(bool);
		}

		internal bool IsCompilable()
		{
			return default(bool);
		}

		private void UpdateChildTrackCache()
		{
		}

		internal virtual int Hash()
		{
			return default(int);
		}

		private int GetClipsHash()
		{
			return default(int);
		}

		protected static int GetAnimationClipHash(AnimationClip clip)
		{
			return default(int);
		}

		private bool HasNotifications()
		{
			return default(bool);
		}

		private bool CanCompileNotifications()
		{
			return default(bool);
		}

		private bool CanCompileClipsRecursive()
		{
			return default(bool);
		}
	}
}
