using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class AnimatorSwitcher : ManagedBehaviour
{
	[Serializable]
	public class StateInfo
	{
		public string stateName;

		public float waitMin;

		public float waitMax;

		public bool looped;

		[HideInInspector]
		public bool isLooping;

		public UnityEvent OnState;
	}

	public StateInfo[] stateInfos;

	public bool repeatForever;

	public int repeats;

	private int repeatsSoFar;

	private Animator _animator;

	private int _stateIndex;

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	private void SetAnimator()
	{
	}

	[IteratorStateMachine(typeof(<AnimCoroutine>d__10))]
	private IEnumerator AnimCoroutine()
	{
		return null;
	}
}
