using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QuestSpear : MonoBehaviour, IEquippable
{
	public QuestSpearSettings questSpearSettings;

	public GameObject movingFX;

	public GameObject basicImpactFX;

	public Transform returnRotater;

	public Vector3 attachRotation;

	public FeralAudioInfo spearLaunch;

	public FeralAudioInfo spearReturn;

	public FeralAudioInfo spearMiss;

	public FeralAudioInfo spearImpact;

	public FeralAudioInfo spearImpactMudBall;

	public FeralAudioInfo spearImpactMudMonster;

	public FeralAudioInfo spearPickup;

	internal Transform playerTransform;

	internal bool canLaunch;

	private bool _underPlayerControl;

	private Vector3[] _returnArchPointList;

	private Transform _attachTransform;

	private Transform _attachTransformFirstPerson;

	private Transform _originalLocation;

	private Vector3 _targetPosition;

	private Coroutine moveCoroutine;

	private Coroutine returnCoroutine;

	private Coroutine returnRotateCoroutine;

	private Interaction _interaction;

	private Collider _collider;

	private Animator _playerAnimator;

	private Animator _spearAnimator;

	private GameSettingsManager.ControlSetting _controlSetting;

	private Renderer[] _renderers;

	private FallbackInteraction _launchInteraction;

	private const string _attachTransformName = "OffsetTransform";

	public bool UnderPlayerControl
	{
		get
		{
			return default(bool);
		}
		private set
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

	private void AlignFirstPersonAttachPoint()
	{
	}

	private void LateUpdate()
	{
	}

	private void RegisterFallbackInteraction()
	{
	}

	private void UnregisterFallbackInteraction()
	{
	}

	public void PickedUp()
	{
	}

	private Transform FindAttachPoint(Transform inTrans)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<AttachToPlayer>d__43))]
	internal IEnumerator AttachToPlayer()
	{
		return null;
	}

	private void Launch()
	{
	}

	internal void CanLaunch(bool inCanLaunch)
	{
	}

	private void OnDrawGizmos()
	{
	}

	[IteratorStateMachine(typeof(<MoveToTarget>d__47))]
	internal IEnumerator MoveToTarget()
	{
		return null;
	}

	private Vector3[] GetReturnPointList(Vector3 inStartPoint, Vector3 inEndPoint)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<ReturnToPlayer>d__49))]
	internal IEnumerator ReturnToPlayer(float inDelay)
	{
		return null;
	}

	private void SetParent()
	{
	}

	[IteratorStateMachine(typeof(<ReturnRotate>d__51))]
	internal IEnumerator ReturnRotate()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	internal void ImpactComplete()
	{
	}

	public void ResetToRack(bool inComplete = true)
	{
	}

	[IteratorStateMachine(typeof(<ReturnToOriginalLocation>d__55))]
	private IEnumerator ReturnToOriginalLocation(bool inComplete)
	{
		return null;
	}

	public void Unequip()
	{
	}
}
