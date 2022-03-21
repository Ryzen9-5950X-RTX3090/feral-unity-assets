using System;
using System.Collections.Generic;
using UnityEngine;

namespace StrayTech
{
	[RenderHierarchyIcon("Assets/StrayTech/Camera System/Graphics/CameraSystem.png")]
	public class CameraSystem : MonoBehaviourSingleton<CameraSystem>
	{
		public enum CameraStateEnum
		{
			Isometric,
			Spline,
			FirstPerson,
			ThirdPerson,
			Animated,
			Pivot,
			Parented,
			Feral
		}

		public enum StateTransitionType
		{
			Interpolation,
			Crossfade,
			Instant
		}

		public enum StateTransitionTypeInternal
		{
			Interpolation,
			Crossfade,
			Instant,
			InterpolatedCrossfade
		}

		public enum CameraSystemStatus
		{
			Active,
			Transitioning,
			Inactive
		}

		[Serializable]
		public class UserDefinedFlag
		{
			[SerializeField]
			private string _name;

			[SerializeField]
			private bool _value;

			public string Name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool Value
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
		}

		[SerializeField]
		[Tooltip("The target for most of the camera states that require a target.")]
		private Transform _cameraTarget;

		[SerializeField]
		[Tooltip("The default Camera State.")]
		private CameraStateDefinition _defaultCameraState;

		[SerializeField]
		[Tooltip("Use FixedUpdate for physics based camera tracking.")]
		private bool _useFixedUpdate;

		[SerializeField]
		[Tooltip("User defined flags.")]
		private List<UserDefinedFlag> _userDefinedFlags;

		private CameraSystemStatus _systemStatus;

		private Camera _defaultCamera;

		private Camera _currentCamera;

		private Camera _nextCamera;

		private float _stateTransitionRamp;

		private StateTransitionTypeInternal _currentTransitionType;

		private LinkedList<CameraStateDefinition> _stateDefinitionHistory;

		private Queue<CameraStateDefinition> _stateDefinitionsToAdd;

		private Queue<CameraStateDefinition> _stateDefinitionsToRemove;

		private CameraStateDefinition _cameraStateOverride;

		private CameraStateDefinition _currentCameraStateDefinition;

		private CameraStateDefinition _nextCameraStateDefinition;

		private CameraStateDefinition _currentTransitionHost;

		private bool _transitionInteruptTransition;

		private List<CameraStateModifierBase> _cameraModifiers;

		private RenderTexture _cameraRenderTexture;

		private CrossfadePostProcess _crossfadePostProcess;

		private bool _shouldUpdate;

		private Vector3 _cachedCameraPosition;

		private Quaternion _cachedCameraRotation;

		private Dictionary<string, bool> _userDefinedFlagsLookup;

		private AnimationCurve _cameraInterpolationCurve;

		private float _cameraTargetVelocity;

		private Vector3 _cameraTargetLastPosition;

		public CameraSystemStatus SystemStatus
		{
			get
			{
				return default(CameraSystemStatus);
			}
		}

		public CameraStateDefinition CurrentCameraStateDefinition
		{
			get
			{
				return null;
			}
		}

		public CameraStateDefinition NextCameraStateDefinition
		{
			get
			{
				return null;
			}
		}

		public StateTransitionTypeInternal CurrentTransitionType
		{
			get
			{
				return default(StateTransitionTypeInternal);
			}
		}

		public Camera CurrentCamera
		{
			get
			{
				return null;
			}
		}

		public Camera NextCamera
		{
			get
			{
				return null;
			}
		}

		public AnimationCurve CameraInterpolationCurve
		{
			get
			{
				return null;
			}
		}

		public float CurrentInterpolationCurveSample
		{
			get
			{
				return default(float);
			}
		}

		public RenderTexture CameraRenderTexture
		{
			get
			{
				return null;
			}
		}

		public List<CameraStateModifierBase> CameraStateModifiers
		{
			get
			{
				return null;
			}
		}

		public float CameraTargetVelocity
		{
			get
			{
				return default(float);
			}
		}

		public bool ShouldUpdate
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Transform CameraTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void DoCameraUpdate(float deltaTime)
		{
		}

		private void OnLateUpdate()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void SetCameraStateTempOverride(CameraStateDefinition newState)
		{
		}

		public void RegisterCameraState(CameraStateDefinition newState)
		{
		}

		public void UnregisterCameraState(CameraStateDefinition oldState)
		{
		}

		private void ManageQueuedTransitions()
		{
		}

		private void ActivateTransition(CameraStateDefinition toState, CameraStateDefinition transitionHost)
		{
		}

		private void HandleInstantTransition()
		{
		}

		private void HandleInterpolationTransition()
		{
		}

		private void HandleCrossfadeTransition()
		{
		}

		private void HandleInterpolatedCrossfadeTransition()
		{
		}

		private void FinalizeTransition()
		{
		}

		public void AddModifier(CameraStateModifierBase modifier)
		{
		}

		public void RemoveModifier(CameraStateModifierBase modifier)
		{
		}

		public void ChangeCameraFOV(float fov)
		{
		}

		public void ChangeCameraClipping(Vector2 inClipping)
		{
		}

		private void CacheUserDefinedFlags()
		{
		}

		public bool GetUserDefinedFlagValue(string flagName)
		{
			return default(bool);
		}

		public void SetUserDefinedFlagValue(string flagName, bool flagValue)
		{
		}
	}
}
