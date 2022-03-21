using System;
using Cinemachine;
using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryCamera : ManagedBehaviour
{
	[Serializable]
	public class CameraInfo
	{
		[Header("Zoom")]
		public float minZoom;

		public float maxZoom;

		public float zoomAmount;

		[Header("Positioning")]
		public bool allowCameraZ;

		public float minPositionX;

		public float maxPositionX;

		public float minPositionZ;

		public float maxPositionZ;

		[Header("Speeds")]
		public float moveSpeed;

		public float rotationSpeed;

		public float zoomSpeed;

		[Header("Multipliers")]
		public float mouseWheelMultiplier;

		public float mousePositionMultiplier;

		public float mouseRotationMultiplier;

		[Header("Clamps")]
		public float minPitch;

		public float maxPitch;
	}

	[SerializeField]
	[Header("References")]
	private Transform _cameraLocator;

	[SerializeField]
	private Transform _cameraRotator;

	[SerializeField]
	private CinemachineVirtualCamera _virtualCamera;

	[SerializeField]
	private CameraInfo _outdoorCamera;

	[SerializeField]
	private CameraInfo _indoorCamera;

	[SerializeField]
	private CameraInfo _greenhouseOutdoorCamera;

	private CameraInfo _currentCamera;

	private static float _defaultZoom;

	private float _desiredZoom;

	private Vector3 _initialRotation;

	private Vector3 _desiredRotation;

	private Vector3 _initialPosition;

	private Vector3 _desiredPosition;

	private Vector3 _indoorPosition;

	private Vector3 _initialRotationMessage;

	private bool _flipRotation;

	private SanctuaryController.EState _priorState;

	public Vector3 DesiredRotation
	{
		get
		{
			return default(Vector3);
		}
	}

	private bool _indoors
	{
		get
		{
			return default(bool);
		}
	}

	public float zoomPercentage
	{
		get
		{
			return default(float);
		}
	}

	public override void MStart()
	{
	}

	private void UpdateCameraInfo()
	{
	}

	public override void MUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void OnSanctuaryPositionMessage(SanctuaryPositionMessage inMessage)
	{
	}

	public void OnSanctuaryInitialRotationMessage(SanctuaryInitialRotationMessage inMessage)
	{
	}

	public void OnSanctuaryRotationMessage(SanctuaryRotationMessage inMessage)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void ZoomIn()
	{
	}

	public void ZoomOut()
	{
	}

	public void ResetPosition()
	{
	}

	public void ResetRotation()
	{
	}

	public void Rotate()
	{
	}

	public void GoToInterior()
	{
	}

	public void GoToExterior()
	{
	}

	private void MoveAndRotate()
	{
	}

	private void Zoom()
	{
	}

	public void ZoomCamera(float inZoomAmount)
	{
	}

	public void FocusOnRoom(SanctuaryIndoorRoom inRoom)
	{
	}
}
