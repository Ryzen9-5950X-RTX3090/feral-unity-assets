using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class CinemachineComponentBase : MonoBehaviour
	{
		protected const float Epsilon = 0.0001f;

		private CinemachineVirtualCameraBase m_vcamOwner;

		private Transform mCachedFollowTarget;

		private CinemachineVirtualCameraBase mCachedFollowTargetVcam;

		private ICinemachineTargetGroup mCachedFollowTargetGroup;

		private Transform mCachedLookAtTarget;

		private CinemachineVirtualCameraBase mCachedLookAtTargetVcam;

		private ICinemachineTargetGroup mCachedLookAtTargetGroup;

		public CinemachineVirtualCameraBase VirtualCamera
		{
			get
			{
				return null;
			}
		}

		public Transform FollowTarget
		{
			get
			{
				return null;
			}
		}

		public Transform LookAtTarget
		{
			get
			{
				return null;
			}
		}

		public ICinemachineTargetGroup AbstractFollowTargetGroup
		{
			get
			{
				return null;
			}
		}

		public CinemachineTargetGroup FollowTargetGroup
		{
			get
			{
				return null;
			}
		}

		public Vector3 FollowTargetPosition
		{
			get
			{
				return default(Vector3);
			}
		}

		public Quaternion FollowTargetRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		public ICinemachineTargetGroup AbstractLookAtTargetGroup
		{
			get
			{
				return null;
			}
		}

		public CinemachineTargetGroup LookAtTargetGroup
		{
			get
			{
				return null;
			}
		}

		public Vector3 LookAtTargetPosition
		{
			get
			{
				return default(Vector3);
			}
		}

		public Quaternion LookAtTargetRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		public CameraState VcamState
		{
			get
			{
				return default(CameraState);
			}
		}

		public abstract bool IsValid { get; }

		public abstract CinemachineCore.Stage Stage { get; }

		public virtual bool BodyAppliesAfterAim
		{
			get
			{
				return default(bool);
			}
		}

		private void UpdateFollowTargetCache()
		{
		}

		private void UpdateLookAtTargetCache()
		{
		}

		public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public abstract void MutateCameraState(ref CameraState curState, float deltaTime);

		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			return default(bool);
		}

		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		public virtual float GetMaxDampTime()
		{
			return default(float);
		}
	}
}
