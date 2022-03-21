using System;
using UnityEngine;

namespace StrayTech
{
	[Serializable]
	public class AnimatedCameraStateSettings : ICameraStateSettings
	{
		[SerializeField]
		[Tooltip("The animation clip to play. (Needs to be a Legacy Animation Clip)")]
		private AnimationClip _animationClip;

		[SerializeField]
		[Tooltip("Use the parent override to override the root of the animation.")]
		private Transform _parentOverride;

		[SerializeField]
		[Tooltip("Y axis rotation adjustment (Some animations from Maya need adjustment)")]
		private float _yRotationFix;

		public AnimationClip AnimationClip
		{
			get
			{
				return null;
			}
		}

		public Transform ParentOverride
		{
			get
			{
				return null;
			}
		}

		public float YRotationFix
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

		public AnimatedCameraStateSettings(AnimationClip animationClipToPlay, Transform parentOverride, float yRotationFix)
		{
		}
	}
}
