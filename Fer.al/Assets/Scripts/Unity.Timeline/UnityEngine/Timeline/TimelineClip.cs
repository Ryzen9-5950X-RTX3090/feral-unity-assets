using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Timeline
{
	[Serializable]
	public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver
	{
		private static class TimelineClipUpgrade
		{
			public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip)
			{
			}
		}

		public enum ClipExtrapolation
		{
			None,
			Hold,
			Loop,
			PingPong,
			Continue
		}

		public enum BlendCurveMode
		{
			Auto,
			Manual
		}

		private const int k_LatestVersion = 1;

		[SerializeField]
		[HideInInspector]
		private int m_Version;

		public static readonly ClipCaps kDefaultClipCaps;

		public static readonly float kDefaultClipDurationInSeconds;

		public static readonly double kTimeScaleMin;

		public static readonly double kTimeScaleMax;

		internal static readonly string kDefaultCurvesName;

		internal static readonly double kMinDuration;

		internal static readonly double kMaxTimeValue;

		[SerializeField]
		private double m_Start;

		[SerializeField]
		private double m_ClipIn;

		[SerializeField]
		private Object m_Asset;

		[SerializeField]
		[FormerlySerializedAs("m_HackDuration")]
		private double m_Duration;

		[SerializeField]
		private double m_TimeScale;

		[SerializeField]
		private TrackAsset m_ParentTrack;

		[SerializeField]
		private double m_EaseInDuration;

		[SerializeField]
		private double m_EaseOutDuration;

		[SerializeField]
		private double m_BlendInDuration;

		[SerializeField]
		private double m_BlendOutDuration;

		[SerializeField]
		private AnimationCurve m_MixInCurve;

		[SerializeField]
		private AnimationCurve m_MixOutCurve;

		[SerializeField]
		private BlendCurveMode m_BlendInCurveMode;

		[SerializeField]
		private BlendCurveMode m_BlendOutCurveMode;

		[SerializeField]
		private List<string> m_ExposedParameterNames;

		[SerializeField]
		private AnimationClip m_AnimationCurves;

		[SerializeField]
		private bool m_Recordable;

		[SerializeField]
		private ClipExtrapolation m_PostExtrapolationMode;

		[SerializeField]
		private ClipExtrapolation m_PreExtrapolationMode;

		[SerializeField]
		private double m_PostExtrapolationTime;

		[SerializeField]
		private double m_PreExtrapolationTime;

		[SerializeField]
		private string m_DisplayName;

		public double timeScale
		{
			get
			{
				return default(double);
			}
		}

		public double start
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public double duration
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public double end
		{
			get
			{
				return default(double);
			}
		}

		public double clipIn
		{
			get
			{
				return default(double);
			}
		}

		public string displayName
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
		}

		string ICurvesOwner.defaultCurvesName
		{
			get
			{
				return null;
			}
		}

		public Object asset
		{
			get
			{
				return null;
			}
			set
			{
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

		public TrackAsset parentTrack
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public double easeInDuration
		{
			get
			{
				return default(double);
			}
		}

		public double easeOutDuration
		{
			get
			{
				return default(double);
			}
		}

		public double blendInDuration
		{
			get
			{
				return default(double);
			}
		}

		public double blendOutDuration
		{
			get
			{
				return default(double);
			}
		}

		public bool hasBlendIn
		{
			get
			{
				return default(bool);
			}
		}

		public bool hasBlendOut
		{
			get
			{
				return default(bool);
			}
		}

		public AnimationCurve mixInCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public double mixInDuration
		{
			get
			{
				return default(double);
			}
		}

		public AnimationCurve mixOutCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public double mixOutTime
		{
			get
			{
				return default(double);
			}
		}

		public double mixOutDuration
		{
			get
			{
				return default(double);
			}
		}

		public bool recordable
		{
			get
			{
				return default(bool);
			}
			internal set
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

		public ClipExtrapolation postExtrapolationMode
		{
			get
			{
				return default(ClipExtrapolation);
			}
			internal set
			{
			}
		}

		public ClipExtrapolation preExtrapolationMode
		{
			get
			{
				return default(ClipExtrapolation);
			}
			internal set
			{
			}
		}

		public double extrapolatedStart
		{
			get
			{
				return default(double);
			}
		}

		public double extrapolatedDuration
		{
			get
			{
				return default(double);
			}
		}

		private void UpgradeToLatestVersion()
		{
		}

		internal TimelineClip(TrackAsset parent)
		{
		}

		internal int Hash()
		{
			return default(int);
		}

		public float EvaluateMixOut(double time)
		{
			return default(float);
		}

		public float EvaluateMixIn(double time)
		{
			return default(float);
		}

		private static AnimationCurve GetDefaultMixInCurve()
		{
			return null;
		}

		private static AnimationCurve GetDefaultMixOutCurve()
		{
			return null;
		}

		public double ToLocalTime(double time)
		{
			return default(double);
		}

		private static double SanitizeTimeValue(double value, double defaultValue)
		{
			return default(double);
		}

		internal void SetPostExtrapolationTime(double time)
		{
		}

		internal void SetPreExtrapolationTime(double time)
		{
		}

		public bool IsPreExtrapolatedTime(double sequenceTime)
		{
			return default(bool);
		}

		public bool IsPostExtrapolatedTime(double sequenceTime)
		{
			return default(bool);
		}

		private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration)
		{
			return default(double);
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public override string ToString()
		{
			return null;
		}

		private void UpdateDirty(double oldValue, double newValue)
		{
		}
	}
}
