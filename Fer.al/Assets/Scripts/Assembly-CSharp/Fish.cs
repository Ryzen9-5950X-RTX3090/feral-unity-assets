using System;
using System.Collections.Generic;
using UnityEngine;

public class Fish : ManagedBehaviour
{
	[Serializable]
	public class FishInfo
	{
		public GameObject gameObject;

		public Vector3 spawnPosition;

		public Vector3 spawnRotation;

		public Vector3 moveTo;

		public float idleTimer;

		public bool scattering;

		public Animator animator;

		public bool hasBlend;
	}

	public enum EPathType
	{
		SCATTER,
		ROAM
	}

	[SerializeField]
	private GameObject _model;

	[SerializeField]
	private float _scale;

	[SerializeField]
	private int _amount;

	[SerializeField]
	private float _moveSpeed;

	[SerializeField]
	private float _turnSpeed;

	[SerializeField]
	private float _spawnRadius;

	[SerializeField]
	private float _runAwayRadius;

	[SerializeField]
	private float _stoppingDistance;

	private float _stoppingDistanceSqr;

	[SerializeField]
	private float _scatterDistance;

	[SerializeField]
	private float _idleTimerMin;

	[SerializeField]
	private float _idleTimerMax;

	[SerializeField]
	private Mesh _gizmoMesh;

	[SerializeField]
	private Color _gizmoColor;

	private EnableInRangeToLocalActor _enableInRangeToLocalActor;

	private InteractableDefComponent _interactableDefComponent;

	public EPathType pathType;

	public List<FishInfo> fishInfos;

	private static int _lastFramePlayerPositionUpdated;

	private static bool _playerIsNull;

	private static Vector3 _playerPosition;

	private Transform _cachedTransform;

	public float runAwayRadius
	{
		get
		{
			return default(float);
		}
	}

	public InteractableDefComponent interactableDefComponent
	{
		get
		{
			return null;
		}
	}

	protected static void UpdatePlayerPosition()
	{
	}

	public override void MOnEnable()
	{
	}

	public override void MStartAfterLocal()
	{
	}

	public override void MUpdate()
	{
	}

	private void SetRandomTimer(FishInfo inFishInfo)
	{
	}

	public void Scatter()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
