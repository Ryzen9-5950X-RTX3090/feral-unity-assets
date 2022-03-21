using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpellBoltContainer : ManagedBehaviour, IEquippable
{
	public int maxSpellBolts;

	private int _currentSpellBolts;

	public GameObject SpellboltPrefab;

	public SpellBoltSettings BoltSettings;

	public FeralAudioInfo BoltIdle;

	private Transform _ammoDisplaySpot;

	private Transform _attachTransform;

	private Transform _attachTransformFirstPerson;

	private Transform _playerTransform;

	private GameSettingsManager.ControlSetting _controlSetting;

	private const string _attachTransformName = "OffsetTransform";

	private List<GameObject> spellBolts;

	private List<SpellBoltController> boltControllers;

	private List<Vector3> boltLocalLerpPositions;

	private Coroutine _positioningCoroutine;

	private Coroutine[] movingCoroutines;

	private Animator _playerAnimator;

	private bool _isAttached;

	private FallbackInteraction _launchInteraction;

	public bool IsAttached
	{
		get
		{
			return default(bool);
		}
		private set
		{
		}
	}

	public override void MUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void RegisterFallbackInteraction()
	{
	}

	private void UnregisterFallbackInteraction()
	{
	}

	private void InitializeContainer()
	{
	}

	private void Shoot()
	{
	}

	private void UpdateRotation()
	{
	}

	private void AlignFirstPersonAttachPoint()
	{
	}

	private void InstantiateBolts()
	{
	}

	private void updateRotateTargets()
	{
	}

	[IteratorStateMachine(typeof(<MoveBoltsToLocalTargets>d__33))]
	private IEnumerator MoveBoltsToLocalTargets()
	{
		return null;
	}

	public void OnPickup()
	{
	}

	private Transform FindAttachPoint(Transform inTrans)
	{
		return null;
	}

	private void UpdateParent()
	{
	}

	public void OnBoltDoneMoving(int index)
	{
	}

	public void DisableBolts()
	{
	}

	public void Reload()
	{
	}

	private void DestroyContainer()
	{
	}

	public void Unequip()
	{
	}
}
