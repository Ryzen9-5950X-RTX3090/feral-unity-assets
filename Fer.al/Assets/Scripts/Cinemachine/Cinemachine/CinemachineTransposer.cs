using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineTransposer : CinemachineComponentBase
	{
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum BindingMode
		{
			LockToTargetOnAssign,
			LockToTargetWithWorldUp,
			LockToTargetNoRoll,
			LockToTarget,
			WorldSpace,
			SimpleFollowWithWorldUp
		}

		public enum AngularDampingMode
		{
			Euler,
			Quaternion
		}

		[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera's Up vector, which will be maintained when aiming the camera.")]
		public BindingMode m_BindingMode;

		[Tooltip("The distance vector that the transposer will attempt to maintain from the Follow target")]
		public Vector3 m_FollowOffset;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain the offset in the X-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_XDamping;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain the offset in the Y-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_YDamping;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain the offset in the Z-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_ZDamping;

		public AngularDampingMode m_AngularDampingMode;

		[Tooltip("How aggressively the camera tries to track the target rotation's X angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		[Range(0f, 20f)]
		public float m_PitchDamping;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target rotation's Y angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_YawDamping;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target rotation's Z angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_RollDamping;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target's orientation.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_AngularDamping;

		private Vector3 m_PreviousTargetPosition;

		private Quaternion m_PreviousReferenceOrientation;

		private Quaternion m_targetOrientationOnAssign;

		private Vector3 m_PreviousOffset;

		private Transform m_previousTarget;

		public bool HideOffsetInInspector
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

		public Vector3 EffectiveOffset
		{
			get
			{
				return default(Vector3);
			}
		}

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

		protected Vector3 Damping
		{
			get
			{
				return default(Vector3);
			}
		}

		protected Vector3 AngularDamping
		{
			get
			{
				return default(Vector3);
			}
		}

		protected virtual void OnValidate()
		{
		}

		public override float GetMaxDampTime()
		{
			return default(float);
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public override void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime)
		{
		}

		protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient)
		{
		}

		protected Vector3 GetOffsetForMinimumTargetDistance(Vector3 dampedTargetPos, Vector3 cameraOffset, Vector3 cameraFwd, Vector3 up, Vector3 actualTargetPos)
		{
			return default(Vector3);
		}

		public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp)
		{
			return default(Vector3);
		}

		public Quaternion GetReferenceOrientation(Vector3 worldUp)
		{
			return default(Quaternion);
		}
	}
}
