using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	[DisallowMultipleComponent]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/CinemachineClearShot.html")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu("Cinemachine/CinemachineClearShot")]
	public class CinemachineClearShot : CinemachineVirtualCameraBase
	{
		private struct Pair
		{
			public int a;

			public float b;
		}

		[NoSaveDuringPlay]
		[VcamTargetProperty]
		[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all children specify targets of their own.")]
		public Transform m_LookAt;

		[VcamTargetProperty]
		[NoSaveDuringPlay]
		[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all children specify targets of their own.")]
		public Transform m_Follow;

		[NoSaveDuringPlay]
		[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
		public bool m_ShowDebugText;

		[NoSaveDuringPlay]
		[HideInInspector]
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras;

		[Tooltip("Wait this many seconds before activating a new child camera")]
		public float m_ActivateAfter;

		[Tooltip("An active camera must be active for at least this many seconds")]
		public float m_MinDuration;

		[Tooltip("If checked, camera choice will be randomized if multiple cameras are equally desirable.  Otherwise, child list order and child camera priority will be used.")]
		public bool m_RandomizeChoice;

		[CinemachineBlendDefinitionProperty]
		[Tooltip("The blend which is used if you don't explicitly define a blend between two Virtual Cameras")]
		public CinemachineBlendDefinition m_DefaultBlend;

		[HideInInspector]
		public CinemachineBlenderSettings m_CustomBlends;

		private CameraState m_State;

		private float mActivationTime;

		private float mPendingActivationTime;

		private ICinemachineCamera mPendingCamera;

		private CinemachineBlend mActiveBlend;

		private bool mRandomizeNow;

		private CinemachineVirtualCameraBase[] m_RandomizedChilden;

		public override string Description
		{
			get
			{
				return null;
			}
		}

		public ICinemachineCamera LiveChild
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

		public override CameraState State
		{
			get
			{
				return default(CameraState);
			}
		}

		public override Transform LookAt
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Transform Follow
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsBlending
		{
			get
			{
				return default(bool);
			}
		}

		public CinemachineVirtualCameraBase[] ChildCameras
		{
			get
			{
				return null;
			}
		}

		private ICinemachineCamera TransitioningFrom
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

		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default(bool);
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public override void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void OnTransformChildrenChanged()
		{
		}

		private void OnGuiHandler()
		{
		}

		private void InvalidateListOfChildren()
		{
		}

		public void ResetRandomization()
		{
		}

		private void UpdateListOfChildren()
		{
		}

		private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp)
		{
			return null;
		}

		private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src)
		{
			return null;
		}

		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey)
		{
			return default(CinemachineBlendDefinition);
		}

		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}
	}
}
