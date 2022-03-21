using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Cinemachine
{
	[SaveDuringPlay]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/CinemachineBrainProperties.html")]
	[AddComponentMenu("Cinemachine/CinemachineBrain")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineBrain : MonoBehaviour
	{
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum UpdateMethod
		{
			FixedUpdate,
			LateUpdate,
			SmartUpdate,
			ManualUpdate
		}

		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum BrainUpdateMethod
		{
			FixedUpdate,
			LateUpdate
		}

		[Serializable]
		public class BrainEvent : UnityEvent<CinemachineBrain>
		{
		}

		[Serializable]
		public class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera>
		{
		}

		private class BrainFrame
		{
			public int id;

			public CinemachineBlend blend;

			public CinemachineBlend workingBlend;

			public BlendSourceVirtualCamera workingBlendSource;

			public float deltaTimeOverride;

			public bool Active
			{
				get
				{
					return default(bool);
				}
			}
		}

		[Tooltip("When enabled, the current camera and blend will be indicated in the game window, for debugging")]
		public bool m_ShowDebugText;

		[Tooltip("When enabled, the camera's frustum will be shown at all times in the scene view")]
		public bool m_ShowCameraFrustum;

		[Tooltip("When enabled, the cameras will always respond in real-time to user input and damping, even if the game is running in slow motion")]
		public bool m_IgnoreTimeScale;

		[Tooltip("If set, this object's Y axis will define the worldspace Up vector for all the virtual cameras.  This is useful for instance in top-down game environments.  If not set, Up is worldspace Y.  Setting this appropriately is important, because Virtual Cameras don't like looking straight up or straight down.")]
		public Transform m_WorldUpOverride;

		[Tooltip("The update time for the vcams.  Use FixedUpdate if all your targets are animated during FixedUpdate (e.g. RigidBodies), LateUpdate if all your targets are animated during the normal Update loop, and SmartUpdate if you want Cinemachine to do the appropriate thing on a per-target basis.  SmartUpdate is the recommended setting")]
		public UpdateMethod m_UpdateMethod;

		[Tooltip("The update time for the Brain, i.e. when the blends are evaluated and the brain's transform is updated")]
		public BrainUpdateMethod m_BlendUpdateMethod;

		[CinemachineBlendDefinitionProperty]
		[Tooltip("The blend that is used in cases where you haven't explicitly defined a blend between two Virtual Cameras")]
		public CinemachineBlendDefinition m_DefaultBlend;

		[Tooltip("This is the asset that contains custom settings for blends between specific virtual cameras in your scene")]
		public CinemachineBlenderSettings m_CustomBlends;

		private Camera m_OutputCamera;

		[Tooltip("This event will fire whenever a virtual camera goes live and there is no blend")]
		public BrainEvent m_CameraCutEvent;

		[Tooltip("This event will fire whenever a virtual camera goes live.  If a blend is involved, then the event will fire on the first frame of the blend.")]
		public VcamActivatedEvent m_CameraActivatedEvent;

		private static ICinemachineCamera mSoloCamera;

		private Coroutine mPhysicsCoroutine;

		private WaitForFixedUpdate mWaitForFixedUpdate;

		private List<BrainFrame> mFrameStack;

		private int mNextFrameId;

		private CinemachineBlend mCurrentLiveCameras;

		private static readonly AnimationCurve mDefaultLinearAnimationCurve;

		private ICinemachineCamera mActiveCameraPreviousFrame;

		public Camera OutputCamera
		{
			get
			{
				return null;
			}
		}

		public static ICinemachineCamera SoloCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 DefaultWorldUp
		{
			get
			{
				return default(Vector3);
			}
		}

		public ICinemachineCamera ActiveVirtualCamera
		{
			get
			{
				return null;
			}
		}

		public bool IsBlending
		{
			get
			{
				return default(bool);
			}
		}

		public CinemachineBlend ActiveBlend
		{
			get
			{
				return null;
			}
		}

		public CameraState CurrentCameraState
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

		public static Color GetSoloGUIColor()
		{
			return default(Color);
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		private void OnSceneUnloaded(Scene scene)
		{
		}

		private void Start()
		{
		}

		private void OnGuiHandler()
		{
		}

		[IteratorStateMachine(typeof(<AfterPhysics>d__32))]
		private IEnumerator AfterPhysics()
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		public void ManualUpdate()
		{
		}

		private float GetEffectiveDeltaTime(bool fixedDelta)
		{
			return default(float);
		}

		private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime)
		{
		}

		private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend)
		{
			return null;
		}

		private int GetBrainFrame(int withId)
		{
			return default(int);
		}

		public int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime)
		{
			return default(int);
		}

		public void ReleaseCameraOverride(int overrideId)
		{
		}

		private void ProcessActiveCamera(float deltaTime)
		{
		}

		private void UpdateFrame0(float deltaTime)
		{
		}

		public void ComputeCurrentBlend(ref CinemachineBlend outputBlend, int numTopLayersToExclude)
		{
		}

		public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default(bool);
		}

		private ICinemachineCamera TopCameraFromPriorityQueue()
		{
			return null;
		}

		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey)
		{
			return default(CinemachineBlendDefinition);
		}

		private void PushStateToUnityCamera(CameraState state)
		{
		}
	}
}
