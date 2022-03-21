using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Birds : ManagedBehaviour
{
	public enum EFormation
	{
		V,
		LINE
	}

	public enum EPathOrder
	{
		RANDOM,
		LINEAR
	}

	public enum EFollowOrder
	{
		LEADER,
		ORDERED,
		INDIVIDUAL
	}

	[Serializable]
	public class BirdInfo
	{
		public Transform followTarget;

		public GameObject spawnedModel;

		public Animator animator;

		public float animTimer;

		public float moveSpeed;

		public float turnSpeed;

		public Vector3 formationOffset;

		public int pathIdx;

		public float pathDetection;
	}

	[SerializeField]
	[Header("Project References")]
	private GameObject[] _model;

	[SerializeField]
	private RuntimeAnimatorController _controller;

	private List<Transform> _path;

	private int _randomMax;

	private List<float> _possibleRandom;

	[SerializeField]
	[Header("Animation Parameters")]
	[Tooltip("This float value should appear in the animator controller.")]
	private string _parameterRandom;

	[SerializeField]
	[Tooltip("This float value should appear in the animator controller. If you have 5 animations you'll need to set randomMax in the AnimatorController to 5")]
	private string _parameterRandomMax;

	[SerializeField]
	[Header("Vars")]
	private float _moveAccel;

	[SerializeField]
	private float _moveSpeed;

	[SerializeField]
	private float _catchupMoveSpeed;

	[SerializeField]
	private float _turnSpeed;

	[SerializeField]
	private float _catchupTurnSpeed;

	[SerializeField]
	private int _spawnCount;

	[SerializeField]
	private float _modelScale;

	[SerializeField]
	private float _followDistance;

	[SerializeField]
	private float _formationOffsetSide;

	[SerializeField]
	private float _formationOffsetSideRandom;

	[SerializeField]
	private float _formationOffsetBack;

	[SerializeField]
	private float _formationOffsetBackRandom;

	[SerializeField]
	private float _pathDetection;

	[SerializeField]
	private float _pathDetectionScalar;

	[SerializeField]
	private EFormation _formation;

	[SerializeField]
	private EPathOrder _pathOrder;

	[SerializeField]
	private EFollowOrder _followOrder;

	[SerializeField]
	private bool _attachBirds;

	[SerializeField]
	private bool _useTrigger;

	[SerializeField]
	private bool _killAtEndOfLinearPath;

	private bool _birdsActive;

	[SerializeField]
	[Header("Animation Timers")]
	[Range(0.5f, 10f)]
	[Tooltip("Minimum amount of time to wait before switching animations.")]
	private float _randomAnimChangeMin;

	[SerializeField]
	[Range(0.5f, 10f)]
	[Tooltip("Maximum amount of time to wait before switching animations.")]
	private float _randomAnimChangeMax;

	[SerializeField]
	[Header("Gizmos")]
	private Mesh _gizmoMesh;

	[SerializeField]
	private Color _gizmoColor;

	private int _birdIndex;

	public List<BirdInfo> _birdInfos;

	public override void MStart()
	{
	}

	private void OnTriggerEnter(Collider inCollider)
	{
	}

	private void SetBirdsActive(bool inActive)
	{
	}

	[IteratorStateMachine(typeof(<Setup>d__41))]
	private IEnumerator Setup()
	{
		return null;
	}

	private int GetRandomPathIdx(int inCurrentIdx)
	{
		return default(int);
	}

	public override void MUpdate()
	{
	}

	private void KillAtEndOfLinearPath()
	{
	}

	private void SetupPath()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
