using System.Runtime.CompilerServices;
using UnityEngine;

namespace StrayTech
{
	public class FirstPersonCamera : ICameraState
	{
		private FirstPersonCameraStateSettings _stateSettings;

		private Quaternion _characterTargetRot;

		private Quaternion _cameraTargetRot;

		private Quaternion _cameraPitchRotation;

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

		public FirstPersonCamera(ICameraStateSettings stateSettings)
		{
		}

		public void UpdateCamera(float deltaTime)
		{
		}

		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		public void Cleanup()
		{
		}
	}
}
