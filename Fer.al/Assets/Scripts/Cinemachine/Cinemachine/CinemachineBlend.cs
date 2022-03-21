using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachineBlend
	{
		public ICinemachineCamera CamA
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

		public ICinemachineCamera CamB
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

		public AnimationCurve BlendCurve
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

		public float TimeInBlend
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float BlendWeight
		{
			get
			{
				return default(float);
			}
		}

		public bool IsValid
		{
			get
			{
				return default(bool);
			}
		}

		public float Duration
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsComplete
		{
			get
			{
				return default(bool);
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
		}

		public CameraState State
		{
			get
			{
				return default(CameraState);
			}
		}

		public bool Uses(ICinemachineCamera cam)
		{
			return default(bool);
		}

		public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t)
		{
		}

		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}
	}
}
