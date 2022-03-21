using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[ExcludeFromPreset]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu("Cinemachine/CinemachineMixingCamera")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/CinemachineMixingCamera.html")]
	public class CinemachineMixingCamera : CinemachineVirtualCameraBase
	{
		public const int MaxCameras = 8;

		[Tooltip("The weight of the first tracked camera")]
		public float m_Weight0;

		[Tooltip("The weight of the second tracked camera")]
		public float m_Weight1;

		[Tooltip("The weight of the third tracked camera")]
		public float m_Weight2;

		[Tooltip("The weight of the fourth tracked camera")]
		public float m_Weight3;

		[Tooltip("The weight of the fifth tracked camera")]
		public float m_Weight4;

		[Tooltip("The weight of the sixth tracked camera")]
		public float m_Weight5;

		[Tooltip("The weight of the seventh tracked camera")]
		public float m_Weight6;

		[Tooltip("The weight of the eighth tracked camera")]
		public float m_Weight7;

		private CameraState m_State;

		private CinemachineVirtualCameraBase[] m_ChildCameras;

		private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap;

		private ICinemachineCamera LiveChild
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

		public override Transform Follow
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

		public float GetWeight(int index)
		{
			return default(float);
		}

		public void SetWeight(int index, float w)
		{
		}

		public float GetWeight(CinemachineVirtualCameraBase vcam)
		{
			return default(float);
		}

		public void SetWeight(CinemachineVirtualCameraBase vcam, float w)
		{
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public override void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		protected override void OnEnable()
		{
		}

		public void OnTransformChildrenChanged()
		{
		}

		protected override void OnValidate()
		{
		}

		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default(bool);
		}

		protected void InvalidateListOfChildren()
		{
		}

		protected void ValidateListOfChildren()
		{
		}

		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}
	}
}
