using System;
using UnityEngine;

namespace StrayTech
{
	[Serializable]
	public class SplineCameraStateSettings : ICameraStateSettings
	{
		[SerializeField]
		[Tooltip("The spline to use.")]
		private BezierSpline _spline;

		[SerializeField]
		[Tooltip("Offset the camera on the spline from the start in world units of length.")]
		private float _splinePositionOffset;

		[SerializeField]
		[Tooltip("Offset along the line of sight to the target.")]
		private float _cameraLineOfSightOffset;

		[SerializeField]
		[Tooltip("Maximum distance the camera can be from the target.")]
		private float _cameraMaxDistance;

		[SerializeField]
		[Tooltip("The maximum speed the camera can travel along the spline in world units of length per second.")]
		private float _splineTravelMaxSpeed;

		[SerializeField]
		[Tooltip("Whether to use camera collision or not. (Requires Camera Collision Component mentioned above)")]
		private bool _useCameraCollision;

		public BezierSpline Spline
		{
			get
			{
				return null;
			}
		}

		public float SplinePositionOffset
		{
			get
			{
				return default(float);
			}
		}

		public float CameraLineOfSightOffset
		{
			get
			{
				return default(float);
			}
		}

		public float CameraMaxDistance
		{
			get
			{
				return default(float);
			}
		}

		public float SplineTravelMaxSpeed
		{
			get
			{
				return default(float);
			}
		}

		public bool UseCameraCollision
		{
			get
			{
				return default(bool);
			}
		}

		public CameraSystem.CameraStateEnum StateType
		{
			get
			{
				return default(CameraSystem.CameraStateEnum);
			}
		}

		public SplineCameraStateSettings(BezierSpline spline, float splinePositionOffset, float cameraLineOfSightOffset, float cameraMaxDistance, float splineTravelMaxSpeed)
		{
		}
	}
}
