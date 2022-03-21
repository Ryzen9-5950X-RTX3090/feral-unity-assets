using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public class CinemachineImpulseManager
	{
		[Serializable]
		public struct EnvelopeDefinition
		{
			[Tooltip("Normalized curve defining the shape of the start of the envelope.  If blank a default curve will be used")]
			public AnimationCurve m_AttackShape;

			[Tooltip("Normalized curve defining the shape of the end of the envelope.  If blank a default curve will be used")]
			public AnimationCurve m_DecayShape;

			[Tooltip("Duration in seconds of the attack.  Attack curve will be scaled to fit.  Must be >= 0.")]
			public float m_AttackTime;

			[Tooltip("Duration in seconds of the central fully-scaled part of the envelope.  Must be >= 0.")]
			public float m_SustainTime;

			[Tooltip("Duration in seconds of the decay.  Decay curve will be scaled to fit.  Must be >= 0.")]
			public float m_DecayTime;

			[Tooltip("If checked, signal amplitude scaling will also be applied to the time envelope of the signal.  Stronger signals will last longer.")]
			public bool m_ScaleWithImpact;

			[Tooltip("If true, then duration is infinite.")]
			public bool m_HoldForever;

			public float Duration
			{
				get
				{
					return default(float);
				}
			}

			public static EnvelopeDefinition Default()
			{
				return default(EnvelopeDefinition);
			}

			public float GetValueAt(float offset)
			{
				return default(float);
			}

			public void Clear()
			{
			}

			public void Validate()
			{
			}
		}

		public class ImpulseEvent
		{
			public enum DirectionMode
			{
				Fixed,
				RotateTowardSource
			}

			public enum DissipationMode
			{
				LinearDecay,
				SoftDecay,
				ExponentialDecay
			}

			[Tooltip("Start time of the event.")]
			public float m_StartTime;

			[Tooltip("Time-envelope of the signal.")]
			public EnvelopeDefinition m_Envelope;

			[Tooltip("Raw signal source.  The ouput of this will be scaled to fit in the envelope.")]
			public ISignalSource6D m_SignalSource;

			[Tooltip("Worldspace origin of the signal.")]
			public Vector3 m_Position;

			[Tooltip("Radius around the signal origin that has full signal value.  Distance dissipation begins after this distance.")]
			public float m_Radius;

			[Tooltip("How the signal direction behaves as the listener moves away from the source.")]
			public DirectionMode m_DirectionMode;

			[Tooltip("Channels on which this event will broadcast its signal.")]
			public int m_Channel;

			[Tooltip("How the signal dissipates with distance.")]
			public DissipationMode m_DissipationMode;

			[Tooltip("Distance over which the dissipation occurs.  Must be >= 0.")]
			public float m_DissipationDistance;

			[Tooltip("The speed (m/s) at which the impulse propagates through space.  High speeds allow listeners to react instantaneously, while slower speeds allow listeres in the scene to react as if to a wave spreading from the source.")]
			public float m_PropagationSpeed;

			public bool Expired
			{
				get
				{
					return default(bool);
				}
			}

			public float DistanceDecay(float distance)
			{
				return default(float);
			}

			public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot)
			{
				return default(bool);
			}

			public void Clear()
			{
			}

			internal ImpulseEvent()
			{
			}
		}

		private static CinemachineImpulseManager sInstance;

		private const float Epsilon = 0.0001f;

		private List<ImpulseEvent> m_ExpiredEvents;

		private List<ImpulseEvent> m_ActiveEvents;

		public static CinemachineImpulseManager Instance
		{
			get
			{
				return null;
			}
		}

		public bool IgnoreTimeScale
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float CurrentTime
		{
			get
			{
				return default(float);
			}
		}

		private CinemachineImpulseManager()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule()
		{
		}

		public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot)
		{
			return default(bool);
		}

		public ImpulseEvent NewImpulseEvent()
		{
			return null;
		}

		public void AddImpulseEvent(ImpulseEvent e)
		{
		}

		public void Clear()
		{
		}
	}
}
