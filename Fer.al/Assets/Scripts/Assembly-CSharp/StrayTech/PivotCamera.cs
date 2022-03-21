using System.Runtime.CompilerServices;
using UnityEngine;

namespace StrayTech
{
	public class PivotCamera : ICameraState
	{
		private PivotCameraStateSettings _stateSettings;

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

		public PivotCamera(ICameraStateSettings stateSettings)
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
