using System.Runtime.CompilerServices;
using UnityEngine;

namespace StrayTech
{
	public class ThirdPersonCamera : ICameraState
	{
		private ThirdPersonCameraStateSettings _stateSettings;

		private Transform _cameraLookAtTransform;

		private float _orbitDistance;

		private float _mouseOrbitY;

		private float _mouseOrbitX;

		private Quaternion _currentOrbitRotation;

		public ICameraStateSettings StateSettings
		{
			get
			{
				return null;
			}
		}

		public CameraSystem.CameraStateEnum StateType
		{
			get
			{
				return default(CameraSystem.CameraStateEnum);
			}
		}

		public bool AllowsModifiers
		{
			get
			{
				return default(bool);
			}
		}

		public Vector3 Position
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Quaternion Rotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ThirdPersonCamera(ICameraStateSettings stateSettings)
		{
		}

		public void UpdateCamera(float deltaTime)
		{
		}

		public void Cleanup()
		{
		}

		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}
	}
}
