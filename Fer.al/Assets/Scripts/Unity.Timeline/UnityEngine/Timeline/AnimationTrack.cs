using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Serialization;

namespace UnityEngine.Timeline
{
	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(Animator))]
	[TrackClipType(typeof(AnimationPlayableAsset), false)]
	public class AnimationTrack : TrackAsset, ILayerable
	{
		private static class AnimationTrackUpgrade
		{
			public static void ConvertRotationsToEuler(AnimationTrack track)
			{
			}

			public static void ConvertRootMotion(AnimationTrack track)
			{
			}

			public static void ConvertInfiniteTrack(AnimationTrack track)
			{
			}
		}

		private const string k_DefaultInfiniteClipName = "Recorded";

		private const string k_DefaultRecordableClipName = "Recorded";

		[SerializeField]
		[FormerlySerializedAs("m_OpenClipPreExtrapolation")]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation;

		[SerializeField]
		[FormerlySerializedAs("m_OpenClipPostExtrapolation")]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation;

		[SerializeField]
		[FormerlySerializedAs("m_OpenClipOffsetPosition")]
		private Vector3 m_InfiniteClipOffsetPosition;

		[SerializeField]
		[FormerlySerializedAs("m_OpenClipOffsetEulerAngles")]
		private Vector3 m_InfiniteClipOffsetEulerAngles;

		[SerializeField]
		[FormerlySerializedAs("m_OpenClipTimeOffset")]
		private double m_InfiniteClipTimeOffset;

		[SerializeField]
		[FormerlySerializedAs("m_OpenClipRemoveOffset")]
		private bool m_InfiniteClipRemoveOffset;

		[SerializeField]
		private bool m_InfiniteClipApplyFootIK;

		[SerializeField]
		[HideInInspector]
		private AnimationPlayableAsset.LoopMode mInfiniteClipLoop;

		[SerializeField]
		private MatchTargetFields m_MatchTargetFields;

		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Vector3 m_EulerAngles;

		[SerializeField]
		private AvatarMask m_AvatarMask;

		[SerializeField]
		private bool m_ApplyAvatarMask;

		[SerializeField]
		private TrackOffset m_TrackOffset;

		[HideInInspector]
		[SerializeField]
		private AnimationClip m_InfiniteClip;

		private static readonly Queue<Transform> s_CachedQueue;

		[SerializeField]
		[HideInInspector]
		[Obsolete]
		private Quaternion m_OpenClipOffsetRotation;

		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private Quaternion m_Rotation;

		[HideInInspector]
		[SerializeField]
		[Obsolete]
		private bool m_ApplyOffsets;

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 eulerAngles
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[Obsolete]
		public bool applyOffsets
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public TrackOffset trackOffset
		{
			get
			{
				return default(TrackOffset);
			}
			set
			{
			}
		}

		public MatchTargetFields matchTargetFields
		{
			get
			{
				return default(MatchTargetFields);
			}
			set
			{
			}
		}

		public AnimationClip infiniteClip
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal bool infiniteClipRemoveOffset
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public AvatarMask avatarMask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool applyAvatarMask
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override IEnumerable<PlayableBinding> outputs
		{
			[IteratorStateMachine(typeof(<get_outputs>d__49))]
			get
			{
				return null;
			}
		}

		public bool inClipMode
		{
			get
			{
				return default(bool);
			}
		}

		public Vector3 infiniteClipOffsetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion infiniteClipOffsetRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 infiniteClipOffsetEulerAngles
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		internal bool infiniteClipApplyFootIK
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal double infiniteClipTimeOffset
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation
		{
			get
			{
				return default(TimelineClip.ClipExtrapolation);
			}
			set
			{
			}
		}

		public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation
		{
			get
			{
				return default(TimelineClip.ClipExtrapolation);
			}
			set
			{
			}
		}

		internal AnimationPlayableAsset.LoopMode infiniteClipLoop
		{
			get
			{
				return default(AnimationPlayableAsset.LoopMode);
			}
			set
			{
			}
		}

		[Obsolete]
		[Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Vector3 openClipOffsetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[Obsolete]
		[Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Quaternion openClipOffsetRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		[Obsolete]
		[Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Vector3 openClipOffsetEulerAngles
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[Obsolete]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", true)]
		public TimelineClip.ClipExtrapolation openClipPreExtrapolation
		{
			get
			{
				return default(TimelineClip.ClipExtrapolation);
			}
			set
			{
			}
		}

		[Obsolete]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", true)]
		public TimelineClip.ClipExtrapolation openClipPostExtrapolation
		{
			get
			{
				return default(TimelineClip.ClipExtrapolation);
			}
			set
			{
			}
		}

		internal override bool CanCompileClips()
		{
			return default(bool);
		}

		[ContextMenu("Reset Offsets")]
		private void ResetOffsets()
		{
		}

		public TimelineClip CreateClip(AnimationClip clip)
		{
			return null;
		}

		public void CreateInfiniteClip(string infiniteClipName)
		{
		}

		public TimelineClip CreateRecordableClip(string animClipName)
		{
			return null;
		}

		protected override void OnCreateClip(TimelineClip clip)
		{
		}

		protected internal override int CalculateItemsHash()
		{
			return default(int);
		}

		internal void UpdateClipOffsets()
		{
		}

		private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			return default(Playable);
		}

		Playable ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		internal override Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
		{
			return default(Playable);
		}

		private int GetDefaultBlendCount()
		{
			return default(int);
		}

		private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset)
		{
		}

		private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot)
		{
			return default(Playable);
		}

		private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject)
		{
			return default(bool);
		}

		private static bool UsesAbsoluteMotion(AppliedOffsetMode mode)
		{
			return default(bool);
		}

		private bool HasController(GameObject gameObject)
		{
			return default(bool);
		}

		internal Animator GetBinding(PlayableDirector director)
		{
			return null;
		}

		private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(AnimationLayerMixerPlayable);
		}

		private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			return default(Playable);
		}

		private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode)
		{
			return default(Playable);
		}

		internal override void GetEvaluationTime(out double outStart, out double outDuration)
		{
		}

		internal override void GetSequenceTime(out double outStart, out double outDuration)
		{
		}

		private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip)
		{
		}

		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		private void GetAnimationClips(List<AnimationClip> animClips)
		{
		}

		private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform)
		{
			return default(AppliedOffsetMode);
		}

		private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode)
		{
			return default(bool);
		}

		private Transform GetGenericRootNode(GameObject gameObject)
		{
			return null;
		}

		internal bool AnimatesRootTransform()
		{
			return default(bool);
		}

		private static Transform FindInHierarchyBreadthFirst(Transform t, string name)
		{
			return null;
		}

		internal override void OnUpgradeFromVersion(int oldVersion)
		{
		}
	}
}
