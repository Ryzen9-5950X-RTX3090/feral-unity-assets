using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Candlelight;
using Cinemachine;
using StrayTech;
using UnityEngine;

public class PlayerCamera : ManagedBehaviour
{
	[SerializeField]
	[Header("Cameras")]
	private Camera _camera;

	[SerializeField]
	[EnumList(typeof(PlayerCameraMode), 0.35f)]
	private List<CinemachineVirtualCameraBase> virtualCameras;

	[SerializeField]
	[EnumList(typeof(PlayerCameraMode), 0.35f)]
	private List<CameraStateDefinition> cameraStates;

	[Header("Targets")]
	public Transform targetPlayerTransform;

	public Transform targetPlayerCameraPositionTransform;

	private Transform _targetTransform;

	[SerializeField]
	private List<CameraStateModifierBase> _selfieCameraModifiers;

	[SerializeField]
	private Transform _selfieTargetTransform;

	[SerializeField]
	private Camera _selfieCam;

	private bool _inSelfieMode;

	private Transform _savedCameraTarget;

	[SerializeField]
	private RuntimePlatform[] _disabledPostProcessOnPlatforms;

	[Space]
	[SerializeField]
	private CameraSystem _cachedCameraSystem;

	[SerializeField]
	private CinemachineBrain _cachedBrain;

	private List<Landmark> _landmarks;

	[SerializeField]
	[PropertyBackingField]
	private PlayerCameraMode _mode;

	public static PlayerCamera instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Camera CachedCamera
	{
		get
		{
			return null;
		}
	}

	public List<CinemachineVirtualCameraBase> VirtualCameras
	{
		get
		{
			return null;
		}
	}

	public Transform targetTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Camera SelfieCam
	{
		get
		{
			return null;
		}
	}

	public bool SelfieModeActive
	{
		get
		{
			return default(bool);
		}
	}

	public CameraSystem CachedCameraSystem
	{
		get
		{
			return null;
		}
	}

	public CinemachineBrain CachedBrain
	{
		get
		{
			return null;
		}
	}

	public PlayerCameraMode Mode
	{
		get
		{
			return default(PlayerCameraMode);
		}
		set
		{
		}
	}

	private void OnSanctuaryCameraMessage(SanctuaryCameraMessage inMessage)
	{
	}

	private void OnPlayerCameraMessage(PlayerCameraMessage inMessage)
	{
	}

	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 n)
	{
		return default(float);
	}

	public void UpdateTargetPlayerTransform()
	{
	}

	public void EnableSelfieMode()
	{
	}

	public void DisableSelfieMode()
	{
	}

	public void SetSelfieModeFov(float inFov)
	{
	}

	public void ResetSeflieTargetPosition()
	{
	}

	public List<string> GetLandmarksOrItemsInView()
	{
		return null;
	}

	private void OnLandmarkMessage(LandmarkMessage inMessage)
	{
	}

	private List<Landmark> GetLandmarksInView()
	{
		return null;
	}

	private List<string> GetChallengeItemsInView()
	{
		return null;
	}

	private List<string> GetChallengeItems()
	{
		return null;
	}

	private void FindSanctuaryItemsInView(List<string> itemsToLookFor, ref List<string> itemsInView)
	{
	}

	public Quaternion GetLevelCameraForwardRotation()
	{
		return default(Quaternion);
	}

	public override void MAwake()
	{
	}

	public override void MOnDestroy()
	{
	}

	public void LateUpdate()
	{
	}

	private void SwitchedModes()
	{
	}

	public void ActivateVirtualCameraOrState(PlayerCameraMode inMode)
	{
	}

	public void DeactivateAllVirtualCamerasAndStates()
	{
	}

	public CameraStateDefinition GetCameraStateByMode(PlayerCameraMode inMode)
	{
		return null;
	}

	public T GetVirtualCameraByMode<T>(PlayerCameraMode inMode) where T : CinemachineVirtualCameraBase
	{
		return null;
	}

	public int GetVirtualCameraIndex(PlayerCameraMode inMode)
	{
		return default(int);
	}
}
