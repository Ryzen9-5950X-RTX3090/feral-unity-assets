using UnityEngine;

namespace StrayTech
{
	public class CameraCollision : MonoBehaviourSingleton<CameraCollision>
	{
		public enum CollisionTestType
		{
			SphereCast,
			RayCast
		}

		private float? _lastDistance;

		private float _currentSmoothDampVelocity;

		[SerializeField]
		[Tooltip("Globally toggle camera collision on and off.")]
		private bool _useCameraCollision;

		[SerializeField]
		[Tooltip("Type of camera collsion.")]
		private CollisionTestType _testType;

		[SerializeField]
		[Tooltip("Radius of the sphere for sphere casts.")]
		private float _sphereRadius;

		[SerializeField]
		[Tooltip("Smoothing time.")]
		private float _smoothingTime;

		[SerializeField]
		[Tooltip("Layers to collide with.")]
		private LayerMask _collisionLayerMask;

		[SerializeField]
		private Transform _editorDebugCollisionTransform;

		public bool UseCameraCollision
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public CollisionTestType TestType
		{
			get
			{
				return default(CollisionTestType);
			}
		}

		public float SphereRadius
		{
			get
			{
				return default(float);
			}
		}

		public LayerMask CollisionLayerMask
		{
			get
			{
				return default(LayerMask);
			}
		}

		public void PreventCameraCollision(Camera camera)
		{
		}
	}
}
