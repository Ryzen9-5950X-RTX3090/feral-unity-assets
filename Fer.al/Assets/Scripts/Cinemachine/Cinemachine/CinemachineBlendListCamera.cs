using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	[ExecuteAlways]
	[ExcludeFromPreset]
	[DisallowMultipleComponent]
	[AddComponentMenu("Cinemachine/CinemachineBlendListCamera")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/CinemachineBlendListCamera.html")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
	{
		[Serializable]
		public struct Instruction
		{
			[Tooltip("The virtual camera to activate when this instruction becomes active")]
			public CinemachineVirtualCameraBase m_VirtualCamera;

			[Tooltip("How long to wait (in seconds) before activating the next virtual camera in the list (if any)")]
			public float m_Hold;

			[CinemachineBlendDefinitionProperty]
			[Tooltip("How to blend to the next virtual camera in the list (if any)")]
			public CinemachineBlendDefinition m_Blend;
		}

		[NoSaveDuringPlay]
		[VcamTargetProperty]
		[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
		public Transform m_LookAt;

		[NoSaveDuringPlay]
		[VcamTargetProperty]
		[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
		public Transform m_Follow;

		[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
		public bool m_ShowDebugText;

		[Tooltip("When enabled, the child vcams will cycle indefinitely instead of just stopping at the last one")]
		public bool m_Loop;

		[HideInInspector]
		[NoSaveDuringPlay]
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras;

		[Tooltip("The set of instructions for enabling child cameras.")]
		public Instruction[] m_Instructions;

		private CameraState m_State;

		private float mActivationTime;

		private int mCurrentInstruction;

		private CinemachineBlend mActiveBlend;

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

		public CinemachineVirtualCameraBase[] ChildCameras
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

		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
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

		private void OnTransformChildrenChanged()
		{
		}

		private void OnGuiHandler()
		{
		}

		private void InvalidateListOfChildren()
		{
		}

		private void UpdateListOfChildren()
		{
		}

		internal void ValidateInstructions()
		{
		}

		private void AdvanceCurrentInstruction(float deltaTime)
		{
		}
	}
}
