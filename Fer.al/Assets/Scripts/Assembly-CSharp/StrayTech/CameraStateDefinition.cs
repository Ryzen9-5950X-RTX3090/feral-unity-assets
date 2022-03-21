using System;
using UnityEngine;

namespace StrayTech
{
	[Serializable]
	[RenderHierarchyIcon("Assets/StrayTech/Camera System/Graphics/CameraRig.png")]
	public class CameraStateDefinition : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The camera state to use.")]
		private CameraSystem.CameraStateEnum _cameraState;

		[SerializeField]
		[Tooltip("The type of transition to the new camera state.")]
		private CameraSystem.StateTransitionType _transitionType;

		[SerializeField]
		[Tooltip("The duration of the transition to the new camera state.")]
		private float _transitionDuration;

		[SerializeField]
		[Tooltip("The Camera GameObject to use for this state.")]
		private Camera _camera;

		[SerializeField]
		private FirstPersonCameraStateSettings _firstPersonStateSettings;

		[SerializeField]
		private IsometricCameraStateSettings _isometricStateSettings;

		[SerializeField]
		private SplineCameraStateSettings _splineStateSettings;

		[SerializeField]
		private ThirdPersonCameraStateSettings _thirdPersonStateSettings;

		[SerializeField]
		private FeralCameraStateSettings _feralStateSettings;

		[SerializeField]
		private AnimatedCameraStateSettings _animatedCameraStateSettings;

		[SerializeField]
		private PivotCameraStateSettings _pivotCameraStateSettings;

		[SerializeField]
		private ParentedCameraStateSettings _parentedCameraStateSettings;

		private ICameraState _state;

		public ICameraState State
		{
			get
			{
				return null;
			}
		}

		public CameraSystem.StateTransitionType TransitionType
		{
			get
			{
				return default(CameraSystem.StateTransitionType);
			}
		}

		public float TransitionDuration
		{
			get
			{
				return default(float);
			}
		}

		public Camera Camera
		{
			get
			{
				return null;
			}
		}

		private void Start()
		{
		}

		public void InitializeState()
		{
		}

		public void AddCameraStateTriggerChild()
		{
		}

		public void AddCameraSplineChild()
		{
		}
	}
}
