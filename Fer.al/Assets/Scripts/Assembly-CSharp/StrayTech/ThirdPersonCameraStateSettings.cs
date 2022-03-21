using System;
using StrayTech.CustomAttributes;
using UnityEngine;

namespace StrayTech
{
	[Serializable]
	public class ThirdPersonCameraStateSettings : ICameraStateSettings
	{
		[SerializeField]
		[Tooltip("Use the mouse to control the camera's orbit.")]
		private bool _mouseOrbit;

		[SerializeField]
		[Tooltip("The position offset from the target.")]
		private Vector3 _targetOffset;

		[SerializeField]
		[Tooltip("The minimum and maximum distance the camera can be from the target.")]
		private Vector2 _mouseOrbitDistance;

		[SerializeField]
		[Tooltip("The range of vertical rotation.")]
		private Vector2 _mousePitchRange;

		[SerializeField]
		[Tooltip("Sensitivity of mouse movement on each axis.")]
		private Vector2 _mouseSensitivity;

		[SerializeField]
		[Tooltip("Invert mouse Y axis?")]
		private bool _mouseInvertY;

		[SerializeField]
		[NonNegative]
		[Tooltip("The amount of smoothing to apply.")]
		private float _motionSmoothing;

		[SerializeField]
		[Tooltip("Whether to use camera collision or not. (Requires Camera Collision Component mentioned above)")]
		private bool _useCameraCollision;

		public bool MouseOrbit
		{
			get
			{
				return default(bool);
			}
		}

		public Vector3 TargetOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector2 MouseOrbitDistance
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 MousePitchRange
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 MouseSensitivity
		{
			get
			{
				return default(Vector2);
			}
		}

		public bool MouseInvertY
		{
			get
			{
				return default(bool);
			}
		}

		public float MotionSmoothing
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

		public ThirdPersonCameraStateSettings(Vector3 targetOffset, bool mouseOrbit, Vector2 mouseOrbitDistance, Vector2 mousePitchRange, Vector2 mouseSensitivity, bool mouseInvertY, float motionSmoothing)
		{
		}
	}
}
