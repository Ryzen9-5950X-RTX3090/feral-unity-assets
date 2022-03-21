using System;
using UnityEngine;

namespace StrayTech
{
	[Serializable]
	public class PivotCameraStateSettings : ICameraStateSettings
	{
		[SerializeField]
		[Tooltip("The transform to pivot on.")]
		private Transform _pivotHost;

		[SerializeField]
		[Tooltip("The offset from the pivot host position.")]
		private Vector3 _pivotHostOffset;

		[SerializeField]
		[Tooltip("Whether to use camera collision or not. (Requires Camera Collision Component mentioned above)")]
		private bool _useCameraCollision;

		public Transform PivotHost
		{
			get
			{
				return null;
			}
		}

		public Vector3 PivotHostOffset
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

		public PivotCameraStateSettings(Transform pivotHost, Vector3 pivotHostOffset)
		{
		}
	}
}
