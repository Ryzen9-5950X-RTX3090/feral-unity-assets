using System;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class UI_Stage : MonoBehaviour
{
	[Serializable]
	public class StageCameraSetting
	{
		[SerializeField]
		private CinemachineVirtualCamera _virtualCamera;

		[SerializeField]
		private float _minFOV;

		[SerializeField]
		private float _maxFOV;

		private CinemachineComposer _composer;

		public CinemachineVirtualCamera VirtualCamera
		{
			get
			{
				return null;
			}
		}

		public CinemachineComposer Composer
		{
			get
			{
				return null;
			}
		}

		public void UpdatZoomLevel(float inNormalizedZoom)
		{
		}
	}

	protected bool isMobile;

	[SerializeField]
	private GameObject _doNotDestroyRoot;

	[SerializeField]
	protected PlayerCameraMode _cameraMode;

	[SerializeField]
	private GameObject[] _disableOnMobile;

	protected PlayerCameraMode _previousPlayerCameraMode;

	protected Scene _scene;

	public abstract Transform SpinTarget { get; }

	public abstract StageCameraSetting ActiveCameraSetting { get; }

	public virtual void RemoveScene(string inLevelDefId)
	{
	}

	private void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void Update()
	{
	}
}
