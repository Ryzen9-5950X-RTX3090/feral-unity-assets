using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_TPPCameraBehaviour : MonoBehaviour
	{
		[Header("Transform to be followed by camera")]
		public Transform ToFollow;

		[Header("Offset in position in reference to target transform (focus point)")]
		public Vector3 FollowingOffset;

		[Header("Offset in position in reference to camera orientation")]
		public Vector3 FollowingOffsetDirection;

		[Header("Clamp values for zoom of camera")]
		public Vector2 DistanceRanges;

		private float targetDistance;

		private float animatedDistance;

		public Vector2 RotationRanges;

		private Vector2 targetSphericRotation;

		private Vector2 animatedSphericRotation;

		[Space]
		[Space(10f)]
		[Tooltip("Sensitivity value for rotating camera around following object")]
		public float RotationSensitivity;

		[Header("If you want camera rotation to be smooth")]
		[Range(0.1f, 1f)]
		public float RotationSpeed;

		[Header("If you want camera to follow target with some smoothness")]
		[Range(0f, 1f)]
		public float HardFollowValue;

		[Header("If you want to hold cursor (cursor switch on TAB)")]
		public bool LockCursor;

		private bool rotateCamera;

		private RaycastHit sightObstacleHit;

		[Header("Layer mask to check obstacles in sight ray")]
		public LayerMask SightLayerMask;

		private Vector3 targetPosition;

		[Header("How far forward raycast should check collision for camera")]
		public float CollisionOffset;

		public EFUpdateClock UpdateClock;

		private void Start()
		{
		}

		private void UpdateMethods()
		{
		}

		private void LateUpdate()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void InputCalculations()
		{
		}

		private void ZoomCalculations()
		{
		}

		private void FollowCalculations()
		{
		}

		private void RaycastCalculations()
		{
		}

		private void SwitchCalculations()
		{
		}

		private float HelperClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		private void HelperSwitchCursor()
		{
		}
	}
}
