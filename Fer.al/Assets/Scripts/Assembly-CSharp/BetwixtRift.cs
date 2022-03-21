using System.Collections;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class BetwixtRift : Interactable
{
	public enum EMovement
	{
		NONE,
		LEFRIGHT,
		UPDOWN,
		FORWARDBACK,
		CIRCLE,
		MAX
	}

	public enum EMoveDirection
	{
		NONE,
		LEFT,
		RIGHT,
		UP,
		DOWN,
		FORWARD,
		BACK,
		CIRCLE
	}

	private ObscuredFloat _moveRange;

	private ObscuredInt _hitPoints;

	private ObscuredBool _rotateToFacing;

	[SerializeField]
	[Header("Audio")]
	private FeralAudioInfo _audioIdle;

	[SerializeField]
	private FeralAudioInfo _audioHit;

	[SerializeField]
	private FeralAudioInfo _audioDestroyed;

	private ObscuredQuaternion _initialRotationRift;

	private Interactable _interactable;

	private ObscuredBool _visible;

	private ObscuredBool _initializedRift;

	private EMovement _movement;

	private ObscuredInt _currentHitPoints;

	private GameObject _root;

	private EMoveDirection _moveDirection;

	private ObscuredFloat _rotationSpeed;

	private ObscuredFloat _moveSpeed
	{
		get
		{
			return default(ObscuredFloat);
		}
	}

	[IteratorStateMachine(typeof(<TempReSpawn>d__19))]
	public static IEnumerator TempReSpawn(GameObject inBetwixtRiftRoot, Vector3 inPosition, Quaternion inRotation, float inRespawnTimer = 5f)
	{
		return null;
	}

	public override void MStart()
	{
	}

	public override void MOnEnable()
	{
	}

	private void UpdateVisibility()
	{
	}

	public override void MUpdate()
	{
	}

	private Vector3 Clamp(Vector3 inPosition)
	{
		return default(Vector3);
	}

	public override void RequestInteraction(EInteractableMessage inInteractableMessage)
	{
	}

	private static void Log(string inLog)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
