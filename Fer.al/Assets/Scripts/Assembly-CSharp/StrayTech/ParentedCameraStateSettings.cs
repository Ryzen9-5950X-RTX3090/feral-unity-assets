using System;
using UnityEngine;

namespace StrayTech
{
	[Serializable]
	public class ParentedCameraStateSettings : ICameraStateSettings
	{
		[SerializeField]
		[Tooltip("The GameObject to parent to.")]
		private GameObject _parent;

		[SerializeField]
		[Tooltip("Position offset from parent.")]
		private Vector3 _positionOffset;

		[SerializeField]
		[Tooltip("Rotation offset from parent in euler angles.")]
		private Vector3 _rotationOffset;

		[SerializeField]
		[Tooltip("Whether to use camera collision or not. (Requires Camera Collision Component mentioned above)")]
		private bool _useCameraCollision;

		public GameObject Parent
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

		public Vector3 RotationOffset
		{
			get
			{
				return default(Vector3);
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

		public ParentedCameraStateSettings(GameObject parent, Vector3 positionOffset, Vector3 rotationOffset)
		{
		}
	}
}
