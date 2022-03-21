using System;
using UnityEngine;

namespace StrayTech
{
	[Serializable]
	public class FirstPersonCameraStateSettings : ICameraStateSettings
	{
		[SerializeField]
		[Tooltip("The transform that the cameraâ\u0080\u0099s position will be parented to.")]
		private Transform _positionRootTransform;

		[SerializeField]
		[Tooltip("The root transform of the character. (Y axis camera rotation is applied to the root)")]
		private Transform _characterTransform;

		[SerializeField]
		[Tooltip("Position offset from the PositionRootTransform")]
		private Vector3 _positionOffset;

		[SerializeField]
		[Tooltip("The range of vertical rotation.")]
		private Vector2 _pitchRange;

		[SerializeField]
		[Tooltip("Sensitivity of mouse movement on each axis.")]
		private Vector2 _mouseLookSensitivity;

		[SerializeField]
		[Tooltip("Amount of mouse smoothing to apply.")]
		private float _mouseSmoothing;

		public Transform PositionRootTransform
		{
			get
			{
				return null;
			}
		}

		public Transform CharacterTransform
		{
			get
			{
				return null;
			}
		}

		public Vector3 PositionOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector2 PitchRange
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 MouseLookSensitivity
		{
			get
			{
				return default(Vector2);
			}
		}

		public float MouseSmoothing
		{
			get
			{
				return default(float);
			}
		}

		public bool UseCameraCollision
		{
			get
			{
				return default(bool);
			}
		}

		public CameraSystem.CameraStateEnum StateType
		{
			get
			{
				return default(CameraSystem.CameraStateEnum);
			}
		}

		public FirstPersonCameraStateSettings(Transform positionRoot, Transform characterTransform, Vector3 positionOffset, Vector2 pitchRange, Vector2 mouseLookSensitivity, float mouseSmoothing)
		{
		}
	}
}
