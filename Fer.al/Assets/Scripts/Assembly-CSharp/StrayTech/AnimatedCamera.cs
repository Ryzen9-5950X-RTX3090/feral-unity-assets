using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace StrayTech
{
	public class AnimatedCamera : ICameraState, IValidates
	{
		public class OnFinishedEventArgs
		{
			private bool _animationFinished;

			public bool AnimationFinished
			{
				get
				{
					return default(bool);
				}
			}

			public OnFinishedEventArgs(bool animationFinished)
			{
			}
		}

		private AnimatedCameraStateSettings _stateSettings;

		private float _clipDuration;

		private float _currentClipTime;

		private bool _animationComplete;

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

		public event Action<OnFinishedEventArgs> OnFinished
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public AnimatedCamera(ICameraStateSettings stateSettings)
		{
		}

		public void StopCurrentAnimation()
		{
		}

		public void UpdateCamera(float deltaTime)
		{
		}

		public void Cleanup()
		{
		}

		public bool IsValid()
		{
			return default(bool);
		}
	}
}
