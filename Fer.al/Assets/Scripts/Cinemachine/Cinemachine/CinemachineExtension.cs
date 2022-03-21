using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class CinemachineExtension : MonoBehaviour
	{
		protected const float Epsilon = 0.0001f;

		private CinemachineVirtualCameraBase m_vcamOwner;

		private Dictionary<ICinemachineCamera, object> mExtraState;

		public CinemachineVirtualCameraBase VirtualCamera
		{
			get
			{
				return null;
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		internal void EnsureStarted()
		{
		}

		protected virtual void ConnectToVcam(bool connect)
		{
		}

		public virtual void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime)
		{
		}

		public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);

		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
			return default(bool);
		}

		public virtual float GetMaxDampTime()
		{
			return default(float);
		}

		protected T GetExtraState<T>(ICinemachineCamera vcam) where T : class, new()
		{
			return null;
		}

		protected List<T> GetAllExtraStates<T>() where T : class, new()
		{
			return null;
		}
	}
}
