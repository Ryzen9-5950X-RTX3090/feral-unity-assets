using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[NotKeyable]
	public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver
	{
		public enum LoopMode
		{
			[Tooltip("Use the loop time setting from the source AnimationClip.")]
			UseSourceAsset,
			[Tooltip("The source AnimationClip loops during playback.")]
			On,
			[Tooltip("The source AnimationClip does not loop during playback.")]
			Off
		}

		private static class AnimationPlayableAssetUpgrade
		{
			public static void ConvertRotationToEuler(AnimationPlayableAsset asset)
			{
			}
		}

		[SerializeField]
		private AnimationClip m_Clip;

		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Vector3 m_EulerAngles;

		[SerializeField]
		private bool m_UseTrackMatchFields;

		[SerializeField]
		private MatchTargetFields m_MatchTargetFields;

		[SerializeField]
		private bool m_RemoveStartOffset;

		[SerializeField]
		private bool m_ApplyFootIK;

		[SerializeField]
		private LoopMode m_Loop;

		private static readonly int k_LatestVersion;

		[SerializeField]
		[HideInInspector]
		private int m_Version;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private Quaternion m_Rotation;

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

		public bool useTrackMatchFields
		{
			get
			{
				return default(bool);
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

		public bool removeStartOffset
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool applyFootIK
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public LoopMode loop
		{
			get
			{
				return default(LoopMode);
			}
			set
			{
			}
		}

		internal bool hasRootTransforms
		{
			get
			{
				return default(bool);
			}
		}

		internal AppliedOffsetMode appliedOffsetMode
		{
			[CompilerGenerated]
			get
			{
				return default(AppliedOffsetMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public AnimationClip clip
		{
			get
			{
				return null;
			}
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

		public override IEnumerable<PlayableBinding> outputs
		{
			[IteratorStateMachine(typeof(<get_outputs>d__45))]
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

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop)
		{
			return default(Playable);
		}

		private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip)
		{
			return default(bool);
		}

		private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode)
		{
			return default(bool);
		}

		public void ResetOffsets()
		{
		}

		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		internal static bool HasRootTransforms(AnimationClip clip)
		{
			return default(bool);
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		private void OnUpgradeFromVersion(int oldVersion)
		{
		}
	}
}
