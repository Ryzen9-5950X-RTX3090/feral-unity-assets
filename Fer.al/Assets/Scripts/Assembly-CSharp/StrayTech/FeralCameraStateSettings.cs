using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace StrayTech
{
	[Serializable]
	public class FeralCameraStateSettings : ICameraStateSettings
	{
		public enum CameraModeOverride
		{
			None,
			ThirdPerson,
			FirstPerson
		}

		public enum CursorModeOverride
		{
			None,
			HideCursor,
			ShowCursor
		}

		[NonSerialized]
		public FeralCameraStateSettings StateSettingsOverride;

		public float overrideBlend;

		[SerializeField]
		[Header("Camera")]
		[Tooltip("FOV")]
		private float _cameraFov;

		[SerializeField]
		[Tooltip("Clipping plane (Near, Far)")]
		private Vector2 _cameraClippingLowQuality;

		[SerializeField]
		private Vector2 _cameraClippingMediumQuality;

		[SerializeField]
		[FormerlySerializedAs("_cameraClipping")]
		private Vector2 _cameraClippingHighQuality;

		[SerializeField]
		[Header("Mode Overrides")]
		[Tooltip("Use to force camera mode for this Feral Camera State")]
		private CameraModeOverride _overrideCameraMode;

		[SerializeField]
		[Tooltip("Use to force cursor mode for this Feral Camera State")]
		private CursorModeOverride _overrideCursorMode;

		[SerializeField]
		[Header("Recentering")]
		[Tooltip("Recenter behind target when not orbiting")]
		private bool _useRecentering;

		[SerializeField]
		[Range(0.5f, 10f)]
		[Tooltip("The amount of smoothing to apply during recenter/follow")]
		private float _recenterSmoothingSpeed;

		[SerializeField]
		[Tooltip("Don't recenter when standing still.")]
		private bool _recenteringOnlyOnMove;

		[SerializeField]
		[Tooltip("Recenter when target moving faster than this velocity.")]
		[Range(0f, 1f)]
		private float _recenteringAtVelocity;

		[SerializeField]
		[Tooltip("Recenter position will be flipped 180 degrees (centers in front of player instead of behind)")]
		private bool _recenterReversed;

		[SerializeField]
		[Header("Panning")]
		[Tooltip("Allows panning controls on this camera state.")]
		private bool _allowPanning;

		[SerializeField]
		private float _panSpeed;

		[SerializeField]
		[Header("Mouse Orbiting")]
		[Tooltip("Use the mouse to control the camera's orbit.")]
		private bool _useMouseOrbiting;

		[SerializeField]
		[Tooltip("The distance of the camera from the target.")]
		private float _mouseOrbitingDistance;

		[SerializeField]
		[Tooltip("The range of vertical rotation.")]
		private Vector2 _mouseOrbitingPitchRange;

		[SerializeField]
		[Tooltip("Sensitivity of mouse movement on each axis.")]
		private Vector2 _mouseOrbitingSensitivity;

		[SerializeField]
		[Tooltip("Invert mouse Y axis?")]
		private bool _mouseOrbitingInvertY;

		[SerializeField]
		[Range(0.5f, 10f)]
		[Tooltip("The amount of smoothing to apply during orbit.")]
		private float _mouseOrbitingSmoothingSpeed;

		[SerializeField]
		[Header("Mouse Zooming")]
		[Tooltip("Use scroll wheel to zoom")]
		private bool _useMouseZooming;

		[SerializeField]
		[Tooltip("The percentage of mouse zoom distance at start.")]
		private float _mouseZoomingInitialPercentage;

		[SerializeField]
		[Tooltip("The minimum and maximum distance the camera can be from the target.")]
		private Vector2 _mouseZoomingDistance;

		[SerializeField]
		[Tooltip("Adjust pitch based on zoom.")]
		private Vector2 _mouseZoomingPitch;

		[SerializeField]
		[Tooltip("Adjust offset based on zoom.")]
		private Vector3 _mouseZoomingOffsetMin;

		[SerializeField]
		[Tooltip("Adjust offset based on zoom.")]
		private Vector3 _mouseZoomingOffsetMax;

		[SerializeField]
		[Header("Look Ahead Pitch Adjustment")]
		[Tooltip("Adjust pitch based on slope ahead of player")]
		private bool _useLookAheadPitchAdjustment;

		[SerializeField]
		[Range(0.5f, 10f)]
		[Tooltip("The amount of smoothing to apply during pitch adjustment")]
		private float _pitchAdjustmentSmoothingSpeed;

		[SerializeField]
		[Header("Collision")]
		[Tooltip("Whether to use camera collision or not. (Requires Camera Collision Component mentioned above)")]
		private bool _useCameraCollision;

		public float CameraFov
		{
			get
			{
				return default(float);
			}
		}

		public Vector2 CameraClipping
		{
			get
			{
				return default(Vector2);
			}
		}

		public CameraModeOverride OverrideCameraMode
		{
			get
			{
				return default(CameraModeOverride);
			}
		}

		public CursorModeOverride OverrideCursorMode
		{
			get
			{
				return default(CursorModeOverride);
			}
		}

		public bool UseRecentering
		{
			get
			{
				return default(bool);
			}
		}

		public float RecenterSmoothingSpeed
		{
			get
			{
				return default(float);
			}
		}

		public bool RecenteringOnlyOnMove
		{
			get
			{
				return default(bool);
			}
		}

		public float RecenteringAtVelocity
		{
			get
			{
				return default(float);
			}
		}

		public bool RecenterReversed
		{
			get
			{
				return default(bool);
			}
		}

		public bool AllowPanning
		{
			get
			{
				return default(bool);
			}
		}

		public float PanSpeed
		{
			get
			{
				return default(float);
			}
		}

		public bool UseMouseOrbiting
		{
			get
			{
				return default(bool);
			}
		}

		public float MouseOrbitingDistance
		{
			get
			{
				return default(float);
			}
		}

		public Vector2 MouseOrbitingPitchRange
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 MouseOrbitingSensitivity
		{
			get
			{
				return default(Vector2);
			}
		}

		public bool MouseOrbitingInvertY
		{
			get
			{
				return default(bool);
			}
		}

		public float MouseOrbitingSmoothingSpeed
		{
			get
			{
				return default(float);
			}
		}

		public bool UseMouseZooming
		{
			get
			{
				return default(bool);
			}
		}

		public float MouseZoomingInitialPercentage
		{
			get
			{
				return default(float);
			}
		}

		public Vector2 MouseZoomingDistance
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 MouseZoomingPitch
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 MouseZoomingOffsetMin
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 MouseZoomingOffsetMax
		{
			get
			{
				return default(Vector2);
			}
		}

		public bool UseLookAheadPitchAdjustment
		{
			get
			{
				return default(bool);
			}
		}

		public float PitchAdjustmentSmoothingSpeed
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

		public void Overwrite(FeralCameraStateSettings inSettings)
		{
		}

		public FeralCameraStateSettings()
		{
		}

		public FeralCameraStateSettings(FeralCameraStateSettings inSettings)
		{
		}
	}
}
