using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StrayTech;
using UnityEngine;

public class FeralCamera : ICameraState
{
	public enum CameraMode
	{
		None,
		ThirdPersonNoCursor,
		ThirdPersonCursor,
		FirstPersonNoCursor,
		FirstPersonCursor
	}

	private static FeralCameraStateSettings _stateSettings;

	private Transform _cameraLookAtTransform;

	private static float _orbitDistance;

	private float _mouseZoomingValue;

	private static float _lastFeralCameraMouseZoomingValue;

	private static float _initialOrbitGetAxisMouseX;

	private static float _initialOrbitGetAxisMouseY;

	private static Quaternion _currentOrbitRotation;

	private static float _mouseOrbitingX;

	private static float _mouseOrbitingY;

	private static float _mouseOrbitingDestX;

	private static float _mouseOrbitingDestY;

	private static bool _mouseOrbitingFirstInputX;

	private static bool _mouseOrbitingFirstInputY;

	private static bool _forceSnapRecenter;

	private static float _zoomPitch;

	private static float _lookAheadDistance;

	private static int _lookAheadSamples;

	private static float _lookAheadPitch;

	private static int _mouseOrbitingActiveFrames;

	private static bool _mouseOrbitingActive;

	private static bool _thirdPersonCursorMode;

	private static bool _firstPersonCursorMode;

	private static Dictionary<ValueTuple<bool, bool>, CameraMode> _cameraModeDict;

	private static CameraMode _lastCameraMode;

	private static List<Ray> _rays;

	private static List<RaycastHit?> _hits;

	public float OrbitDistance
	{
		get
		{
			return default(float);
		}
	}

	public static Vector2? MouseOrbitingOverride
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

	private static float CurrentLookAheadPitch
	{
		get
		{
			return default(float);
		}
	}

	private static float CurrentZoomPitch
	{
		get
		{
			return default(float);
		}
	}

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

	public static bool MouseOrbitingActive
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool FirstPersonModeOrForced
	{
		get
		{
			return default(bool);
		}
	}

	public static bool FirstPersonModeOrForcedAndDoneTransitioning
	{
		get
		{
			return default(bool);
		}
	}

	public static bool ForceThirdPersonMode
	{
		get
		{
			return default(bool);
		}
	}

	public static bool ForceFirstPersonMode
	{
		get
		{
			return default(bool);
		}
	}

	private static bool ForceCursorMode
	{
		get
		{
			return default(bool);
		}
	}

	public static bool ThirdPersonCursorMode
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool FirstPersonCursorMode
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static CameraMode CurrentCameraMode
	{
		get
		{
			return default(CameraMode);
		}
	}

	private bool AllowPanning
	{
		get
		{
			return default(bool);
		}
	}

	private bool UseMouseZooming
	{
		get
		{
			return default(bool);
		}
	}

	private float MouseOrbitingDistance
	{
		get
		{
			return default(float);
		}
	}

	public FeralCamera(ICameraStateSettings stateSettings)
	{
	}

	public void Cleanup()
	{
	}

	public void SnapToCenter()
	{
	}

	public static void ForceSnapRecenter()
	{
	}

	public static bool GetMousePanningButton(bool inDown, bool inRejectOverUI)
	{
		return default(bool);
	}

	public static bool GetMouseOrbitingButton(bool inDown, bool inRejectOverUI)
	{
		return default(bool);
	}

	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	public static float LookAheadAdjustment()
	{
		return default(float);
	}

	public void UpdateCamera(float deltaTime)
	{
	}

	private void UpdateMouseOrbit()
	{
	}

	private bool UpdateKeyboardOrbit()
	{
		return default(bool);
	}

	private bool UpdateMousePanning()
	{
		return default(bool);
	}
}
