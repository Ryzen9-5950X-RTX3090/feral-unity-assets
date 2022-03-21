using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpellBoltController : ManagedBehaviour
{
	private bool _hitSomething;

	private Collider _collider;

	private bool _isLaunching;

	private Vector3 _homingPosition;

	private bool _isHoming;

	public FeralAudioInfo BoltLaunch;

	public FeralAudioInfo BoltImpact;

	public bool IsLaunching
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<MoveToTarget>d__11))]
	public IEnumerator MoveToTarget(Action<int> callback, int index, Vector3 targetPosition, float moveSpeed, float homingStrength)
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	[IteratorStateMachine(typeof(<HitTarget>d__13))]
	private IEnumerator HitTarget(Interactable inInteractable)
	{
		return null;
	}

	public void SetHomingTarget(Vector3 newTarget)
	{
	}

	public void ResetHomingTarget()
	{
	}
}
