using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[AddComponentMenu("")]
	public class Cinemachine3rdPersonFollow : CinemachineComponentBase
	{
		[Tooltip("How responsively the camera tracks the target.  Each axis (camera-local) can have its own setting.  Value is the approximate time it takes the camera to catch up to the target's new position.  Smaller values give a more rigid effect, larger values give a squishier one")]
		public Vector3 Damping;

		[Header("Rig")]
		[Tooltip("Position of the shoulder pivot relative to the Follow target origin.  This offset is in target-local space")]
		public Vector3 ShoulderOffset;

		[Tooltip("Vertical offset of the hand in relation to the shoulder.  Arm length will affect the follow target's screen position when the camera rotates vertically")]
		public float VerticalArmLength;

		[Range(0f, 1f)]
		[Tooltip("Specifies which shoulder (left, right, or in-between) the camera is on")]
		public float CameraSide;

		[Tooltip("How far baehind the hand the camera will be placed")]
		public float CameraDistance;

		[Header("Obstacles")]
		[Tooltip("Camera will avoid obstacles on these layers")]
		public LayerMask CameraCollisionFilter;

		[TagField]
		[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
		public string IgnoreTag;

		[Range(0f, 1f)]
		[Tooltip("Specifies how close the camera can get to obstacles")]
		public float CameraRadius;

		private Vector3 m_PreviousFollowTargetPosition;

		private Vector3 m_DampingCorrection;

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

		private void Reset()
		{
		}

		private void OnDestroy()
		{
		}

		public override float GetMaxDampTime()
		{
			return default(float);
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		private void PositionCamera(ref CameraState curState, float deltaTime)
		{
		}

		public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand)
		{
		}

		private Quaternion GetHeading(Vector3 targetForward, Vector3 up)
		{
			return default(Quaternion);
		}

		private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand)
		{
		}

		private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float cameraRadius)
		{
			return default(Vector3);
		}
	}
}
