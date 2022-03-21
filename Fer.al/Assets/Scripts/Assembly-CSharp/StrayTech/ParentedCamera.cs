using System.Runtime.CompilerServices;
using UnityEngine;

namespace StrayTech
{
	public class ParentedCamera : ICameraState
	{
		private ParentedCameraStateSettings _stateSettings;

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

		public ParentedCamera(ICameraStateSettings stateSettings)
		{
		}

		public void UpdateCamera(float deltaTime)
		{
		}

		public void Cleanup()
		{
		}
	}
}
