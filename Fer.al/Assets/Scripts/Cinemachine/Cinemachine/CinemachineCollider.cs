using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[ExecuteAlways]
	[SaveDuringPlay]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/CinemachineCollider.html")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu("")]
	public class CinemachineCollider : CinemachineExtension
	{
		public enum ResolutionStrategy
		{
			PullCameraForward,
			PreserveCameraHeight,
			PreserveCameraDistance
		}

		private class VcamExtraState
		{
			public Vector3 m_previousDisplacement;

			public Vector3 m_previousDisplacementCorrection;

			public float colliderDisplacement;

			public bool targetObscured;

			public float occlusionStartTime;

			public List<Vector3> debugResolutionPath;

			private float m_SmoothedDistance;

			private float m_SmoothedTime;

			public void AddPointToDebugPath(Vector3 p)
			{
			}

			public float ApplyDistanceSmoothing(float distance, float smoothingTime)
			{
				return default(float);
			}

			public void UpdateDistanceSmoothing(float distance, float smoothingTime)
			{
			}

			public void ResetDistanceSmoothing(float smoothingTime)
			{
			}
		}

		[Tooltip("Objects on these layers will be detected")]
		[Header("Obstacle Detection")]
		public LayerMask m_CollideAgainst;

		[TagField]
		[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
		public string m_IgnoreTag;

		[Tooltip("Objects on these layers will never obstruct view of the target")]
		public LayerMask m_TransparentLayers;

		[Tooltip("Obstacles closer to the target than this will be ignored")]
		public float m_MinimumDistanceFromTarget;

		[Space]
		[Tooltip("When enabled, will attempt to resolve situations where the line of sight to the target is blocked by an obstacle")]
		[FormerlySerializedAs("m_PreserveLineOfSight")]
		public bool m_AvoidObstacles;

		[Tooltip("The maximum raycast distance when checking if the line of sight to this camera's target is clear.  If the setting is 0 or less, the current actual distance to target will be used.")]
		[FormerlySerializedAs("m_LineOfSightFeelerDistance")]
		public float m_DistanceLimit;

		[Tooltip("Don't take action unless occlusion has lasted at least this long.")]
		public float m_MinimumOcclusionTime;

		[Tooltip("Camera will try to maintain this distance from any obstacle.  Try to keep this value small.  Increase it if you are seeing inside obstacles due to a large FOV on the camera.")]
		public float m_CameraRadius;

		[Tooltip("The way in which the Collider will attempt to preserve sight of the target.")]
		public ResolutionStrategy m_Strategy;

		[Range(1f, 10f)]
		[Tooltip("Upper limit on how many obstacle hits to process.  Higher numbers may impact performance.  In most environments, 4 is enough.")]
		public int m_MaximumEffort;

		[Tooltip("Smoothing to apply to obstruction resolution.  Nearest camera point is held for at least this long")]
		public float m_SmoothingTime;

		[FormerlySerializedAs("m_Smoothing")]
		[Range(0f, 10f)]
		[Tooltip("How gradually the camera returns to its normal position after having been corrected.  Higher numbers will move the camera more gradually back to normal.")]
		public float m_Damping;

		[Range(0f, 10f)]
		[Tooltip("How gradually the camera moves to resolve an occlusion.  Higher numbers will move the camera more gradually.")]
		public float m_DampingWhenOccluded;

		[Header("Shot Evaluation")]
		[Tooltip("If greater than zero, a higher score will be given to shots when the target is closer to this distance.  Set this to zero to disable this feature.")]
		public float m_OptimalTargetDistance;

		private const float PrecisionSlush = 0.001f;

		private RaycastHit[] m_CornerBuffer;

		private const float AngleThreshold = 0.1f;

		private Collider[] mColliderBuffer;

		private static SphereCollider mCameraCollider;

		private static GameObject mCameraColliderGameObject;

		public List<List<Vector3>> DebugPaths
		{
			get
			{
				return null;
			}
		}

		public bool IsTargetObscured(ICinemachineCamera vcam)
		{
			return default(bool);
		}

		public bool CameraWasDisplaced(ICinemachineCamera vcam)
		{
			return default(bool);
		}

		public float GetCameraDisplacementDistance(ICinemachineCamera vcam)
		{
			return default(float);
		}

		private void OnValidate()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override float GetMaxDampTime()
		{
			return default(float);
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		private Vector3 PreserveLignOfSight(ref CameraState state, ref VcamExtraState extra)
		{
			return default(Vector3);
		}

		private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo)
		{
			return default(Vector3);
		}

		private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra)
		{
			return default(Vector3);
		}

		private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir)
		{
			return default(bool);
		}

		private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos)
		{
			return default(float);
		}

		private float ClampRayToBounds(Ray ray, float distance, Bounds bounds)
		{
			return default(float);
		}

		private static void DestroyCollider()
		{
		}

		private Vector3 RespectCameraRadius(Vector3 cameraPos, ref CameraState state)
		{
			return default(Vector3);
		}

		private bool CheckForTargetObstructions(CameraState state)
		{
			return default(bool);
		}

		private bool IsTargetOffscreen(CameraState state)
		{
			return default(bool);
		}
	}
}
