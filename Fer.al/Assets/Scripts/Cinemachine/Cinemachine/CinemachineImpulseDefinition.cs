using System;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public class CinemachineImpulseDefinition
	{
		public enum RepeatMode
		{
			Stretch,
			Loop
		}

		private class SignalSource : ISignalSource6D
		{
			private CinemachineImpulseDefinition m_Def;

			private Vector3 m_Velocity;

			private float m_StartTimeOffset;

			public float SignalDuration
			{
				get
				{
					return default(float);
				}
			}

			public SignalSource(CinemachineImpulseDefinition def, Vector3 velocity)
			{
			}

			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot)
			{
			}
		}

		[CinemachineImpulseChannelProperty]
		[Tooltip("Impulse events generated here will appear on the channels included in the mask.")]
		public int m_ImpulseChannel;

		[Tooltip("Defines the signal that will be generated.")]
		[Header("Signal Shape")]
		[CinemachineEmbeddedAssetProperty(true)]
		public SignalSourceAsset m_RawSignal;

		[Tooltip("Gain to apply to the amplitudes defined in the signal source.  1 is normal.  Setting this to 0 completely mutes the signal.")]
		public float m_AmplitudeGain;

		[Tooltip("Scale factor to apply to the time axis.  1 is normal.  Larger magnitudes will make the signal progress more rapidly.")]
		public float m_FrequencyGain;

		[Tooltip("How to fit the signal into the envelope time")]
		public RepeatMode m_RepeatMode;

		[Tooltip("Randomize the signal start time")]
		public bool m_Randomize;

		[CinemachineImpulseEnvelopeProperty]
		[Tooltip("This defines the time-envelope of the signal.  The raw signal will be time-scaled to fit in the envelope.")]
		public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope;

		[Header("Spatial Range")]
		[Tooltip("The signal will have full amplitude in this radius surrounding the impact point.  Beyond that it will dissipate with distance.")]
		public float m_ImpactRadius;

		[Tooltip("How the signal direction behaves as the listener moves away from the origin.")]
		public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode;

		[Tooltip("This defines how the signal will dissipate with distance beyond the impact radius.")]
		public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode;

		[Tooltip("At this distance beyond the impact radius, the signal will have dissipated to zero.")]
		public float m_DissipationDistance;

		[Tooltip("The speed (m/s) at which the impulse propagates through space.  High speeds allow listeners to react instantaneously, while slower speeds allow listeners in the scene to react as if to a wave spreading from the source.")]
		public float m_PropagationSpeed;

		public void OnValidate()
		{
		}

		public void CreateEvent(Vector3 position, Vector3 velocity)
		{
		}

		public CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(Vector3 position, Vector3 velocity)
		{
			return null;
		}
	}
}
