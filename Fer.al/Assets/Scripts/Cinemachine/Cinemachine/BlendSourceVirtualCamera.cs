using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	internal class BlendSourceVirtualCamera : ICinemachineCamera
	{
		[CompilerGenerated]
		private int <Priority>k__BackingField;

		[CompilerGenerated]
		private Transform <LookAt>k__BackingField;

		[CompilerGenerated]
		private Transform <Follow>k__BackingField;

		public CinemachineBlend Blend
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public int Priority
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public Transform LookAt
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Transform Follow
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public CameraState State
		{
			[CompilerGenerated]
			get
			{
				return default(CameraState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GameObject VirtualCameraGameObject
		{
			get
			{
				return null;
			}
		}

		public bool IsValid
		{
			get
			{
				return default(bool);
			}
		}

		public ICinemachineCamera ParentCamera
		{
			get
			{
				return null;
			}
		}

		public BlendSourceVirtualCamera(CinemachineBlend blend)
		{
		}

		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default(bool);
		}

		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}
	}
}
