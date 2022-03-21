using System;
using UnityEngine;

namespace StrayTech
{
	[Serializable]
	public class IsometricCameraStateSettings : ICameraStateSettings
	{
		[SerializeField]
		[Tooltip("World space Euler rotation to lock the cameraâ\u0080\u0099s view to.")]
		private Vector3 _rotation;

		[SerializeField]
		[Tooltip("The distance the camera will be from the target.")]
		private float _distance;

		[SerializeField]
		[Tooltip("Whether to use camera collision or not. (Requires Camera Collision Component mentioned above)")]
		private bool _useCameraCollision;

		public Vector3 Rotation
		{
			get
			{
				return default(Vector3);
			}
		}

		public float Distance
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

		public IsometricCameraStateSettings(Vector3 rotation, float distance)
		{
		}
	}
}
