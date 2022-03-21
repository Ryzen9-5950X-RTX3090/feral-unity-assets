using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

public class QuestMudMonster : MonoBehaviour
{
	public enum EWaypointType
	{
		PingPong,
		Circular
	}

	private enum EMoveState
	{
		None,
		Moving,
		ThrowWait,
		Turning,
		Capturing,
		SpearHit
	}

	private enum EReactionType
	{
		None,
		Throw,
		Capture
	}

	public GraphOwner respawnGraphOwner;

	public Transform mudMonster;

	public Transform mudMonsterHandL;

	public Transform mudMonsterHandR;

	public Transform exclamationIcon;

	public QuestMudMonsterShot npcShot;

	public GameObject grabFX;

	public Transform[] waypoints;

	public float shootWaitTime;

	public float shootDistanceCheck;

	[Tooltip("What angle must the played be within when the player is at the farthest distance (shootDistanceCheck) to be noticed")]
	public float farshootAngleCheck;

	[Tooltip("What angle must the played be within when the player is at the nearest distance (0) to be noticed")]
	public float nearshootAngleCheck;

	public float grabTurnMultiplyer;

	[Tooltip("How long to wait once the grab animation starts before playing the grab fx")]
	public float grabWaitTime_preFX;

	[Tooltip("How long to wait after the grab fx play before triggering the trapped player sequence")]
	public float grabWaitTime_postFX;

	public float optimalGrabDistance;

	public float waypointDetectionDistance;

	public float moveSpeed;

	public float turnSpeed;

	public int shotArchPoints;

	[Tooltip("How high to make the center of the shot arch when the player is at the farthest distance to be noticed (shootDistanceCheck)")]
	public float farArcHeight;

	[Tooltip("How high to make the center of the shot arch when the player is at the nearest distance to be noticed (0)")]
	public float nearArcHeight;

	[Tooltip("How high from the players position on the ground to hit with the projectile")]
	public float yShotHitOffset;

	public float shotScaleTime;

	public Vector3 throwLineOfSiteOffset;

	internal bool isAwareOfPlayer;

	public EWaypointType waypointType;

	[Header("Daily Quest Only")]
	public GameObject areaBlip;

	public GameObject progressUpdatingVolume;

	public GameObject hitPointFX;

	public GameObject explosionFX;

	[Tooltip("spear hits -> _animator.SetFloat(\"HitX\" & \"HitY\") -> hitDelay -> _animator.SetTrigger(\"Death\") / explode FX -> destroyDelay -> Destroy")]
	public float hitDelay;

	public float destroyDelay;

	private Transform _playerTransform;

	private float _archeight;

	private float _shootAngleCheck;

	private float _shootDistanceCheck;

	private float _shootWaitTime;

	private bool _waypointForward;

	private bool _throwLaunching;

	private int _currentWaypointIndex;

	private List<Vector3> _pointList;

	private Vector3 _startPoint;

	private Vector3 _hitPoint;

	private Vector3 _midPoint;

	private Vector3 _desiredFacingDir;

	private Transform _mudMonsterTransform;

	private float speedUp;

	private bool _controlsEnabled;

	private CharacterController _characterController;

	private Animator _animator;

	private GameObject _grabFX;

	private Collider _collider;

	private QuestMudMonsterShot _npcShot;

	private EMoveState _moveState;

	internal static bool gameplayInterrupted;

	internal static List<GameObject> groundHitFX;

	private static bool _respawning;

	private static List<QuestMudMonster> allMudMonsters;

	private static QuestMudMonster _aMudMonster;

	private bool trackSkin;

	private bool findSpearHitPoint;

	private int vertexCount;

	private int closestIndex;

	private QuestSpear spear;

	private Mesh mesh;

	private SkinnedMeshRenderer skin;

	private Vector3[] vertices;

	private Matrix4x4[] boneMatrices;

	private BoneWeight weight;

	private Matrix4x4 bm0;

	private Matrix4x4 bm1;

	private Matrix4x4 bm2;

	private Matrix4x4 bm3;

	private Matrix4x4 vertexMatrix;

	private Vector3 spearPosition;

	internal Transform playerTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private QuestMudMonsterShot NpcShot
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private EMoveState MoveState
	{
		get
		{
			return default(EMoveState);
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	internal static bool GameplayInterrupted()
	{
		return default(bool);
	}

	private void Move()
	{
	}

	[IteratorStateMachine(typeof(<SpearHit>d__94))]
	internal IEnumerator SpearHit(QuestSpear inSpear, Vector3 inHitPoint)
	{
		return null;
	}

	private void Turn()
	{
	}

	private EReactionType TargetCheck(bool inForceLineOfSiteChq = false)
	{
		return default(EReactionType);
	}

	private void Capture()
	{
	}

	private void DangerCheck()
	{
	}

	private void Throw()
	{
	}

	[IteratorStateMachine(typeof(<ThrowLaunch>d__100))]
	private IEnumerator ThrowLaunch()
	{
		return null;
	}

	private void ThrowWait()
	{
	}

	[IteratorStateMachine(typeof(<StartCapture>d__102))]
	private IEnumerator StartCapture()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<MoveToGrabSpot>d__103))]
	private IEnumerator MoveToGrabSpot()
	{
		return null;
	}

	private void RemoveHudAndControl()
	{
	}

	private void TrapPlayer()
	{
	}

	public void TeleportFinished()
	{
	}

	public void RespawnFinished()
	{
	}

	private void ResetNow()
	{
	}

	internal void ThrowHitPlayer()
	{
	}

	private void OnControllerColliderHit(ControllerColliderHit inHit)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
