using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachinePOV : CinemachineComponentBase
	{
		public enum RecenterTargetMode
		{
			None,
			FollowTargetForward,
			LookAtTargetForward
		}

		public RecenterTargetMode m_RecenterTarget;

		[AxisStateProperty]
		[Tooltip("The Vertical axis.  Value is -90..90. Controls the vertical orientation")]
		public AxisState m_VerticalAxis;

		[Tooltip("Controls how automatic recentering of the Vertical axis is accomplished")]
		public AxisState.Recentering m_VerticalRecentering;

		[AxisStateProperty]
		[Tooltip("The Horizontal axis.  Value is -180..180.  Controls the horizontal orientation")]
		public AxisState m_HorizontalAxis;

		[Tooltip("Controls how automatic recentering of the Horizontal axis is accomplished")]
		public AxisState.Recentering m_HorizontalRecentering;

		[HideInInspector]
		[Tooltip("Obsolete - no longer used")]
		public bool m_ApplyBeforeBody;

		public override bool IsValid
		{
			get
			{
				return default(bool);
			}
		}

		public override CinemachineCore.Stage Stage
		{
			get
			{
				return default(CinemachineCore.Stage);
			}
		}

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		public void UpdateInputAxisProvider()
		{
		}

		public override void PrePipelineMutateCameraState(ref CameraState state, float deltaTime)
		{
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public Vector2 GetRecenterTarget()
		{
			return default(Vector2);
		}

		public override void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			return default(bool);
		}

		private void SetAxesForRotation(Quaternion targetRot)
		{
		}
	}
}
