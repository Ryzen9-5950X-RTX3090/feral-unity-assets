using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/api/Cinemachine.CinemachineIndependentImpulseListener.html")]
	public class CinemachineIndependentImpulseListener : MonoBehaviour
	{
		private Vector3 impulsePosLastFrame;

		private Quaternion impulseRotLastFrame;

		[CinemachineImpulseChannelProperty]
		[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
		public int m_ChannelMask;

		[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
		public float m_Gain;

		[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
		public bool m_Use2DDistance;

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
