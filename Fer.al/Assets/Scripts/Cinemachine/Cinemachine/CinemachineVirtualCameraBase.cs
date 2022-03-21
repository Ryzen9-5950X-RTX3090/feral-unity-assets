using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[SaveDuringPlay]
	public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera
	{
		public enum StandbyUpdateMode
		{
			Never,
			Always,
			RoundRobin
		}

		public enum BlendHint
		{
			None,
			SphericalPosition,
			CylindricalPosition,
			ScreenSpaceAimWhenTargetsDiffer
		}

		[Serializable]
		public struct TransitionParams
		{
			[FormerlySerializedAs("m_PositionBlending")]
			[Tooltip("Hint for blending positions to and from this virtual camera")]
			public BlendHint m_BlendHint;

			[Tooltip("When this virtual camera goes Live, attempt to force the position to be the same as the current position of the Unity Camera")]
			public bool m_InheritPosition;

			[Tooltip("This event fires when the virtual camera goes Live")]
			public CinemachineBrain.VcamActivatedEvent m_OnCameraLive;
		}

		[HideInInspector]
		[NoSaveDuringPlay]
		[SerializeField]
		public string[] m_ExcludedPropertiesInInspector;

		[SerializeField]
		[NoSaveDuringPlay]
		[HideInInspector]
		public CinemachineCore.Stage[] m_LockStageInInspector;

		private int m_ValidatingStreamVersion;

		private bool m_OnValidateCalled;

		[HideInInspector]
		[SerializeField]
		[NoSaveDuringPlay]
		private int m_StreamingVersion;

		[NoSaveDuringPlay]
		[Tooltip("The priority will determine which camera becomes active based on the state of other cameras and this camera.  Higher numbers have greater priority.")]
		public int m_Priority;

		[Tooltip("When the virtual camera is not live, this is how often the virtual camera will be updated.  Set this to tune for performance. Most of the time Never is fine, unless the virtual camera is doing shot evaluation.")]
		public StandbyUpdateMode m_StandbyUpdate;

		private List<CinemachineExtension> mExtensions;

		private bool m_WasStarted;

		private bool mSlaveStatusUpdated;

		private CinemachineVirtualCameraBase m_parentVcam;

		private int m_QueuePriority;

		public int ValidatingStreamVersion
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public float FollowTargetAttachment
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

		public float LookAtTargetAttachment
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

		public string Name
		{
			get
			{
				return null;
			}
		}

		public virtual string Description
		{
			get
			{
				return null;
			}
		}

		public int Priority
		{
			get
			{
				return default(int);
			}
			set
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

		public abstract CameraState State { get; }

		public ICinemachineCamera ParentCamera
		{
			get
			{
				return null;
			}
		}

		public abstract Transform LookAt { get; set; }

		public abstract Transform Follow { get; set; }

		public virtual bool PreviousStateIsValid
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual float GetMaxDampTime()
		{
			return default(float);
		}

		public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime)
		{
			return default(float);
		}

		public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime)
		{
			return default(Vector3);
		}

		public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime)
		{
			return default(Vector3);
		}

		public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime)
		{
			return default(float);
		}

		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime)
		{
			return default(Vector3);
		}

		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime)
		{
			return default(Vector3);
		}

		public virtual void AddExtension(CinemachineExtension extension)
		{
		}

		public virtual void RemoveExtension(CinemachineExtension extension)
		{
		}

		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime)
		{
		}

		protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime)
		{
		}

		protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
			return default(bool);
		}

		protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint)
		{
		}

		public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default(bool);
		}

		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);

		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnTransformParentChanged()
		{
		}

		protected virtual void Start()
		{
		}

		internal void EnsureStarted()
		{
		}

		public AxisState.IInputAxisProvider GetInputAxisProvider()
		{
			return null;
		}

		protected virtual void OnValidate()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		private void UpdateSlaveStatus()
		{
		}

		protected Transform ResolveLookAt(Transform localLookAt)
		{
			return null;
		}

		protected Transform ResolveFollow(Transform localFollow)
		{
			return null;
		}

		private void UpdateVcamPoolStatus()
		{
		}

		public void MoveToTopOfPrioritySubqueue()
		{
		}

		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend)
		{
			return null;
		}

		protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens)
		{
			return default(CameraState);
		}
	}
}
