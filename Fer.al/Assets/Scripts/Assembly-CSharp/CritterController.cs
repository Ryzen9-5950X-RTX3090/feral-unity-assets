using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CritterController : ManagedBehaviour
{
	[Serializable]
	public class CritterInfo
	{
		public GameObject gameObject;

		public Vector3 priorLocation;

		public Vector3 spawnOffset;

		public Vector3 spawnEuler;

		public Animation animation;

		[HideInInspector]
		public Vector3? moveTo;

		public float idleTimer;

		public bool requireServerValidation;

		[HideInInspector]
		public Vector3? moveToDir;

		private bool _agentChecked;

		[HideInInspector]
		public float speedCheck;

		[HideInInspector]
		public float speed;

		[HideInInspector]
		public bool idle;

		private NavMeshAgent _agent;

		private InteractableDefComponent _interactableDefComponent;

		public NavMeshAgent agent
		{
			get
			{
				return null;
			}
		}

		public InteractableDefComponent interactableDefComponent
		{
			get
			{
				return null;
			}
		}

		public float allowedInteractRange
		{
			get
			{
				return default(float);
			}
		}

		public CritterInfo()
		{
		}

		public CritterInfo(GameObject inModel, bool inRequireServerValidation)
		{
		}
	}

	[Serializable]
	public class AnimationInfo
	{
		public AnimationClip clip;

		public float minSpeedToUse;

		public float fadeLength;
	}

	[SerializeField]
	private GameObject _model;

	[SerializeField]
	private bool _useChildPrefab;

	[SerializeField]
	private AnimationInfo[] _animationInfos;

	[SerializeField]
	private bool _requireServerValidation;

	[SerializeField]
	private float _scale;

	[SerializeField]
	private int _amount;

	[SerializeField]
	private float _moveSpeed;

	private float _turnSpeed;

	private float _acceleration;

	[SerializeField]
	private float _spawnRadius;

	[SerializeField]
	[Tooltip("Max move range for server is 5. Anything more will be invalid.")]
	private float _moveRadius;

	[SerializeField]
	[Tooltip("How close to move position before switching to new position.")]
	private float _stoppingDistance;

	[SerializeField]
	private float _baseOffset;

	[SerializeField]
	private float _idleTimerMin;

	[SerializeField]
	private float _idleTimerMax;

	[SerializeField]
	private Color _gizmoColor;

	[SerializeField]
	[Tooltip("At what distance from the player should the critter be allowed to move?")]
	private float _distanceFromPlayerToMove;

	public List<CritterInfo> critterInfos;

	private float _timeDelta;

	private int _index;

	public float moveRadius
	{
		get
		{
			return default(float);
		}
	}

	public override void MStartAfterLocal()
	{
	}

	public override void MUpdate()
	{
	}

	private Vector3 GetNewMoveTo(CritterInfo inCritterInfo)
	{
		return default(Vector3);
	}

	private void SetAnimation(CritterInfo inCritterInfo)
	{
	}

	private void SetRandomTimer(CritterInfo inCritterInfo)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
